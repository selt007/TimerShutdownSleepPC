namespace TimerSleepDownPC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem8 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem9 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem10 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem11 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem12 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem13 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonStart = new Telerik.WinControls.UI.RadButton();
            this.WaitBar = new Telerik.WinControls.UI.RadWaitingBar();
            this.dotsRingWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.DotsRingWaitingBarIndicatorElement();
            this.switchSelectTime = new Telerik.WinControls.UI.RadToggleSwitch();
            this.radioSleep = new Telerik.WinControls.UI.RadRadioButton();
            this.groupSelectAction = new Telerik.WinControls.UI.RadGroupBox();
            this.radioDownUp = new Telerik.WinControls.UI.RadRadioButton();
            this.labelSelectTime = new Telerik.WinControls.UI.RadLabel();
            this.listSelectTime = new Telerik.WinControls.UI.RadListControl();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.panelSetTime = new Telerik.WinControls.UI.RadPanel();
            this.labelSetTime = new Telerik.WinControls.UI.RadLabel();
            this.textBoxSetTime = new Telerik.WinControls.UI.RadTextBox();
            this.buttonCancel = new Telerik.WinControls.UI.RadButton();
            this.labelInfo = new Telerik.WinControls.UI.RadLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new Telerik.WinControls.UI.RadLabel();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchSelectTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectAction)).BeginInit();
            this.groupSelectAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioDownUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSelectTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSelectTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSetTime)).BeginInit();
            this.panelSetTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelSetTime)).BeginInit();
            this.labelSetTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSetTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonStart.Location = new System.Drawing.Point(12, 222);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(180, 36);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Поставить таймер";
            this.buttonStart.ThemeName = "MaterialTeal";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // WaitBar
            // 
            this.WaitBar.Location = new System.Drawing.Point(307, 122);
            this.WaitBar.Name = "WaitBar";
            this.WaitBar.Size = new System.Drawing.Size(47, 46);
            this.WaitBar.TabIndex = 1;
            this.WaitBar.Text = "radWaitingBar1";
            this.WaitBar.Visible = false;
            this.WaitBar.WaitingIndicators.Add(this.dotsRingWaitingBarIndicatorElement1);
            this.WaitBar.WaitingSpeed = 50;
            this.WaitBar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsRing;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.WaitBar.GetChildAt(0))).WaitingSpeed = 50;
            ((Telerik.WinControls.UI.WaitingBarContentElement)(this.WaitBar.GetChildAt(0).GetChildAt(0))).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsRing;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.WaitBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Dash = false;
            // 
            // dotsRingWaitingBarIndicatorElement1
            // 
            this.dotsRingWaitingBarIndicatorElement1.Name = "dotsRingWaitingBarIndicatorElement1";
            // 
            // switchSelectTime
            // 
            this.switchSelectTime.Location = new System.Drawing.Point(12, 95);
            this.switchSelectTime.Name = "switchSelectTime";
            this.switchSelectTime.Size = new System.Drawing.Size(37, 21);
            this.switchSelectTime.TabIndex = 2;
            this.switchSelectTime.ThemeName = "MaterialTeal";
            this.switchSelectTime.Value = false;
            this.switchSelectTime.AnimationStarted += new Telerik.WinControls.AnimationStartedEventHandler(this.switchSelectTime_AnimationStarted);
            // 
            // radioSleep
            // 
            this.radioSleep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radioSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioSleep.Location = new System.Drawing.Point(15, 5);
            this.radioSleep.Name = "radioSleep";
            this.radioSleep.Size = new System.Drawing.Size(215, 20);
            this.radioSleep.TabIndex = 4;
            this.radioSleep.Text = "Перевести ПК в режим сна";
            this.radioSleep.ThemeName = "TelerikMetro";
            this.radioSleep.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radioSleep.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioSleep_ToggleStateChanged);
            // 
            // groupSelectAction
            // 
            this.groupSelectAction.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupSelectAction.Controls.Add(this.radioDownUp);
            this.groupSelectAction.Controls.Add(this.radioSleep);
            this.groupSelectAction.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupSelectAction.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.groupSelectAction.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Bottom;
            this.groupSelectAction.HeaderText = "Выберите действие";
            this.groupSelectAction.Location = new System.Drawing.Point(12, 12);
            this.groupSelectAction.Name = "groupSelectAction";
            this.groupSelectAction.Size = new System.Drawing.Size(352, 77);
            this.groupSelectAction.TabIndex = 5;
            this.groupSelectAction.Text = "Выберите действие";
            this.groupSelectAction.ThemeName = "TelerikMetro";
            // 
            // radioDownUp
            // 
            this.radioDownUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioDownUp.Location = new System.Drawing.Point(15, 28);
            this.radioDownUp.Name = "radioDownUp";
            this.radioDownUp.Size = new System.Drawing.Size(185, 20);
            this.radioDownUp.TabIndex = 5;
            this.radioDownUp.TabStop = false;
            this.radioDownUp.Text = "Выключить компьютер";
            this.radioDownUp.ThemeName = "TelerikMetro";
            this.radioDownUp.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioDownUp_ToggleStateChanged);
            // 
            // labelSelectTime
            // 
            this.labelSelectTime.Location = new System.Drawing.Point(55, 97);
            this.labelSelectTime.Name = "labelSelectTime";
            this.labelSelectTime.Size = new System.Drawing.Size(192, 21);
            this.labelSelectTime.TabIndex = 6;
            this.labelSelectTime.Text = "Определить время самому";
            this.labelSelectTime.ThemeName = "MaterialTeal";
            // 
            // listSelectTime
            // 
            radListDataItem1.Text = "1 секунду";
            radListDataItem2.Text = "5 минут";
            radListDataItem3.Text = "10 минут";
            radListDataItem4.Text = "15 минут";
            radListDataItem5.Text = "30 минут";
            radListDataItem6.Text = "45 минут";
            radListDataItem7.Text = "1 час";
            radListDataItem8.Text = "1 час и 30 мин";
            radListDataItem9.Text = "2 часа";
            radListDataItem10.Text = "4 часа";
            radListDataItem11.Text = "8 часов";
            radListDataItem12.Text = "12 часов";
            radListDataItem13.Text = "1 день";
            this.listSelectTime.Items.Add(radListDataItem1);
            this.listSelectTime.Items.Add(radListDataItem2);
            this.listSelectTime.Items.Add(radListDataItem3);
            this.listSelectTime.Items.Add(radListDataItem4);
            this.listSelectTime.Items.Add(radListDataItem5);
            this.listSelectTime.Items.Add(radListDataItem6);
            this.listSelectTime.Items.Add(radListDataItem7);
            this.listSelectTime.Items.Add(radListDataItem8);
            this.listSelectTime.Items.Add(radListDataItem9);
            this.listSelectTime.Items.Add(radListDataItem10);
            this.listSelectTime.Items.Add(radListDataItem11);
            this.listSelectTime.Items.Add(radListDataItem12);
            this.listSelectTime.Items.Add(radListDataItem13);
            this.listSelectTime.Location = new System.Drawing.Point(13, 122);
            this.listSelectTime.Name = "listSelectTime";
            this.listSelectTime.Size = new System.Drawing.Size(179, 94);
            this.listSelectTime.TabIndex = 7;
            this.listSelectTime.ThemeName = "TelerikMetro";
            this.listSelectTime.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.listSelectTime_SelectedIndexChanged);
            // 
            // panelSetTime
            // 
            this.panelSetTime.AccessibleName = "panelSameTime";
            this.panelSetTime.Controls.Add(this.labelSetTime);
            this.panelSetTime.Location = new System.Drawing.Point(13, 122);
            this.panelSetTime.Name = "panelSetTime";
            this.panelSetTime.Size = new System.Drawing.Size(179, 94);
            this.panelSetTime.TabIndex = 0;
            this.panelSetTime.Visible = false;
            // 
            // labelSetTime
            // 
            this.labelSetTime.Controls.Add(this.textBoxSetTime);
            this.labelSetTime.Location = new System.Drawing.Point(3, 3);
            this.labelSetTime.Name = "labelSetTime";
            this.labelSetTime.Size = new System.Drawing.Size(179, 71);
            this.labelSetTime.TabIndex = 0;
            this.labelSetTime.Text = "Укажите время:\r\n\r\n\r\n                          (в минутах)";
            this.labelSetTime.ThemeName = "MaterialTeal";
            // 
            // textBoxSetTime
            // 
            this.textBoxSetTime.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxSetTime.Location = new System.Drawing.Point(3, 23);
            this.textBoxSetTime.MaxLength = 6;
            this.textBoxSetTime.Name = "textBoxSetTime";
            this.textBoxSetTime.Size = new System.Drawing.Size(168, 24);
            this.textBoxSetTime.TabIndex = 0;
            this.textBoxSetTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSetTime.ThemeName = "TelerikMetro";
            this.textBoxSetTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSetTime_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.Location = new System.Drawing.Point(198, 222);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(166, 36);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отменить таймер";
            this.buttonCancel.ThemeName = "MaterialTeal";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(201, 128);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(72, 21);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "radLabel1";
            this.labelInfo.ThemeName = "MaterialTeal";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Unispace", 10F);
            this.labelTimer.Location = new System.Drawing.Point(198, 193);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(49, 20);
            this.labelTimer.TabIndex = 9;
            this.labelTimer.Text = "lamel";
            this.labelTimer.ThemeName = "VisualStudio2012Dark";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Timer for PC";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(376, 270);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelSetTime);
            this.Controls.Add(this.listSelectTime);
            this.Controls.Add(this.labelSelectTime);
            this.Controls.Add(this.groupSelectAction);
            this.Controls.Add(this.switchSelectTime);
            this.Controls.Add(this.WaitBar);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer DownUp/Sleep";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchSelectTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectAction)).EndInit();
            this.groupSelectAction.ResumeLayout(false);
            this.groupSelectAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioDownUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSelectTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSelectTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSetTime)).EndInit();
            this.panelSetTime.ResumeLayout(false);
            this.panelSetTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelSetTime)).EndInit();
            this.labelSetTime.ResumeLayout(false);
            this.labelSetTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSetTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton buttonStart;
        private Telerik.WinControls.UI.RadWaitingBar WaitBar;
        private Telerik.WinControls.UI.DotsRingWaitingBarIndicatorElement dotsRingWaitingBarIndicatorElement1;
        private Telerik.WinControls.UI.RadToggleSwitch switchSelectTime;
        private Telerik.WinControls.UI.RadRadioButton radioSleep;
        private Telerik.WinControls.UI.RadGroupBox groupSelectAction;
        private Telerik.WinControls.UI.RadRadioButton radioDownUp;
        private Telerik.WinControls.UI.RadLabel labelSelectTime;
        private Telerik.WinControls.UI.RadListControl listSelectTime;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadPanel panelSetTime;
        private Telerik.WinControls.UI.RadLabel labelSetTime;
        private Telerik.WinControls.UI.RadButton buttonCancel;
        private Telerik.WinControls.UI.RadLabel labelInfo;
        private System.Windows.Forms.Timer timer;
        private Telerik.WinControls.UI.RadLabel labelTimer;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Telerik.WinControls.UI.RadTextBox textBoxSetTime;
    }
}