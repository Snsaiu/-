using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingQuickSetup
{
    public partial class PictureControl : UserControl
    {

       
        public PictureControl(  )
        {
            InitializeComponent();


            this.AllowDrop = true;
            this.MouseWheel += PictureControl_MouseWheel;
           
        }

        private void PictureControl_MouseWheel(object sender, MouseEventArgs e)
        {

           
             
              
            
            Size t = this.pbView.Size;//将照片的尺寸给t
                t.Height += e.Delta;
                t.Width += e.Delta;
                this.pbView.Size = t;

            this.pbView.Location = new Point(this.pbView.Location.X - (e.Delta / 2), this.pbView.Location.Y - (e.Delta / 2));



        }

        /// <summary>
        /// 获得图像
        /// </summary>
        /// <param name="image">传入需要显示的图像文件</param>
        public void Image(Bitmap image)
        {
            this.pbView.Image = image;
        }






        Point mouseP = new Point();//声明一个坐标用来表示鼠标左键按下时的位置
        private void pbView_MouseDown(object sender, MouseEventArgs e)
        {
            mouseP = e.Location;

        }
     

        private void pbView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
               int mouseMoveX = mouseP.X - e.Location.X;
               int mouseMoveY = mouseP.Y - e.Location.Y;

                Point newPoint = new Point();//新的图片坐标
               newPoint.X = this.pbView.Location.X - mouseMoveX;
                newPoint.Y = this.pbView.Location.Y - mouseMoveY;
                this.pbView.Location = newPoint;
            
            }

        }


        private void PictureControl_Load(object sender, EventArgs e)
        {

        }

        private void pbView_SizeChanged(object sender, EventArgs e)
        {
       
        }

     //   int currentVale;
     

        private void pbView_Click(object sender, EventArgs e)
        {
            pbView.Focus();
        
         
            
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                this.pbView.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                this.pbView.Refresh();
            }
            catch { }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            try
            {
                this.pbView.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                this.pbView.Refresh();
            }
            catch
            { }
            
        }

        private void pbView_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("hah");
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("hh");
        }
    }
}
