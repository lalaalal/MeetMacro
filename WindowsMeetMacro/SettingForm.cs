﻿using System;
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
        private SettingSaver settingSaver;

        public SettingForm()
        {
            InitializeComponent();
            settingSaver = new SettingSaver();

            elementLoadTimeout.Text = settingSaver.Setting[Setting.Attributes.ELEMENT_LOAD_TIMEOUT];
            viewLog.Checked = settingSaver.Setting[Setting.Attributes.VIEW_LOG] == "true";
            classroom.Text = settingSaver.Setting[Setting.Attributes.CLASSROOM];
            scheduleType.Text = settingSaver.Setting[Setting.Attributes.SCHEDULE_TYPE];
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

            settingSaver.Save();
            MessageBox.Show("저장했음", "저장");
        }
    }
}