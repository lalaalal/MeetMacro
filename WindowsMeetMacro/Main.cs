using System;
using System.Threading;
using System.Windows.Forms;

using MeetMacro;

namespace WindowsMeetMacro
{
    public partial class Main : Form
    {
        public delegate void CrossThreadSafetyEnableLogin();

        private readonly AccountSaver accountSaver = new AccountSaver();

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
                SettingSaver settingSaver = SettingSaver.Instance;
                if (settingSaver.Setting[Setting.Attributes.VIEW_LOG] == "true")
                    logView.Show();

                string scheduleType = settingSaver.Setting[Setting.Attributes.SCHEDULE_TYPE];
                string classroom = settingSaver.Setting[Setting.Attributes.CLASSROOM];
                int timeout = int.Parse(settingSaver.Setting[Setting.Attributes.ELEMENT_LOAD_TIMEOUT]);
                int startOffset = int.Parse(settingSaver.Setting[Setting.Attributes.START_TIME_OFFSET]);
                int endOffset = int.Parse(settingSaver.Setting[Setting.Attributes.END_TIME_OFFSET]);

                Thread thread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        ScheduleSaver scheduleSaver = new ScheduleSaver(settingSaver.Setting);

                        using Macro macro = new Macro(scheduleSaver.Schedule, timeout, logView.Logger, startOffset, endOffset);
                        macro.Run(id, pw);
                    } catch(Exception e)
                    {
                        logView.Logger.AddLog(e.Message);
                    } finally
                    {
                        EnableLogin();
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
            if (idTextBox.InvokeRequired)
            {
                idTextBox.Invoke(new CrossThreadSafetyEnableLogin(EnableLogin));
                pwTextBox.Invoke(new CrossThreadSafetyEnableLogin(EnableLogin));
                loginButton.Invoke(new CrossThreadSafetyEnableLogin(EnableLogin));
            } 
            else
            {
                idTextBox.Enabled = true;
                pwTextBox.Enabled = true;
                loginButton.Enabled = true;
            }
        }

        private void settingLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }
    }
}
