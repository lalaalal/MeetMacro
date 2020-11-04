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
            public static readonly string CLASSROOM = "CLASSROOM";
            public static readonly string SCHEDULE_TYPE = "SCHEDULE_TYPE";
        }

        public static Setting Default => GetDefault();

        private static Setting GetDefault()
        {
            Setting defaultSetting = new Setting
            {
                [Attributes.ELEMENT_LOAD_TIMEOUT] = "10",
                [Attributes.VIEW_LOG] = "true",
                [Attributes.CLASSROOM] = "307",
                [Attributes.SCHEDULE_TYPE] = "isdj"
            };

            return defaultSetting;
        }
    }
}
