﻿using System;
using System.Windows.Forms;

using MeetMacro;

namespace WindowsMeetMacro
{
    public partial class ScheduleEditor : Form
    {
        private SettingSaver settingSaver;
        private ScheduleSaver scheduleSaver;
        private TextBox[,] textBoxes = new TextBox[5, 7];

        public ScheduleEditor()
        {
            settingSaver = SettingSaver.Instance;

            string scheduleType = settingSaver.Setting[Setting.Attributes.SCHEDULE_TYPE];
            string classroom = settingSaver.Setting[Setting.Attributes.CLASSROOM];
            try
            {
                scheduleSaver = new ScheduleSaver(scheduleType, classroom);
            } catch (FormatException e)
            {
                MessageBox.Show(e.Message, "저런..");
                scheduleSaver.Schedule.SetDefault(classroom);
            }
            
            InitializeComponent();
            for (int dayOfWeek = 0; dayOfWeek < 5; dayOfWeek++)
            {
                for (int classNo = 1; classNo < 8; classNo++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = scheduleSaver.Schedule.Code[dayOfWeek, classNo];
                    textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                    textBoxes[dayOfWeek, classNo - 1] = textBox;
                    scheduleTable.Controls.Add(textBox, dayOfWeek + 1, classNo);
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", scheduleSaver.FilePath);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            for (int dayOfWeek = 0; dayOfWeek < 5; dayOfWeek++)
            {
                for (int classNo = 1; classNo < 8; classNo++)
                {
                    var textBox = textBoxes[dayOfWeek, classNo - 1];
                    scheduleSaver.Schedule.SetCode(dayOfWeek, classNo, textBox.Text);
                }
            }

            scheduleSaver.Save();
            MessageBox.Show("저장했음! - 실행 중인 매크로에 적용되지 않음", "저장");
        }

        private void ScheduleEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
