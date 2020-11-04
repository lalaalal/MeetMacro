using System;
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
            settingSaver = new SettingSaver();

            string scheduleType = settingSaver.Setting[Setting.Attributes.SCHEDULE_TYPE];
            string classroom = settingSaver.Setting[Setting.Attributes.CLASSROOM];
            try
            {
                scheduleSaver = new ScheduleSaver(scheduleType, classroom);
            } catch (FormatException e)
            {
                MessageBox.Show(e.Message, "저런..");
            }
            
            InitializeComponent();
            for (int dayOfWeek = 0; dayOfWeek < 5; dayOfWeek++)
            {
                for (int classNo = 1; classNo < 8; classNo++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = scheduleSaver.schedule.Code[dayOfWeek, classNo];
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
                    scheduleSaver.schedule.SetCode(dayOfWeek, classNo, textBox.Text);
                }
            }

            scheduleSaver.Save();
            MessageBox.Show("저장했음!", "저장");
        }

        private void ScheduleEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
