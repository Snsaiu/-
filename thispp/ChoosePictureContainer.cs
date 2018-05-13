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
    public partial class ChoosePictureContainer : Form
    {
        public ChoosePictureContainer(int num)
        {

            InitializeComponent();

            switch (num)
            {

                case 2:
                    this.btnBoard03.Enabled = false;
                     this.btnBoard04.Enabled = false;
            break;
                case 3:
                    this.btnBoard04.Enabled = false;
                    break;
               
                default:
                    break;
            }

        }
        ///// <summary>
        ///// 构造方法，获取当前打开几个视图
        ///// </summary>
        ///// <param name="num">哪个窗口可用</param>
        ///// <param name="path">文件的路径</param>
        //public ChoosePictureContainer(int num,string path)
        //{
        //    switch (num)
        //    {

        //        case 2:
        //            this.btnBoard03.Enabled = false;
        //            this.btnBoard04.Enabled = false;
        //            break;
        //        case 3:
        //            this.btnBoard04.Enabled = false;
        //            break;

        //        default:
        //            break;
        //    }
        //}
        public int SelectFrame { get; set; }
        private void btnBoard01_Click(object sender, EventArgs e)
        {
            this.SelectFrame = 1;
            this.Close();
        }

        private void btnBoard02_Click(object sender, EventArgs e)
        {
            this.SelectFrame = 2;
            this.Close();
        }

        private void btnBoard03_Click(object sender, EventArgs e)
        {
            this.SelectFrame = 3;
            this.Close();
        }

        private void btnBoard04_Click(object sender, EventArgs e)
        {
            this.SelectFrame = 4;
            this.Close();
        }
    }
}
