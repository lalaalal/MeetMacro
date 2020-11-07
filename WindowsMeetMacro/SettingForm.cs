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
        private readonly SettingSaver settingSaver;

        public SettingForm()
        {
            InitializeComponent();
            settingSaver = SettingSaver.Instance;

            elementLoadTimeout.Text = settingSaver.Setting[Setting.Attributes.ELEMENT_LOAD_TIMEOUT];
            viewLog.Checked = settingSaver.Setting[Setting.Attributes.VIEW_LOG] == "true";
            classroom.Text = settingSaver.Setting[Setting.Attributes.CLASSROOM];
            scheduleType.Text = settingSaver.Setting[Setting.Attributes.SCHEDULE_TYPE];
            startOffset.Text = settingSaver.Setting[Setting.Attributes.START_TIME_OFFSET];
            endOffset.Text = settingSaver.Setting[Setting.Attributes.END_TIME_OFFSET];
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            settingSaver.Setting[Setting.Attributes.ELEMENT_LOAD_TIMEOUT] = elementLoadTimeout.Text;
            settingSaver.Setting[Setting.Attributes.VIEW_LOG] = viewLog.Checked == true ? "true" : "false";
            settingSaver.Setting[Setting.Attributes.CLASSROOM] = classroom.Text;
            settingSaver.Setting[Setting.Attributes.SCHEDULE_TYPE] = scheduleType.Text;
            settingSaver.Setting[Setting.Attributes.START_TIME_OFFSET] = startOffset.Text;
            settingSaver.Setting[Setting.Attributes.END_TIME_OFFSET] = endOffset.Text;

            settingSaver.Save();
            MessageBox.Show("저장했음 - 실행 중인 매크로에 적용되지 않음", "저장");
        }
    }
}
