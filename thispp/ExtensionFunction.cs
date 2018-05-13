using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingQuickSetup
{
    public partial class ExtensionFunction : Form
    {
        public ExtensionFunction()
        {
            InitializeComponent();
        }

        private void ExtensionFunction_Load(object sender, EventArgs e)
        {
            #region  定义界面出现的位置在鼠标旁边
            this.Location = new Point(Control.MousePosition.X, Control.MousePosition.Y);
            #endregion

        }

        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            PictureWindow pw = new PictureWindow();
            pw.Show();
        }

        private void tcpBtn_Click(object sender, EventArgs e)
        {
        
        }
    }
}
