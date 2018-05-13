using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingQuickSetup
{
    public partial class WarnningSave : Form
    {
        public WarnningSave(string Info)
        {
            InitializeComponent();
            Random rand = new Random();
            string[] name = new string[] { "爸爸", "老大", "老公", "陛下" };
           // this.labSavePro.Text =name[rand.Next(0,4)]+ ",快保存" + Info + "项目！";
            this.labSavePro.Text = "皮皮虾!" + "快保存" + Info + "文件！";
            //this.labSavePro.Text = "预防out of memory !" + "是时候上传" + Info + "了!";
        }


     static  bool b = false;
      static  int loop = 50;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1 && b == false)
            {
                this.Opacity+=0.1;
                b = false;
            }


            if (this.Opacity == 1)
            {
                if (loop == 0)
                {
                   
                    b = true;
                   
                }
                loop--;
            }
            if (this.Opacity >= 0 && b == true)
            {
                this.Opacity-=0.1;
                if (this.Opacity == 0)
                {
                    b = false;
                    loop = 50;
                    this.Close();
                }
            }

        }


        
    }
}
