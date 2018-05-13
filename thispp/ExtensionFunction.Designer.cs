namespace programmingQuickSetup
{
    partial class ExtensionFunction
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
            this.btnOpenPicture = new System.Windows.Forms.Button();
            this.btnOpenMusic = new System.Windows.Forms.Button();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.openWeb = new System.Windows.Forms.Button();
            this.tcpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.Location = new System.Drawing.Point(12, 12);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.Size = new System.Drawing.Size(91, 23);
            this.btnOpenPicture.TabIndex = 0;
            this.btnOpenPicture.Text = "Picture Brower ";
            this.btnOpenPicture.UseVisualStyleBackColor = true;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenPicture_Click);
            // 
            // btnOpenMusic
            // 
            this.btnOpenMusic.Location = new System.Drawing.Point(12, 41);
            this.btnOpenMusic.Name = "btnOpenMusic";
            this.btnOpenMusic.Size = new System.Drawing.Size(91, 23);
            this.btnOpenMusic.TabIndex = 1;
            this.btnOpenMusic.Text = "Music Brower";
            this.btnOpenMusic.UseVisualStyleBackColor = true;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Location = new System.Drawing.Point(12, 70);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(91, 23);
            this.btnOpenVideo.TabIndex = 2;
            this.btnOpenVideo.Text = "Video Brower";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            // 
            // openWeb
            // 
            this.openWeb.Location = new System.Drawing.Point(12, 100);
            this.openWeb.Name = "openWeb";
            this.openWeb.Size = new System.Drawing.Size(91, 23);
            this.openWeb.TabIndex = 3;
            this.openWeb.Text = "Web Brower";
            this.openWeb.UseVisualStyleBackColor = true;
            // 
            // tcpBtn
            // 
            this.tcpBtn.Location = new System.Drawing.Point(12, 129);
            this.tcpBtn.Name = "tcpBtn";
            this.tcpBtn.Size = new System.Drawing.Size(91, 26);
            this.tcpBtn.TabIndex = 4;
            this.tcpBtn.Text = "联机传输";
            this.tcpBtn.UseVisualStyleBackColor = true;
            this.tcpBtn.Click += new System.EventHandler(this.tcpBtn_Click);
            // 
            // ExtensionFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 167);
            this.Controls.Add(this.tcpBtn);
            this.Controls.Add(this.openWeb);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.btnOpenMusic);
            this.Controls.Add(this.btnOpenPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtensionFunction";
            this.Text = "ExtensionFunction";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExtensionFunction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPicture;
        private System.Windows.Forms.Button btnOpenMusic;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button openWeb;
        private System.Windows.Forms.Button tcpBtn;
    }
}