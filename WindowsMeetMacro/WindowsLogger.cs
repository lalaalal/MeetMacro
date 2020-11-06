using MeetMacro;

namespace WindowsMeetMacro
{
    public class WindowsLogger : Logger
    {
        private readonly LogView.CrossThreadSafetySetText CSafetyAddText;

        public WindowsLogger(LogView.CrossThreadSafetySetText CSafetyAddText)
            => this.CSafetyAddText = CSafetyAddText;

        public override void Log(string log)
            => CSafetyAddText(log + "\n");
    }
}
