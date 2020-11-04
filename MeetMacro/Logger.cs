using System;
using System.Collections.Generic;
using System.IO;

namespace MeetMacro
{
    public abstract class Logger : Saver
    {
        protected List<string> logs = new List<string>();
        private static readonly string FILE_NAME = "log.txt";

        public Logger() : base(FILE_NAME) { }

        public void AddLog(string log)
        {
            string timeStamp = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ");
            logs.Add(timeStamp + log);

            Log(timeStamp + log);
        }

        protected override void Save(TextWriter writer)
        {
            foreach (string log in logs)
                writer.WriteLine(log);
        }

        public abstract void Log(string log);
    }
}
