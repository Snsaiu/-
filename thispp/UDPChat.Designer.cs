namespace programmingQuickSetup
{
    partial class UDPChat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPcbox = new System.Windows.Forms.ComboBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rememberCbox = new System.Windows.Forms.CheckBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // IPcbox
            // 
            this.IPcbox.FormattingEnabled = true;
            this.IPcbox.Location = new System.Drawing.Point(30, 27);
            this.IPcbox.Name = "IPcbox";
            this.IPcbox.Size = new System.Drawing.Size(167, 21);
            this.IPcbox.TabIndex = 2;
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(255, 27);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(163, 20);
            this.portText.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Controls.Add(this.rememberCbox);
            this.groupBox1.Controls.Add(this.portText);
            this.groupBox1.Controls.Add(this.IPcbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOG IN";
            // 
            // rememberCbox
            // 
            this.rememberCbox.AutoSize = true;
            this.rememberCbox.Location = new System.Drawing.Point(10, 59);
            this.rememberCbox.Name = "rememberCbox";
            this.rememberCbox.Size = new System.Drawing.Size(72, 17);
            this.rememberCbox.TabIndex = 4;
            this.rememberCbox.Text = "remember";
            this.rememberCbox.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(88, 53);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(329, 27);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "LOG IN";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // UDPChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 621);
            this.Controls.Add(this.groupBox1);
            this.Name = "UDPChat";
            this.Text = "UDPChat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox IPcbox;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox rememberCbox;
    }
}