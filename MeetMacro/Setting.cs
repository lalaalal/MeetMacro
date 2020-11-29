using System;
using System.Collections.Generic;

namespace MeetMacro
{
    public class Setting : Dictionary<string, string>
    {
        public static class Attributes
        {
            public static readonly string ELEMENT_LOAD_TIMEOUT = "ELEMENT_LOAD_TIMEOUT";
            public static readonly string VIEW_LOG = "VIEW_LOG";
            public static readonly string DEFAULT_CLASSROOM = "CLASSROOM";
            public static readonly string SCHEDULE_TYPE = "SCHEDULE_TYPE";
            public static readonly string START_TIME_OFFSET = "START_TIME_OFFSET";
            public static readonly string END_TIME_OFFSET = "END_TIME_OFFSET";
        }

        public int ElementLoadTimeout
        {
            get => int.Parse(this[Attributes.ELEMENT_LOAD_TIMEOUT]);
            set => this[Attributes.ELEMENT_LOAD_TIMEOUT] = value.ToString();
        }
        public bool ViewLog 
        {
            get => bool.Parse(this[Attributes.VIEW_LOG]);
            set => this[Attributes.VIEW_LOG] = value.ToString();
        }
        public string DefaultClassroom
        {
            get => this[Attributes.DEFAULT_CLASSROOM];
            set => this[Attributes.DEFAULT_CLASSROOM] = value;
        }
        public string ScheduleType
        {
            get => this[Attributes.SCHEDULE_TYPE];
            set => this[Attributes.SCHEDULE_TYPE] = value;
        }
        public int StartTimeOffset 
        {
            get => int.Parse(this[Attributes.START_TIME_OFFSET]);
            set => this[Attributes.START_TIME_OFFSET] = value.ToString();
        }
        public int EndTimeOffset
        {
            get => int.Parse(this[Attributes.END_TIME_OFFSET]);
            set => this[Attributes.END_TIME_OFFSET] = value.ToString();
        }

        public static Setting Default => GetDefault();

        private static Setting GetDefault()
        {
            Setting defaultSetting = new Setting
            {
                ElementLoadTimeout = 10,
                ViewLog = true,
                DefaultClassroom = "307",
                ScheduleType = "isdj",
                StartTimeOffset = 2,
                EndTimeOffset = 1,
            };

            return defaultSetting;
        }
    }
}
