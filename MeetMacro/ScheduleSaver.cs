using System;
using System.IO;

namespace MeetMacro
{
    public class ScheduleSaver
    {
        public static readonly string FILE_NAME = "schedule.txt";

        private FileManager fileManager;
        public Schedule schedule { private set; get; }

        public ScheduleSaver(string scheduleType, string defaultClassroom)
        {
            fileManager = new FileManager(scheduleType + "-" + FILE_NAME);
            schedule = Schedule.CreateSchedule(scheduleType);
            try
            {
                Load();
            }
            catch (FormatException)
            {
                schedule.SetDefault(defaultClassroom);
            }
        }

        public void Load()
        {
            string[] lines = fileManager.Read();

            int dayOfWeek = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Substring(0, 2) == "//")
                    continue;
                string[] codes = lines[i].Split(';');
                if (codes.Length != 9)
                    throw new FormatException("Length of class is not correct");
                for (int classNo = 0; classNo < schedule.StartTime.Length; classNo++)
                    schedule.SetCode(dayOfWeek++, classNo, codes[classNo]);
            }
            if (dayOfWeek != 4)
                throw new FormatException("Length of day of week is not correct");
        }

        public void Save() => fileManager.Write(Save);

        private void Save(TextWriter writer)
        {
            for (int dayOfWeek = 0; dayOfWeek < 5; dayOfWeek++)
            {
                string line = "";
                for (int classNo = 0; classNo < schedule.StartTime.Length; classNo++)
                    line += schedule.Code[dayOfWeek, classNo];

                writer.WriteLine(line);
            }
        }
    }
}
