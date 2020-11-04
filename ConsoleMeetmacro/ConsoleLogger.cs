using System;
using System.Collections.Generic;
using System.Text;

using MeetMacro;

namespace ConsoleMeetMacro
{
    public class ConsoleLogger : Logger
    {
        public override void Log(string log) 
            => Console.WriteLine(log);
    }
}
