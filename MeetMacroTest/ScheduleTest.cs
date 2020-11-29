using NUnit.Framework;
using MeetMacro;

namespace MeetMacroTest
{
    public class ScheduleTest
    {
        private Schedule.Time a;
        private Schedule.Time b;

        [SetUp]
        public void Setup()
        {
            a = new Schedule.Time(3, 30);
            b = new Schedule.Time(4, 40);
        }

        [Test]
        public void TimeAddTest()
        {
            Assert.AreEqual(new Schedule.Time(8, 10), a + b);
        }

        [Test]
        public void TimeSubtractTest()
        {
            Assert.AreEqual(new Schedule.Time(22, 50), a - b);
        }

        [Test]
        public void GetNextClassNoTest()
        {
            Schedule schedule = new ISDJSchedule();
            string[] _testTimes = { "08:08", "08:28", "09:28", "10:28", "11:28", "13:18", "14:18", "15:18", "16:12" };
            Schedule.Time[] testTimes = Schedule.Time.Parse(_testTimes);
            for (int i = 0; i < testTimes.Length; i++)
                Assert.AreEqual(i, schedule.GetNextClassNo(testTimes[i]));
        }

    }
}
