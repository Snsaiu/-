namespace programmingQuickSetup
{
    partial class SwitchWindow
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
            this.lbViewTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRamBar = new System.Windows.Forms.Button();
            this.RAMViewBarTimer = new System.Windows.Forms.Timer(this.components);
            this.timerRemind = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.T2 = new System.Windows.Forms.Timer(this.components);
            this.T3 = new System.Windows.Forms.Timer(this.components);
            this.T4 = new System.Windows.Forms.Timer(this.components);
            this.T5 = new System.Windows.Forms.Timer(this.components);
            this.T6 = new System.Windows.Forms.Timer(this.components);
            this.tAppRun = new System.Windows.Forms.Timer(this.components);
            this.btnAppWarn = new System.Windows.Forms.Button();
            this.timeWinDrop = new System.Windows.Forms.Timer(this.components);
            this.TimerClearRam = new System.Windows.Forms.Timer(this.components);
            this.BtnMove = new System.Windows.Forms.Button();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.btnOpenManwindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ttDec = new System.Windows.Forms.ToolTip(this.components);
            this.labCPUTem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbViewTimer
            // 
            this.lbViewTimer.AutoSize = true;
            this.lbViewTimer.BackColor = System.Drawing.SystemColors.Control;
            this.lbViewTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbViewTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbViewTimer.Location = new System.Drawing.Point(88, 6);
            this.lbViewTimer.Name = "lbViewTimer";
            this.lbViewTimer.Size = new System.Drawing.Size(35, 15);
            this.lbViewTimer.TabIndex = 4;
            this.lbViewTimer.Text = "None";
            this.lbViewTimer.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRamBar
            // 
            this.btnRamBar.BackColor = System.Drawing.Color.Lime;
            this.btnRamBar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRamBar.FlatAppearance.BorderSize = 0;
            this.btnRamBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRamBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRamBar.Location = new System.Drawing.Point(88, 27);
            this.btnRamBar.Name = "btnRamBar";
            this.btnRamBar.Size = new System.Drawing.Size(28, 15);
            this.btnRamBar.TabIndex = 5;
            this.btnRamBar.Text = "bu";
            this.btnRamBar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ttDec.SetToolTip(this.btnRamBar, "显示您设备当前已用内存，点击可进行内存优化！");
            this.btnRamBar.UseVisualStyleBackColor = false;
            this.btnRamBar.Click += new System.EventHandler(this.btnRamBar_Click);
            // 
            // RAMViewBarTimer
            // 
            this.RAMViewBarTimer.Enabled = true;
            this.RAMViewBarTimer.Interval = 1000;
            this.RAMViewBarTimer.Tick += new System.EventHandler(this.RAMViewBarTimer_Tick);
            // 
            // timerRemind
            // 
            this.timerRemind.Enabled = true;
            this.timerRemind.Interval = 1000;
            this.timerRemind.Tick += new System.EventHandler(this.timerRemind_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(181, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.ttDec.SetToolTip(this.btnClose, "左键点击关闭应用");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // T1
            // 
            this.T1.Interval = 60000;
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // T2
            // 
            this.T2.Interval = 60000;
            this.T2.Tick += new System.EventHandler(this.T2_Tick);
            // 
            // T3
            // 
            this.T3.Interval = 60000;
            this.T3.Tick += new System.EventHandler(this.T3_Tick);
            // 
            // T4
            // 
            this.T4.Interval = 60000;
            this.T4.Tick += new System.EventHandler(this.T4_Tick);
            // 
            // T5
            // 
            this.T5.Interval = 60000;
            this.T5.Tick += new System.EventHandler(this.T5_Tick);
            // 
            // T6
            // 
            this.T6.Interval = 60000;
            this.T6.Tick += new System.EventHandler(this.T6_Tick);
            // 
            // tAppRun
            // 
            this.tAppRun.Enabled = true;
            this.tAppRun.Interval = 1000;
            this.tAppRun.Tick += new System.EventHandler(this.tAppRun_Tick);
            // 
            // btnAppWarn
            // 
            this.btnAppWarn.Location = new System.Drawing.Point(3, 44);
            this.btnAppWarn.Name = "btnAppWarn";
            this.btnAppWarn.Size = new System.Drawing.Size(202, 23);
            this.btnAppWarn.TabIndex = 10;
            this.btnAppWarn.Text = "button1";
            this.btnAppWarn.UseVisualStyleBackColor = true;
            // 
            // timeWinDrop
            // 
            this.timeWinDrop.Tick += new System.EventHandler(this.timeWinDrop_Tick);
            // 
            // TimerClearRam
            // 
            this.TimerClearRam.Enabled = true;
            this.TimerClearRam.Interval = 10000;
            this.TimerClearRam.Tick += new System.EventHandler(this.TimerClearRam_Tick);
            // 
            // BtnMove
            // 
            this.BtnMove.BackgroundImage = global::programmingQuickSetup.Properties.Resources.arrow_move_16px_1189136_easyicon_net;
            this.BtnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMove.Location = new System.Drawing.Point(54, 21);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(33, 22);
            this.BtnMove.TabIndex = 9;
            this.ttDec.SetToolTip(this.BtnMove, "左键点击并拖动以移动窗体位置");
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMove_MouseDown);
            this.BtnMove.MouseLeave += new System.EventHandler(this.BtnMove_MouseLeave);
            this.BtnMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnMove_MouseMove);
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetTimer.BackgroundImage = global::programmingQuickSetup.Properties.Resources.Timer;
            this.btnSetTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSetTimer.Location = new System.Drawing.Point(54, 0);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(33, 25);
            this.btnSetTimer.TabIndex = 3;
            this.ttDec.SetToolTip(this.btnSetTimer, "左键点击打开被动定时器，注意：此功能已不实用！且会影响主动定时器！不建议使用！");
            this.btnSetTimer.UseVisualStyleBackColor = false;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // btnOpenManwindow
            // 
            this.btnOpenManwindow.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenManwindow.BackgroundImage = global::programmingQuickSetup.Properties.Resources.Home;
            this.btnOpenManwindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenManwindow.Location = new System.Drawing.Point(3, 0);
            this.btnOpenManwindow.Name = "btnOpenManwindow";
            this.btnOpenManwindow.Size = new System.Drawing.Size(52, 43);
            this.btnOpenManwindow.TabIndex = 0;
            this.btnOpenManwindow.UseVisualStyleBackColor = false;
            this.btnOpenManwindow.Click += new System.EventHandler(this.btnOpenManwindow_Click);
            this.btnOpenManwindow.MouseHover += new System.EventHandler(this.btnOpenManwindow_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(134, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "FANTASY WORLD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ttDec
            // 
            this.ttDec.ShowAlways = true;
            this.ttDec.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttDec.ToolTipTitle = "SmartTool使用说明";
            // 
            // labCPUTem
            // 
            this.labCPUTem.AutoSize = true;
            this.labCPUTem.Location = new System.Drawing.Point(122, 26);
            this.labCPUTem.Name = "labCPUTem";
            this.labCPUTem.Size = new System.Drawing.Size(35, 13);
            this.labCPUTem.TabIndex = 12;
            this.labCPUTem.Text = "label2";
            this.labCPUTem.Visible = false;
            // 
            // SwitchWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::programmingQuickSetup.Properties.Resources.SwitchBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(206, 45);
            this.ControlBox = false;
            this.Controls.Add(this.labCPUTem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAppWarn);
            this.Controls.Add(this.BtnMove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRamBar);
            this.Controls.Add(this.lbViewTimer);
            this.Controls.Add(this.btnSetTimer);
            this.Controls.Add(this.btnOpenManwindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SwitchWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SwitchWindow";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.SwitchWindow_Load);
            this.MouseEnter += new System.EventHandler(this.SwitchWindow_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SwitchWindow_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenManwindow;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.Label lbViewTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRamBar;
        private System.Windows.Forms.Timer RAMViewBarTimer;
        private System.Windows.Forms.Timer timerRemind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnMove;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.Timer T2;
        private System.Windows.Forms.Timer T3;
        private System.Windows.Forms.Timer T4;
        private System.Windows.Forms.Timer T5;
        private System.Windows.Forms.Timer T6;
        private System.Windows.Forms.Timer tAppRun;
        private System.Windows.Forms.Button btnAppWarn;
        private System.Windows.Forms.Timer timeWinDrop;
        private System.Windows.Forms.Timer TimerClearRam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttDec;
        private System.Windows.Forms.Label labCPUTem;
    }
}