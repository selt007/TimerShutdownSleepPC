using System;
using System.Windows.Forms;

namespace TimerSleepDownPC
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        string actionLog, time, action;
        bool start = false;

        public MainForm()
        {
            InitializeComponent();
            listSelectTime.SelectedIndex = 0;
            labelTimer.Text = string.Empty;
            buttonCancel.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!start) Start();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (start) Stop();
        }

        private void radioDownUp_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args) =>
            WriteLog(listSelectTime.SelectedItem.ToString());

        private void textBoxSetTime_TextChanged(object sender, EventArgs e) =>
            WriteLog(textBoxSetTime.Text + " мин");

        private void radioSleep_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args) =>
            WriteLog(listSelectTime.SelectedItem.ToString());

        private void listSelectTime_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e) =>
            WriteLog(listSelectTime.SelectedItem.ToString());
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (start)
            {
                DialogResult result = MessageBox.Show(
                "После закрытия приложения таймер сбросится" +
                " и программа не выполнит заданное вами действие." +
                "\n\nВы уверенны что хотити выйти из программы?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
                if (result == DialogResult.No) e.Cancel = true;
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void textBoxSetTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void switchSelectTime_AnimationStarted(object sender, Telerik.WinControls.AnimationStatusEventArgs e)
        {
            if (switchSelectTime.Value) panelSetTime.Visible = true;
            if (!switchSelectTime.Value) panelSetTime.Visible = false;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        void WriteLog(string t)
        {
            if (radioDownUp.IsChecked) actionLog = "выключится";
            else actionLog = "уйдет в режим сна";
            labelInfo.Text = $"После нажатия на \n" +
                $"зеленую кнопку ПК\n" +
                $"{actionLog}\n" +
                $"через {t}.";
        }
    }
}
