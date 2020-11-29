using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MeetMacro;

namespace WindowsMeetMacro
{
    public partial class SettingForm : Form
    {
        private readonly SettingSaver settingSaver = SettingSaver.Instance;
        private Setting setting;
        public SettingForm()
        {
            InitializeComponent();

            setting = settingSaver.Setting;

            elementLoadTimeout.Value = setting.ElementLoadTimeout;
            viewLog.Checked = setting.ViewLog;
            classroom.Text = setting.DefaultClassroom;
            
            scheduleType.Items.AddRange(Schedule.Type);
            scheduleType.Text = setting.ScheduleType;
            startOffset.Value = setting.StartTimeOffset;
            endOffset.Value = setting.EndTimeOffset;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            setting.ElementLoadTimeout = (int)elementLoadTimeout.Value;
            setting.ViewLog = viewLog.Checked;
            setting.DefaultClassroom = classroom.Text;
            setting.ScheduleType = scheduleType.Text;
            setting.StartTimeOffset = (int)startOffset.Value;
            setting.EndTimeOffset = (int)endOffset.Value;

            settingSaver.Save();
            MessageBox.Show("저장했음 - 실행 중인 매크로에 적용되지 않음", "저장");
        }

        private void openSaveDirButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", FileManager.DirectoryPath);
        }

        private void openNotePadButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", settingSaver.FilePath);
        }
    }
}
