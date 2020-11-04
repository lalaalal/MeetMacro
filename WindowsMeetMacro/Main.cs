using System;
using System.Threading;
using System.Windows.Forms;

using MeetMacro;

namespace WindowsMeetMacro
{
    public partial class Main : Form
    {
        private AccountSaver accountSaver = new AccountSaver();

        public Main()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            idTextBox.Text = accountSaver.Id;
            pwTextBox.Text = accountSaver.Pw;
        }

        private void configSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScheduleEditor scheduleEditor = new ScheduleEditor();
            scheduleEditor.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string pw = pwTextBox.Text;

            if (id == "" || pw == "")
                warningLabel.Text = "모두 채워 주세요";
            else
            {
                DisableLogin();
                accountSaver.SetAccount(id, pw);
                accountSaver.Save();

                LogView logView = new LogView();
                SettingSaver settingSaver = new SettingSaver();
                if (settingSaver.Setting[Setting.Attributes.VIEW_LOG] == "true")
                    logView.Show();

                string scheduleType = settingSaver.Setting[Setting.Attributes.SCHEDULE_TYPE];
                string classroom = settingSaver.Setting[Setting.Attributes.CLASSROOM];
                int timeout = int.Parse(settingSaver.Setting[Setting.Attributes.ELEMENT_LOAD_TIMEOUT]);

                Thread thread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        ScheduleSaver scheduleSaver = new ScheduleSaver(scheduleType, classroom);

                        logView.Logger.AddLog("Start!");
                        using Macro macro = new Macro(scheduleSaver.schedule, timeout, logView.Logger);
                        macro.Run(id, pw);
                    } catch(Exception e)
                    {
                        logView.Logger.AddLog(e.Message);
                    } finally
                    {
                        EnableLogin();
                        logView.Logger.AddLog("End");
                    }
                    
                }));
                thread.Start();

                FormClosing += new FormClosingEventHandler((sender, e) => thread?.Interrupt());
            }
            
        }

        private void DisableLogin()
        {
            idTextBox.Enabled = false;
            pwTextBox.Enabled = false;
            loginButton.Enabled = false;
        }

        private void EnableLogin()
        {
            idTextBox.Enabled = true;
            pwTextBox.Enabled = true;
            loginButton.Enabled = true;
        }

        private void settingLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }
    }
}
