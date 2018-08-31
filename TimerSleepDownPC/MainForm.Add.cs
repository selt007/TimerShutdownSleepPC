using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TimerSleepDownPC
{
    partial class MainForm
    {
        ProcessStartInfo psi = new ProcessStartInfo();
        int timeLeft, h,m,s;

        void Start()
        {
            labelInfo.Text = "Таймер\n" +
                            "запущен ;)";
            WaitBar.Visible = true;
            WaitBar.StartWaiting();
            groupSelectAction.Enabled = false;
            panelSetTime.Enabled = false;
            listSelectTime.Enabled = false;
            switchSelectTime.Enabled = false;
            start = true;

            if (switchSelectTime.Value)
            {
                try
                {
                    int input = Convert.ToInt32(textBoxSetTime.Text),
                    sum = input * 60;
                    time = Convert.ToString(sum);
                }
                catch
                {
                    switchSelectTime.Value = false;
                }
            }
            else SetTime();
            timeLeft = Convert.ToInt32(time);
            timer.Start();
            buttonStart.Enabled = false;
            buttonCancel.Enabled = true;

            WindowState = FormWindowState.Minimized;
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = "Таймер запущен";
                notifyIcon.BalloonTipText = "Программа была спрятана в трей" +
                    " и продолжит свою работу.\n" +
                    $"Компьютер {actionLog} через {Convert.ToInt32(time) / 60} минут";
                notifyIcon.ShowBalloonTip(1500);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            h = timeLeft / 3600;
            m = (timeLeft / 60) - (h * 60);
            s = timeLeft  % 60;
            labelTimer.Text = "Отсчет: " +
                            $"{h}:{m}:{s}";

            if (timeLeft < 0)
            {
                timer.Stop();
                
                if (radioDownUp.IsChecked) action = "shutdown -s -t 00";
                if (radioSleep.IsChecked) action = "rundll32.exe powrprof.dll,SetSuspendState 0,1,0";

                string cmdStr = @"/c " + action;
                psi.FileName = "cmd";
                psi.Arguments = cmdStr;
                Process.Start(psi);
                Stop();
            }
        }

        void Stop()
        {
            labelInfo.Text = "Таймер\n" +
                "остановлен...";
            WaitBar.Visible = false;
            WaitBar.StopWaiting();
            groupSelectAction.Enabled = true;
            panelSetTime.Enabled = true;
            listSelectTime.Enabled = true;
            switchSelectTime.Enabled = true;
            start = false;
            timer.Stop();
            labelTimer.Text = string.Empty;
            buttonStart.Enabled = true;
            buttonCancel.Enabled = false;
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

		void SetTime()
        {
            switch (listSelectTime.SelectedItem.ToString())
            {
                case "1 секунду":
                    time = "01";
                    break;
                case "5 минут":
                    time = "300";
                    break;
                case "10 минут":
                    time = "600";
                    break;
                case "15 минут":
                    time = "900";
                    break;
                case "30 минут":
                    time = "1800";
                    break;
                case "45 минут":
                    time = "2700";
                    break;
                case "1 час":
                    time = "3600";
                    break;
                case "1 час и 30 мин":
                    time = "5400";
                    break;
                case "2 часа":
                    time = "7200";
                    break;
                case "4 часа":
                    time = "14400";
                    break;
                case "8 часов":
                    time = "28800";
                    break;
                case "12 часов":
                    time = "43200";
                    break;
                case "1 день":
                    time = "86400";
                    break;
            }
        }
    }
}
