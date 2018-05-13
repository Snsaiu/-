namespace programmingQuickSetup
{
    partial class WarnningSave
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labSavePro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labSavePro
            // 
            this.labSavePro.AutoSize = true;
            this.labSavePro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labSavePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labSavePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSavePro.ForeColor = System.Drawing.Color.Red;
            this.labSavePro.Image = global::programmingQuickSetup.Properties.Resources.sy_20100410100959952919;
            this.labSavePro.Location = new System.Drawing.Point(31, 50);
            this.labSavePro.Name = "labSavePro";
            this.labSavePro.Size = new System.Drawing.Size(86, 31);
            this.labSavePro.TabIndex = 0;
            this.labSavePro.Text = "label1";
            // 
            // WarnningSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programmingQuickSetup.Properties.Resources.sy_20100410100959952919;
            this.ClientSize = new System.Drawing.Size(611, 131);
            this.ControlBox = false;
            this.Controls.Add(this.labSavePro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarnningSave";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarnningSave";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labSavePro;
    }
}