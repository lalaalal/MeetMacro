using System;
using System.Windows.Forms;

namespace WindowsMeetMacro
{
    public partial class LogView : Form
    {
        public WindowsLogger Logger { private set; get; }

        public delegate void CrossThreadSafetySetText(string text);

        public void CSafeAddText(string text)
        {
            if (logRichTextBox.InvokeRequired)
                logRichTextBox.Invoke(new CrossThreadSafetySetText(CSafeAddText), text);
            else
            {
                logRichTextBox.Text += text;
                logRichTextBox.SelectionStart = logRichTextBox.Text.Length;
                logRichTextBox.ScrollToCaret();
            }
                
        }

        public LogView()
        {
            InitializeComponent();
            Logger = new WindowsLogger(CSafeAddText);
        }

        private void LogView_Load(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Logger.Save();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", Logger.FilePath);
        }
    }
}
