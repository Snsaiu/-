namespace programmingQuickSetup
{
    partial class OpenWeatherDialog
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
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCityOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "城市名称";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(65, 53);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(103, 20);
            this.txtCityName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入您要查询的城市";
            // 
            // btnCityOk
            // 
            this.btnCityOk.Location = new System.Drawing.Point(174, 51);
            this.btnCityOk.Name = "btnCityOk";
            this.btnCityOk.Size = new System.Drawing.Size(75, 23);
            this.btnCityOk.TabIndex = 3;
            this.btnCityOk.Text = "查询";
            this.btnCityOk.UseVisualStyleBackColor = true;
            this.btnCityOk.Click += new System.EventHandler(this.btnCityOk_Click);
            // 
            // OpenWeatherDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 131);
            this.Controls.Add(this.btnCityOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OpenWeatherDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OpenWeatherDialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OpenWeatherDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCityOk;
    }
}