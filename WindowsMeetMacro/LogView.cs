using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsMeetMacro
{
    public partial class LogView : Form
    {
        public WindowsLogger Logger { private set; get; }

        public LogView()
        {
            InitializeComponent();
            Logger = new WindowsLogger(logRichTextBox);
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
