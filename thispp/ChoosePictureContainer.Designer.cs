namespace programmingQuickSetup
{
    partial class ChoosePictureContainer
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
            this.btnBoard01 = new System.Windows.Forms.Button();
            this.btnBoard02 = new System.Windows.Forms.Button();
            this.btnBoard03 = new System.Windows.Forms.Button();
            this.btnBoard04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "您想将该图片放置到哪个相框？";
            // 
            // btnBoard01
            // 
            this.btnBoard01.Location = new System.Drawing.Point(38, 61);
            this.btnBoard01.Name = "btnBoard01";
            this.btnBoard01.Size = new System.Drawing.Size(75, 23);
            this.btnBoard01.TabIndex = 1;
            this.btnBoard01.Text = "相框-1";
            this.btnBoard01.UseVisualStyleBackColor = true;
            this.btnBoard01.Click += new System.EventHandler(this.btnBoard01_Click);
            // 
            // btnBoard02
            // 
            this.btnBoard02.Location = new System.Drawing.Point(135, 61);
            this.btnBoard02.Name = "btnBoard02";
            this.btnBoard02.Size = new System.Drawing.Size(75, 23);
            this.btnBoard02.TabIndex = 2;
            this.btnBoard02.Text = "相框-2";
            this.btnBoard02.UseVisualStyleBackColor = true;
            this.btnBoard02.Click += new System.EventHandler(this.btnBoard02_Click);
            // 
            // btnBoard03
            // 
            this.btnBoard03.Location = new System.Drawing.Point(38, 109);
            this.btnBoard03.Name = "btnBoard03";
            this.btnBoard03.Size = new System.Drawing.Size(75, 23);
            this.btnBoard03.TabIndex = 3;
            this.btnBoard03.Text = "相框-3";
            this.btnBoard03.UseVisualStyleBackColor = true;
            this.btnBoard03.Click += new System.EventHandler(this.btnBoard03_Click);
            // 
            // btnBoard04
            // 
            this.btnBoard04.Location = new System.Drawing.Point(135, 109);
            this.btnBoard04.Name = "btnBoard04";
            this.btnBoard04.Size = new System.Drawing.Size(75, 23);
            this.btnBoard04.TabIndex = 4;
            this.btnBoard04.Text = "相框-4";
            this.btnBoard04.UseVisualStyleBackColor = true;
            this.btnBoard04.Click += new System.EventHandler(this.btnBoard04_Click);
            // 
            // ChoosePictureContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 164);
            this.Controls.Add(this.btnBoard04);
            this.Controls.Add(this.btnBoard03);
            this.Controls.Add(this.btnBoard02);
            this.Controls.Add(this.btnBoard01);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosePictureContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChoosePictureContainer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoard01;
        private System.Windows.Forms.Button btnBoard02;
        private System.Windows.Forms.Button btnBoard03;
        private System.Windows.Forms.Button btnBoard04;
    }
}