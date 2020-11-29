using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MeetMacro
{
    public class SettingSaver : Saver
    {
        private static SettingSaver _instance = null;

        public static SettingSaver Instance
        {
            private set => _instance = value;
            get => _instance ?? new SettingSaver();
        }

        private static readonly string FILE_NAME = "settings.conf";

        public Setting Setting { private set; get; }

        private SettingSaver() : base(FILE_NAME)
        {
            Setting = Setting.Default;
            Load();
        }

        public void Load()
        {
            string[] lines = fileManager.Read();

            foreach (string line in lines)
            {
                string[] str = line.Split(':');
                if (str.Length != 2)
                    throw new FormatException("Wrong Format");
                Setting[str[0]] = str[1];
            }
        }

        protected override void Save(TextWriter writer)
        {
            foreach (var key in Setting.Keys)
            {
                string line = key + ":" + Setting[key];
                writer.WriteLine(line);
            }
        }
    }
}
