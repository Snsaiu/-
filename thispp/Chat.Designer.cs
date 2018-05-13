namespace programmingQuickSetup
{
    partial class Chat
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
            this.loginGbox = new System.Windows.Forms.GroupBox();
            this.ipLab = new System.Windows.Forms.Label();
            this.IPTxt = new System.Windows.Forms.TextBox();
            this.portLab = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGbox
            // 
            this.loginGbox.Controls.Add(this.label1);
            this.loginGbox.Controls.Add(this.loginBtn);
            this.loginGbox.Controls.Add(this.portTxt);
            this.loginGbox.Controls.Add(this.portLab);
            this.loginGbox.Controls.Add(this.IPTxt);
            this.loginGbox.Controls.Add(this.ipLab);
            this.loginGbox.Location = new System.Drawing.Point(21, 12);
            this.loginGbox.Name = "loginGbox";
            this.loginGbox.Size = new System.Drawing.Size(200, 220);
            this.loginGbox.TabIndex = 0;
            this.loginGbox.TabStop = false;
            this.loginGbox.Text = "LOG IN";
            // 
            // ipLab
            // 
            this.ipLab.AutoSize = true;
            this.ipLab.Location = new System.Drawing.Point(6, 31);
            this.ipLab.Name = "ipLab";
            this.ipLab.Size = new System.Drawing.Size(17, 13);
            this.ipLab.TabIndex = 0;
            this.ipLab.Text = "IP";
            // 
            // IPTxt
            // 
            this.IPTxt.Location = new System.Drawing.Point(47, 24);
            this.IPTxt.Name = "IPTxt";
            this.IPTxt.Size = new System.Drawing.Size(132, 20);
            this.IPTxt.TabIndex = 1;
            // 
            // portLab
            // 
            this.portLab.AutoSize = true;
            this.portLab.Location = new System.Drawing.Point(5, 56);
            this.portLab.Name = "portLab";
            this.portLab.Size = new System.Drawing.Size(37, 13);
            this.portLab.TabIndex = 2;
            this.portLab.Text = "PORT";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(48, 53);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(131, 20);
            this.portTxt.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(103, 79);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(76, 31);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "button1";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 420);
            this.Controls.Add(this.loginGbox);
            this.Name = "Chat";
            this.Text = "Chat";
            this.loginGbox.ResumeLayout(false);
            this.loginGbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Label portLab;
        private System.Windows.Forms.TextBox IPTxt;
        private System.Windows.Forms.Label ipLab;
    }
}