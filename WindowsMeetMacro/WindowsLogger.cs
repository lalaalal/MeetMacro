using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using MeetMacro;

namespace WindowsMeetMacro
{
    public class WindowsLogger : Logger
    {
        private RichTextBox textBox;

        public WindowsLogger(RichTextBox textBox)
        {
            this.textBox = textBox;
        }

        public override void Log(string log)
        {
            textBox.Text += log + "\n";
        }
    }
}
