using System;
using System.Collections.Generic;
using System.Text;

namespace MeetMacro
{
    public class ISDJSchedule : Schedule
    {
        public static readonly int MAX_CLASS_COUNT = 7;

        private static readonly string[] _startTime =
        {
            "08:10", "08:30", "09:30", "10:30", "11:30", "13:20", "14:20", "15:20"
        };

        private static readonly string[] _endTime =
        {
            "08:20", "09:20", "10:20", "11:20", "12:20", "14:10", "15:10", "16:10"
        };

        public ISDJSchedule() : base(_startTime, _endTime, new string[5, _startTime.Length])
        {

        }

        //public override void SetCode(int dayOfWeek, int classNo, string code)
        //    => _code[dayOfWeek, classNo] = code;

        public override void SetDefault(string classroom)
        {
            int dayOfWeekCount = DayOfWeekCode.Length;

            for (int dayOfWeek = 0; dayOfWeek < dayOfWeekCount; dayOfWeek++)
            {
                for (int classNo = 0; classNo < StartTime.Length; classNo++)
                {
                    string code = classroom + DayOfWeekCode[dayOfWeek] + string.Format("{0:00}", classNo);
                    SetCode(dayOfWeek, classNo, code);
                }
            }
        }
    }
}
