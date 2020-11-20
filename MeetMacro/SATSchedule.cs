using System;
using System.Collections.Generic;
using System.Text;

namespace MeetMacro
{
    public class SATSchedule : Schedule
    {
        private static readonly string[] _startTime =
{
            "08:10", "08:30", "10:30", "13:10", "15:10"
        };

        private static readonly string[] _endTime =
        {
            "08:20", "10:10", "12:10", "13:10", "16:10"
        };

        public SATSchedule() : base(_startTime, _endTime, new string[5, _startTime.Length])
        {

        }

        public override void SetDefault(string classroom)
        {
            int dayOfWeekCount = DayOfWeekCode.Length;

            for (int dayOfWeek = 0; dayOfWeek < dayOfWeekCount; dayOfWeek++)
            {
                string code = classroom + DayOfWeekCode[dayOfWeek] + "00";
                SetCode(dayOfWeek, 0, code);
            }

            for (int dayOfWeek = 0; dayOfWeek < dayOfWeekCount; dayOfWeek++)
            {
                for (int classNo = 1; classNo < StartTime.Length; classNo++)
                {
                    string code = classroom + DayOfWeekCode[dayOfWeek] + string.Format("{0:00}", classNo * 2 - 1);
                    SetCode(dayOfWeek, classNo, code);
                }
            }
        }
    }
}
