using System;
using System.IO;

namespace MeetMacro
{
    public class ScheduleSaver : Saver
    {
        public static readonly string FILE_NAME = "schedule.txt";

        public Schedule Schedule { private set; get; }

        public ScheduleSaver(string scheduleType, string defaultClassroom) : base(scheduleType + "-" + FILE_NAME)
        {
            Schedule = Schedule.CreateSchedule(scheduleType);
            Load(defaultClassroom);
        }

        public ScheduleSaver(Setting setting) : base(setting.ScheduleType + "-" + FILE_NAME)
        {
            string scheduleType = setting.ScheduleType;
            string defaultClassroom = setting.DefaultClassroom;

            Schedule = Schedule.CreateSchedule(scheduleType);
            Load(defaultClassroom);
        }

        public void Load(string defaultClassroom)
        {
            string[] lines = fileManager.Read();

            int dayOfWeek = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Substring(0, 2) == "//")
                    continue;
                string[] codes = lines[i].Split(';');
                if (codes.Length != Schedule.StartTime.Length + 1)
                    throw new FormatException("Length of class is not correct");
                for (int classNo = 0; classNo < Schedule.StartTime.Length; classNo++)
                    Schedule.SetCode(dayOfWeek, classNo, codes[classNo]);
                dayOfWeek++;
            }
            if (dayOfWeek == 0)
            {
                Schedule.SetDefault(defaultClassroom);
                Save();
            }
            else if (dayOfWeek != Schedule.DayOfWeekCode.Length)
                throw new FormatException("Length of day of week is not correct");
        }

        protected override void Save(TextWriter writer)
        {
            for (int dayOfWeek = 0; dayOfWeek < 5; dayOfWeek++)
            {
                string line = "";
                for (int classNo = 0; classNo < Schedule.StartTime.Length; classNo++)
                    line += Schedule.Code[dayOfWeek, classNo] + ";";

                writer.WriteLine(line);
            }
        }
    }
}
