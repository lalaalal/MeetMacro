﻿using System;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MeetMacro
{
    public class Macro : IDisposable
    {
        private static class MeetXPath
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
            public static readonly string ENTER_MEET_BUTTON_ALTER = "//*[@id=\"yDmH0d\"]/c-wiz/div/div/div[8]/div[3]/div/div/div[2]/div/div[1]/div[2]/div/div[2]/div/div[1]/div[1]/span/span";
            public static readonly string EXIT_MEET_BUTTON_XPATH = "//*[@id=\"ow3\"]/div[1]/div/div[7]/div[3]/div[9]/div[2]/div[2]/div";
            public static readonly string RETURN_HOME_BUTTON_XPATH = "//*[@id=\"ow3\"]/div/div[2]/div[2]/div/span/span";
            public static readonly string MEET_NOT_STARTED_XPATH = "//*[@id=\"yDmH0d\"]/c-wiz/div/div[2]/div/div/span/span";
        }

        private readonly ChromeDriver driver;

        private readonly Schedule schedule;

        private readonly Schedule.Time startOffset;
        private readonly Schedule.Time endOffset;

        private readonly int timeout;

        private readonly Logger logger;

        public Macro(Setting setting, Logger logger)
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver(chromeDriverService, options);

            ScheduleSaver scheduleSaver = new ScheduleSaver(setting);
            schedule = scheduleSaver.Schedule;
            timeout = setting.ElementLoadTimeout;
            startOffset = new Schedule.Time(0, setting.StartTimeOffset);
            endOffset = new Schedule.Time(0, setting.EndTimeOffset);

            this.logger = logger;
        }

        public void Dispose()
        {
            driver.Quit();
        }

        private IWebElement LoadElement(string xpath, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeout));
            return wait.Until(x => x.FindElement(By.XPath(xpath)));
        }

        private IWebElement LoadElement(string xpath)
        {
            return LoadElement(xpath, timeout);
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
            logger.AddLog("Entering Meet : " + code);
            LoadElement(MeetXPath.CODE_ENTERANCE_BUTTON_XPATH).Click();
            LoadElement(MeetXPath.CODE_INPUT_XPATH).SendKeys(code);
            Thread.Sleep(500);
            LoadElement(MeetXPath.CODE_ENTER_BUTTON_XPATH).Click();
            try
            {
                CheckPerm();
                CheckMeetNotStarted();
                Thread.Sleep(500);
                
                logger.AddLog("Entering");
                EnterMeetButton();
            }
            catch (Exception)
            {
                logger.AddLog("Entering Failed, Retry");
                EnterMeet(code);
            }
        }

        private void EnterMeetButton()
        {
            try
            {
                LoadElement(MeetXPath.ENTER_MEET_BUTTON_XPATH, timeout / 2).Click();
            }
            catch (Exception)
            {
                LoadElement(MeetXPath.ENTER_MEET_BUTTON_ALTER, timeout / 2).Click();
            }
        }

        private void CheckMeetNotStarted()
        {
            try
            {
                LoadElement(MeetXPath.MEET_NOT_STARTED_XPATH).Click();
            } catch (Exception)
            {

            }
        }

        private void CheckPerm()
        {
            try
            {
                LoadElement("//*[@id=\"yDmH0d\"]/div[3]/div/div[2]/div[3]/div/span/span").Click();
            }
            catch (Exception)
            {

            }
        }

        private void ExitMeet()
        {
            driver.Navigate().GoToUrl("https://meet.google.com");
        }

        public void Run(string id, string pw)
        {
            logger.AddLog("Start!");
            logger.AddLog("Login with " + id);
            Login(id, pw);
            logger.AddLog("Login Succeeded");
            driver.Navigate().GoToUrl("https://meet.google.com");

            int dayOfWeek = (int)(DateTime.Now.DayOfWeek - 1);
            while (!DoesSchoolEnd())
            {
                int nextClassNo = schedule.GetNextClassNo(Schedule.Time.Now);
                string code = schedule.Code[dayOfWeek, nextClassNo];
                Schedule.Time nextClassStartTime = schedule.StartTime[nextClassNo];
                Schedule.Time nextClassEndTime = schedule.EndTime[nextClassNo];

                logger.AddLog("Code : " + code);

                logger.AddLog("Waiting (enter) until " + (nextClassStartTime - startOffset).ToString());
                SpinWait.SpinUntil(() => IsTimeToEnter(nextClassStartTime, startOffset));
                EnterMeet(code);

                logger.AddLog("Waiting (exit) until " + (nextClassEndTime + endOffset).ToString());
                SpinWait.SpinUntil(() => IsTimeToExit(nextClassEndTime, endOffset));
                ExitMeet();
            }
            logger.AddLog("Ended");
        }

        private bool IsTimeToEnter(Schedule.Time startTime, Schedule.Time offset)
        {
            return Schedule.Time.Now >= (startTime - offset);
        }

        private bool IsTimeToExit(Schedule.Time endTime, Schedule.Time offset)
            => Schedule.Time.Now >= endTime + offset;

        private bool DoesSchoolEnd()
            => Schedule.Time.Now >= schedule.EndTime[7];
    }
}
