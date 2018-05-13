namespace programmingQuickSetup
{
    partial class PictureControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnRight);
            this.panel1.Controls.Add(this.BtnLeft);
            this.panel1.Controls.Add(this.pbView);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 488);
            this.panel1.TabIndex = 3;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            // 
            // BtnRight
            // 
            this.BtnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRight.BackColor = System.Drawing.Color.Transparent;
            this.BtnRight.BackgroundImage = global::programmingQuickSetup.Properties.Resources.LeftRotatet;
            this.BtnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRight.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRight.Location = new System.Drawing.Point(481, -2);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(32, 28);
            this.BtnRight.TabIndex = 2;
            this.BtnRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRight.UseVisualStyleBackColor = false;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLeft.BackColor = System.Drawing.Color.Transparent;
            this.BtnLeft.BackgroundImage = global::programmingQuickSetup.Properties.Resources.RightRotatet;
            this.BtnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLeft.Location = new System.Drawing.Point(449, -2);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(32, 28);
            this.BtnLeft.TabIndex = 1;
            this.BtnLeft.UseVisualStyleBackColor = false;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // pbView
            // 
            this.pbView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbView.Location = new System.Drawing.Point(4, 5);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(497, 476);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbView.TabIndex = 0;
            this.pbView.TabStop = false;
            this.pbView.SizeChanged += new System.EventHandler(this.pbView_SizeChanged);
            this.pbView.Click += new System.EventHandler(this.pbView_Click);
            this.pbView.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbView_DragEnter);
            this.pbView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbView_MouseDown);
            this.pbView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbView_MouseMove);
            // 
            // PictureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "PictureControl";
            this.Size = new System.Drawing.Size(517, 494);
            this.Load += new System.EventHandler(this.PictureControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
    }
}
