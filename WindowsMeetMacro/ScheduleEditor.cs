using System;
using System.Windows.Forms;

using MeetMacro;

namespace WindowsMeetMacro
{
    public partial class ScheduleEditor : Form
    {
        private SettingSaver settingSaver;
        private ScheduleSaver scheduleSaver;
        private TextBox[,] textBoxes;

        public ScheduleEditor()
        {
            settingSaver = SettingSaver.Instance;

            string scheduleType = settingSaver.Setting.ScheduleType;
            string classroom = settingSaver.Setting.DefaultClassroom;
            try
            {
                scheduleSaver = new ScheduleSaver(scheduleType, classroom);
            } catch (FormatException e)
            {
                MessageBox.Show(e.Message, "저런..");
                scheduleSaver.Schedule.SetDefault(classroom);
            }
            Schedule schedule = scheduleSaver.Schedule;
            textBoxes = new TextBox[Schedule.DayOfWeekCode.Length, schedule.StartTime.Length];

            InitializeComponent();
            
            for (int classNo = 0; classNo < schedule.StartTime.Length; classNo++)
            {

                scheduleTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                Label classNoLabel = new Label
                {
                    Text = classNo + "교시",
                    Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                };

                scheduleTable.Controls.Add(classNoLabel, 0, classNo + 1);
                for (int dayOfWeek = 0; dayOfWeek < Schedule.DayOfWeekCode.Length; dayOfWeek++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = scheduleSaver.Schedule.Code[dayOfWeek, classNo];
                    textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                    textBoxes[dayOfWeek, classNo] = textBox;
                    scheduleTable.Controls.Add(textBox, dayOfWeek + 1, classNo + 1);
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
