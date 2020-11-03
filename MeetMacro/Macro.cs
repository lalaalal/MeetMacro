using System;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MeetMacro
{
    public class Macro : IDisposable
    {
        private class MeetXPath
        {
            public static readonly string LOGIN_BUTTON_XPATH = "//*[@id=\"gb_70\"]";
            public static readonly string ID_INPUT_XPATH = "//*[@id=\"identifierId\"]";
            public static readonly string ID_NEXT_BUTTON_XPATH = "//*[@id=\"identifierNext\"]/div/button/div[2]";
            public static readonly string PW_INPUT_XPATH = "//*[@id=\"password\"]/div[1]/div/div[1]/input";
            public static readonly string PW_NEXT_BUTTON_XPATH = "//*[@id=\"passwordNext\"]/div/button/div[2]";
            public static readonly string USER_ICON_XPATH = "//*[@id=\"gbw\"]/div/div/div[2]/div[2]/div[1]/a/img";

            public static readonly string CODE_ENTERANCE_BUTTON_XPATH = "//*[@id=\"yDmH0d\"]/c-wiz/div/div/div/div[2]/div[2]/div[2]/div/c-wiz/div[1]/div/div/div[1]/div";
            public static readonly string CODE_INPUT_XPATH = "//*[@id=\"yDmH0d\"]/div[3]/div/div[2]/span/div/div[2]/div[1]/div[1]/input";
            public static readonly string CODE_ENTER_BUTTON_XPATH = "//*[@id=\"yDmH0d\"]/div[3]/div/div[2]/span/div/div[4]/div[2]/div/span";
            public static readonly string TOGGLE_CAMERA_BUTTON_XPATH = "//*[@id=\"yDmH0d\"]/c-wiz/div/div/div[7]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div[4]/div[2]/div/div";
            public static readonly string ENTER_MEET_BUTTON_XPATH = "//*[@id=\"yDmH0d\"]/c-wiz/div/div/div[7]/div[3]/div/div/div[2]/div/div[1]/div[2]/div/div[2]/div/div[1]/div[1]/span";
            public static readonly string EXIT_MEET_BUTTON_XPATH = "//*[@id=\"ow3\"]/div[1]/div/div[7]/div[3]/div[9]/div[2]/div[2]/div";
            public static readonly string RETURN_HOME_BUTTON_XPATH = "//*[@id=\"ow3\"]/div/div[2]/div[2]/div/span/span";
        }

        private ChromeDriver driver;

        private Schedule schedule;

        private static readonly Schedule.Time START_OFFSET = new Schedule.Time(0, 2);
        private static readonly Schedule.Time END_OFFSET = new Schedule.Time(0, 1);

        private int timeout;

        public Macro(Schedule schedule, int timeout)
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = false;
            ChromeOptions options = new ChromeOptions();

            driver = new ChromeDriver(chromeDriverService, options);

            this.schedule = schedule;
            this.timeout = timeout;
        }

        public void Dispose()
        {
            driver.Quit();
        }

        private IWebElement LoadElement(string xpath)
        {
            WebDriverWait defaultWait = new WebDriverWait(driver, new TimeSpan(0, 0, timeout));
            return defaultWait.Until(x => x.FindElement(By.XPath(xpath)));
        }
        
        private void Login(string id, string pw)
        {
            driver.Navigate().GoToUrl("https://google.com/");

            LoadElement(MeetXPath.LOGIN_BUTTON_XPATH).Click();
            LoadElement(MeetXPath.ID_INPUT_XPATH).SendKeys(id);
            LoadElement(MeetXPath.ID_NEXT_BUTTON_XPATH).Click();
            LoadElement(MeetXPath.PW_INPUT_XPATH).SendKeys(pw);
            LoadElement(MeetXPath.PW_NEXT_BUTTON_XPATH).Click();
            LoadElement(MeetXPath.USER_ICON_XPATH);
        }

        private void EnterMeet(string code)
        {
            LoadElement(MeetXPath.CODE_ENTERANCE_BUTTON_XPATH).Click();
            LoadElement(MeetXPath.CODE_INPUT_XPATH).SendKeys(code);
            Thread.Sleep(500);
            LoadElement(MeetXPath.CODE_ENTER_BUTTON_XPATH).Click();
            try
            {
                //LoadElement(MeetXPath.TOGGLE_CAMERA_BUTTON_XPATH).Click();
                LoadElement(MeetXPath.ENTER_MEET_BUTTON_XPATH).Click();
            }
            catch (ElementNotInteractableException)
            {
                EnterMeet(code);
            }
        }

        private void ExitMeet()
        {
            LoadElement(MeetXPath.EXIT_MEET_BUTTON_XPATH).Click();
            LoadElement(MeetXPath.RETURN_HOME_BUTTON_XPATH).Click();
        }

        public void Run(string id, string pw)
        {
            Login(id, pw);
            driver.Navigate().GoToUrl("https://meet.google.com");

            int dayOfWeek = (int)(DateTime.Now.DayOfWeek - 1);
            while (!DoesSchoolEnd())
            {
                int nextClassNo = schedule.GetNextClassNo(Schedule.Time.Now);
                string code = schedule.Code[dayOfWeek, nextClassNo];
                Schedule.Time nextClassStartTime = schedule.StartTime[nextClassNo];
                Schedule.Time nextClassEndTime = schedule.EndTime[nextClassNo];

                SpinWait.SpinUntil(() => isTimeToEnter(nextClassStartTime, START_OFFSET));
                EnterMeet(code);

                SpinWait.SpinUntil(() => isTimeToExit(nextClassEndTime, END_OFFSET));
                ExitMeet();
            }
        }

        private bool isTimeToEnter(Schedule.Time startTime, Schedule.Time offset)
        {
            return Schedule.Time.Now >= (startTime - offset);
        }

        private bool isTimeToExit(Schedule.Time endTime, Schedule.Time offset)
            => Schedule.Time.Now >= endTime + offset;

        private bool DoesSchoolEnd()
            => Schedule.Time.Now >= schedule.EndTime[7];
    }
}
