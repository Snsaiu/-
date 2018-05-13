using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace programmingQuickSetup
{
    public partial class PictureWindow : Form
    {



        //定义第二个图片对象
        PictureControl pictureControl02 = new PictureControl();
        //定义第三个图片对象
        PictureControl pictureControl03 = new PictureControl();
        //定义第四个图片对象
        PictureControl pictureControl04 = new PictureControl();
        public PictureWindow()
        {
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);


            InitializeComponent();

      




            //第一个图片
            this.pictureControl01.Size = new Size(this.Width - 30, this.Height - this.lvSolo.Height - this.menuStrip1.Height - 80);

            //第二个图片

            pictureControl02.BackColor = Color.DarkTurquoise;
            pictureControl02.Anchor = AnchorStyles.Right;
            pictureControl02.Anchor = AnchorStyles.Top;
            this.Controls.Add(pictureControl02);
            pictureControl02.Visible = false;
            //第三个图片

            pictureControl03.BackColor = Color.DarkViolet;
            this.Controls.Add(pictureControl03);
            pictureControl03.Visible = false;
            pictureControl03.Anchor = AnchorStyles.Left;
            pictureControl03.Anchor = AnchorStyles.Bottom;
            //第四个图片

            pictureControl04.BackColor = Color.DarkSlateBlue;
            this.Controls.Add(pictureControl04);
            pictureControl04.Visible = false;
            pictureControl04.Anchor = AnchorStyles.Right;
            pictureControl04.Anchor = AnchorStyles.Bottom;

        }

     

        List<string> pictureList = new List<string>();//存储照片路径
     //   string[] getPic;//将解析到的JPG付给数组
        string collectFile;//将打开的文件夹付给全局变量，如果用户点击保存收藏夹那么此变量作为路径
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();//获得了指定的文件夹
            if (fbd.SelectedPath == "")
            {
                return;
            }
            collectFile = fbd.SelectedPath;
            PictureFind picturefind = new PictureFind(fbd.SelectedPath);//将路径传给picturefind类中进行解析
            picturefind.IsJpg();//解析并存储jpg的文件
            picturefind.IsPNG();//解析并存储png的文件
            pictureList.Clear();
            //   getPic = picturefind.CanOpenPicArr;//将解析到的JPG付给数组
            //将jpg格式付给list

            for (int i = 0; i < picturefind.CanOpenPicArr.Length; i++)
            {
                pictureList.Add(picturefind.CanOpenPicArr[i]);
            }
            //将png格式付给list
            for (int i = 0; i < picturefind.PngFile.Length; i++)
            {
                pictureList.Add(picturefind.PngFile[i]);
            }

            int soloWidth = this.lvSolo.Size.Width;//LISTVIEW的宽度
            Size size = new Size(soloWidth, soloWidth);
            //  this.imageList.ImageSize = size;//缩略图的宽度定义为listview的宽度
            this.lvSolo.Items.Clear();
            this.imageList.Images.Clear();
         //   MessageBox.Show(Math.Ceiling(Convert.ToDouble(this.lvSolo.Width / (this.imageList.ImageSize.Width * 2 + 30))).ToString());
            for (int i = 0; i <pictureList.Count ; i++)
            {
              
                    this.imageList.Images.Add(Image.FromFile(pictureList[i]));
                    string getSoloName = Path.GetFileNameWithoutExtension(pictureList[i]);//获取纯文件不包含后缀
                    this.lvSolo.Items.Add(Path.GetFileName(getSoloName), i);
               
            }
            ClearRam.ClearMemory();



        }

        private void tbSoleScal_Scroll(object sender, EventArgs e)
        {
            this.tbSoleScal.Maximum = this.Height - 200;
            this.tbSoleScal.Minimum = this.tbSoleScal.Height;
            this.lvSolo.Height = this.tbSoleScal.Value;

        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.topToolStripMenuItem.Text == "Top")
            {
                this.TopMost = false;
                this.topToolStripMenuItem.Text = "UnTop";
            }
            else
            {
                this.TopMost = true;
                this.topToolStripMenuItem.Text = "Top";
            }
        }

        int getNumber; //获取当前图片序列号

        private void lvSolo_SelectedIndexChanged(object sender, EventArgs e)
        {


            if ((pictureControl02.Visible == true) && (pictureControl03.Visible == false) && (pictureControl04.Visible == false))
            {
                ChoosePictureContainer choosepic = new ChoosePictureContainer(2);
                choosepic.ShowDialog();

                ChoosePicByFrame(choosepic.SelectFrame);
                this.lvSolo.SelectedItems.Clear();

            }
            else if ((pictureControl03.Visible == true) && (pictureControl04.Visible == false) && (pictureControl02.Visible == true))
            {
                ChoosePictureContainer choosepic = new ChoosePictureContainer(3);
                choosepic.ShowDialog();

                ChoosePicByFrame(choosepic.SelectFrame);
                this.lvSolo.SelectedItems.Clear();
            }

            else if ((pictureControl04.Visible == true) && (pictureControl03.Visible == true) && (pictureControl02.Visible == true))
            {
                ChoosePictureContainer choosepic = new ChoosePictureContainer(4);
                choosepic.ShowDialog();

                ChoosePicByFrame(choosepic.SelectFrame);
                this.lvSolo.SelectedItems.Clear();

            }
            else
            {
                try
                {
                    getNumber = this.lvSolo.SelectedItems[0].Index;

                    this.pictureControl01.Image(new Bitmap(pictureList[getNumber]));
                    this.lvSolo.SelectedItems.Clear();
                }
                catch { }

            }




        }
        /// <summary>
        /// 判断相片被指定到哪个相框
        /// </summary>
        /// <param name="choosepic">哪个相框</param>
        private void ChoosePicByFrame(int choosepic)
        {
            switch (choosepic)
            {
                case 1:
                    try
                    {
                        getNumber = this.lvSolo.SelectedItems[0].Index;
                        this.lvSolo.SelectedItems.Clear();
                        this.pictureControl01.Image(new Bitmap(pictureList[getNumber]));
                    }
                    catch { }
                    break;
                case 2:
                    try
                    {
                        getNumber = this.lvSolo.SelectedItems[0].Index;

                        this.pictureControl02.Image(new Bitmap(pictureList[getNumber]));
                    }
                    catch { }
                    break;
                case 3:
                    try
                    {
                        getNumber = this.lvSolo.SelectedItems[0].Index;

                        this.pictureControl03.Image(new Bitmap(pictureList[getNumber]));
                    }
                    catch { }
                    break;
                case 4:
                    try
                    {
                        getNumber = this.lvSolo.SelectedItems[0].Index;
                        this.lvSolo.SelectedItems.Clear();
                        this.pictureControl04.Image(new Bitmap(pictureList[getNumber]));
                    }
                    catch { }
                    break;
                default:
                    break;
            }
        }





        //切换到二视图
        private void SecView_Click(object sender, EventArgs e)
        {

            this.pictureControl01.Size = new Size(this.Width / 2, this.Height - this.lvSolo.Height - this.menuStrip1.Height - 80);
            pictureControl02.Location = new Point(pictureControl01.Size.Width + 10, pictureControl01.Location.Y);
            pictureControl02.Size = new Size(pictureControl01.Size.Width - 30, pictureControl01.Size.Height);
            pictureControl01.Visible = true;
            pictureControl02.Visible = true;
            pictureControl03.Visible = false;

            pictureControl04.Visible = false;


        }


        //切换到一视图
        private void FirView_Click(object sender, EventArgs e)
        {

            pictureControl01.Visible = true;
            pictureControl02.Visible = false;
            pictureControl03.Visible = false;
            pictureControl04.Visible = false;
            this.pictureControl01.Size = new Size(this.Width - 30, this.Height - this.lvSolo.Height - this.menuStrip1.Height - 80);





        }
        //切换到三视图
        private void ThirView_Click(object sender, EventArgs e)
        {
            //重绘视图 1
            this.pictureControl01.Size = new Size(this.Width / 2, (this.Height - this.lvSolo.Height) / 2);

            //重绘视图 2;
            this.pictureControl02.Location = new Point(pictureControl01.Size.Width + 30, this.pictureControl01.Location.Y);
            pictureControl02.Size = this.pictureControl02.Size = new Size(this.Width / 2 - 30, this.Height - this.lvSolo.Height - this.menuStrip1.Height);


            //重绘视图 3
            pictureControl03.Location = new Point(pictureControl01.Location.X, pictureControl01.Size.Height + pictureControl01.Location.Y);
            pictureControl03.Size = pictureControl01.Size;

            pictureControl01.Visible = true;
            pictureControl02.Visible = true;
            pictureControl03.Visible = true;
            pictureControl04.Visible = false;
        }



        //窗口尺寸改变进行侦听
        private void PictureWindow_SizeChanged(object sender, EventArgs e)
        {
            //如果视图二被关闭，
            if (pictureControl02.Visible == false)
            {
                //视图三 与四都被关闭
                pictureControl03.Visible = false;
                pictureControl04.Visible = false;
                this.pictureControl01.Size = new Size(this.Width - 30, this.Height - this.lvSolo.Height - this.menuStrip1.Height - 80);
            }

            //如果视图三被关闭
            else if (pictureControl03.Visible == false)
            {

                //视图四被关闭
                pictureControl04.Visible = false;
                //侦听第一个图片状态
                this.pictureControl01.Size = new Size(this.Width / 2, this.Height - this.lvSolo.Height - this.menuStrip1.Height - 80);

                //侦听第二个图片状态
                pictureControl02.Location = new Point(pictureControl01.Size.Width + 10, pictureControl01.Location.Y);
                pictureControl02.Size = this.pictureControl02.Size = new Size(this.Width / 2 - 30, this.Height - this.lvSolo.Height - this.menuStrip1.Height - 80);
                //侦听第三个图片状态
            }
            //如果视图4被关闭
            else if (pictureControl04.Visible == false)
            {
                //  侦听第一个图片状态
                this.pictureControl01.Size = new Size(this.Width / 2, (this.Height - this.lvSolo.Height) / 2);
                // 侦听第二个图片状态
                pictureControl02.Location = new Point(pictureControl01.Size.Width + 10, pictureControl01.Location.Y);
                pictureControl02.Size = this.pictureControl02.Size = new Size(this.Width / 2 - 30, this.Height - this.lvSolo.Height - this.menuStrip1.Height);
                //侦听第三个图片状态
                pictureControl03.Location = new Point(pictureControl01.Location.X, pictureControl01.Size.Height + pictureControl01.Location.Y);
                pictureControl03.Size = new Size(pictureControl01.Size.Width, pictureControl01.Size.Height);

            }
            else
            {

                //矫正视图1

                this.pictureControl01.Size = new Size(this.Width / 2, (this.Height - this.lvSolo.Height) / 2);
                //矫正视图2
                pictureControl02.Location = new Point(pictureControl01.Size.Width + 10, pictureControl01.Location.Y);
                this.pictureControl02.Size = new Size(this.Width / 2 - 30, this.pictureControl01.Size.Height);
                //  矫正视图3
                pictureControl03.Location = new Point(pictureControl01.Location.X, pictureControl01.Size.Height + pictureControl01.Location.Y);
                pictureControl03.Size = pictureControl01.Size;

                //矫正视图4
                this.pictureControl04.Location = new Point(this.pictureControl02.Location.X, this.pictureControl03.Location.Y);
                this.pictureControl04.Size = pictureControl02.Size;
            }

        }
        //切换到视图4
        private void FourView_Click(object sender, EventArgs e)
        {
            //显示所有视图
            this.pictureControl01.Visible = true;
            this.pictureControl02.Visible = true;
            this.pictureControl03.Visible = true;
            this.pictureControl04.Visible = true;
            //矫正视图尺寸 
            //矫正视图1
            this.pictureControl01.Size = new Size(this.Width / 2, (this.Height - this.lvSolo.Height) / 2);
            //矫正视图2
            pictureControl02.Location = new Point(pictureControl01.Size.Width + 10, pictureControl01.Location.Y);
            this.pictureControl02.Size = new Size(this.Width / 2 - 30, this.pictureControl01.Size.Height);
            //矫正视图3
            pictureControl03.Location = new Point(pictureControl01.Location.X, pictureControl01.Size.Height + pictureControl01.Location.Y);
            pictureControl03.Size = pictureControl01.Size;
            //矫正视图4
            this.pictureControl04.Location = new Point(this.pictureControl02.Location.X, this.pictureControl03.Location.Y);
            this.pictureControl04.Size = pictureControl02.Size;
        }

        private void tssmOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.JPG|所有文件|*.*";
            ofd.ShowDialog();
            if (ofd.FileName == "")
            {
                return;
            }

            if ((pictureControl02.Visible == true) && (pictureControl03.Visible == false) && (pictureControl04.Visible == false))
            {
                ChoosePictureContainer choosepic = new ChoosePictureContainer(2);
                choosepic.ShowDialog();
                Bitmap bt = new Bitmap(ofd.FileName);
                switch (choosepic.SelectFrame)
                {
                    case 1:
                        this.pictureControl01.Image(bt);
                        break;

                    case 2:
                        this.pictureControl02.Image(bt);
                        break;

                    default:
                        break;
                }


            }
            else if ((pictureControl03.Visible == true) && (pictureControl04.Visible == false) && (pictureControl02.Visible == true))
            {
                ChoosePictureContainer choosepic = new ChoosePictureContainer(3);
                choosepic.ShowDialog();

                Bitmap bt = new Bitmap(ofd.FileName);
                switch (choosepic.SelectFrame)
                {
                    case 1:
                        this.pictureControl01.Image(bt);
                        break;

                    case 2:
                        this.pictureControl02.Image(bt);
                        break;
                    case 3:
                        this.pictureControl03.Image(bt);
                        break;

                    default:
                        break;
                }
            }

            else if ((pictureControl04.Visible == true) && (pictureControl03.Visible == true) && (pictureControl02.Visible == true))
            {
                ChoosePictureContainer choosepic = new ChoosePictureContainer(4);
                choosepic.ShowDialog();

                Bitmap bt = new Bitmap(ofd.FileName);
                switch (choosepic.SelectFrame)
                {
                    case 1:
                        this.pictureControl01.Image(bt);
                        break;

                    case 2:
                        this.pictureControl02.Image(bt);
                        break;
                    case 3:
                        this.pictureControl03.Image(bt);
                        break;
                    case 4:
                        this.pictureControl04.Image(bt);
                        break;

                    default:
                        break;
                }

            }
            else
            {

                Bitmap bt = new Bitmap(ofd.FileName);
                this.pictureControl01.Image(bt);


            }

        }

        private void tssmCollector_Click(object sender, EventArgs e)
        {

            if (this.lvSolo.Items.Count == 0)
            {
                MessageBox.Show("文件夹不存在!");
                return;
            }

            XmlDocument doc = new XmlDocument();
            if (File.Exists("data.xml"))
            {
                doc.Load("data.xml");
                XmlNode Collect = doc.SelectSingleNode(@"dataCol/CollectPath");
                string origPath = Collect.InnerText;//原始的路径地址
                string[] check = origPath.Split(new char[] { '|' });
                //检查文件路径是否存在重复！
                for (int i = 0; i < check.Length; i++)
                {
                    if (check[i] == collectFile)
                    {
                        return;
                    }
                }
                string finishPath = origPath + collectFile + "|";//修改后的路径
                Collect.InnerText = finishPath;//将修改后的路径加入xml
                this.cbCollector.Items.Clear();
                this.lbDeleteCollector.Items.Clear();
                string[] listAdd = Collect.InnerText.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < listAdd.Length; i++)
                {
                    cbCollector.Items.Add(listAdd[i]);
                    lbDeleteCollector.Items.Add(listAdd[i]);
                }
                doc.Save("data.xml");
                MessageBox.Show("收藏成功！");

                if (check.Length == 0)
                {
                    this.cbCollector.MaxDropDownItems = 1;
                }
                else
                {
                    this.cbCollector.MaxDropDownItems = check.Length;
                }
            }


        }

        private void PictureWindow_Load(object sender, EventArgs e)
        {


            this.pictureControl01.AllowDrop = true;
            XmlDocument doc = new XmlDocument();
            if (File.Exists("data.xml"))
            {
                doc.Load("data.xml");

                XmlNode path = doc.SelectSingleNode("dataCol/CollectPath");
                string allPath = path.InnerText;
                string[] subPath = allPath.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < subPath.Length; i++)
                {
                    cbCollector.Items.Add(subPath[i]);
                    lbDeleteCollector.Items.Add(subPath[i]);
                }
                if (subPath.Length == 0)
                {
                    this.cbCollector.MaxDropDownItems = 1;
                }
                else
                {
                    this.cbCollector.MaxDropDownItems = subPath.Length;
                }
            }
        }

        //private void tscbListCollect_SelectedIndexChanged(object sender, EventArgs e)
        //{



        //    this.lvSolo.Items.Clear();
        //    pictureList = null;
        //    this.imageList.Images.Clear();
        //    PictureFind pf = new PictureFind(this.cbCollector.SelectedItem.ToString());
        //    pf.IsJpg();
        //    getPic = pf.CanOpenPicArr;
        //    for (int i = 0; i < getPic.Length; i++)
        //    {
        //        this.imageList.Images.Add(Image.FromFile(getPic[i]));

        //        string getSoloName = Path.GetFileNameWithoutExtension(getPic[i]);//获取纯文件不包含后缀
        //        this.lvSolo.Items.Add(Path.GetFileName(getSoloName), i);
        //    }

        //}

        private void cbCollector_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.lvSolo.Items.Clear();
            pictureList.Clear();
            this.imageList.Images.Clear();
            PictureFind pf = new PictureFind(this.cbCollector.SelectedItem.ToString());
            //if (!pf.IsJpg()&&!pf.IsPNG())
            //{
            //    return;
            //}
            pf.IsJpg();
            pf.IsPNG();
            //将jpg导入list
          
                for (int i = 0; i < pf.CanOpenPicArr.Length; i++)
                {
                    this.pictureList.Add(pf.CanOpenPicArr[i]);
                }
           
            //将png导入list
          
                for (int i = 0; i < pf.PngFile.Length; i++)
                {
                    this.pictureList.Add(pf.PngFile[i]);
                }

            for (int i = 0; i < pictureList.Count; i++)
            {
                this.imageList.Images.Add(Image.FromFile(pictureList[i]));

                string getSoloName = Path.GetFileNameWithoutExtension(pictureList[i]);//获取纯文件不包含后缀
                this.lvSolo.Items.Add(Path.GetFileName(getSoloName), i);
            }

            ClearRam.ClearMemory();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //读取xml文档
         


            if (File.Exists("data.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("data.xml");
                XmlNode GetCollectorInfo = doc.SelectSingleNode("dataCol/CollectPath");
                // 获得子路径
                string[] SubColloctorPath = GetCollectorInfo.InnerText.Split(new char[] { '|' },StringSplitOptions.RemoveEmptyEntries);
                if (SubColloctorPath .Length==0)
                {
                    return;
                }
                string deletedThenCombine = null;
                for (int i = 0; i < SubColloctorPath.Length; i++)
                {
                    if (this.lbDeleteCollector.Items[0].ToString()!=SubColloctorPath[i])
                    {
                        deletedThenCombine += SubColloctorPath[i] + "|";
                    }
                   
                }
                GetCollectorInfo.InnerText = deletedThenCombine;
                doc.Save("data.xml");
                //刷新列表
                this.lbDeleteCollector.Items.Clear();
                this.cbCollector.Items.Clear();
                doc.Load("data.xml");
                XmlNode SecGetList=doc.SelectSingleNode("dataCol/CollectPath");
                SubColloctorPath = GetCollectorInfo.InnerText.Split(new char[] { '|' },StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < SubColloctorPath.Length; i++)
                {
                    lbDeleteCollector.Items.Add(SubColloctorPath[i]);
                    cbCollector.Items.Add(SubColloctorPath[i]);
                }
                this.cbCollector.Refresh();
            }
        }

        private void timeLBout_Tick(object sender, EventArgs e)
        {
            if (this.lbDeleteCollector.Width == 220)
            {

                this.timeLBout.Enabled = false;
                this.timerLBin.Enabled = true;
               
                return;
            }
            this.lbDeleteCollector.Width += 10;
        }

        private void timerLBin_Tick(object sender, EventArgs e)
        {
            if (MousePosition.X > this.Location.X + lbDeleteCollector.Width || MousePosition.Y < this.Location.Y || MousePosition.X < this.Location.X || MousePosition.Y > this.Location.Y + this.lbDeleteCollector.Height)
            {
                this.lbDeleteCollector.Width -= 10;
                if (this.lbDeleteCollector.Width == 0)
                {
                    this.DeleteCollectorToolStripMenuItem.Enabled = true;
                    this.timerLBin.Enabled = false;
                }
            }
            else
            {
                this.timerLBin.Enabled = false;
                this.timeLBout.Enabled = true;
            }
        }

        private void DeleteCollectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.timeLBout.Enabled = true;
            this.DeleteCollectorToolStripMenuItem.Enabled = false;
        }

        private void pictureControl01_Load(object sender, EventArgs e)
        {
            this.pictureControl01.AllowDrop = true;
        }

        private void PictureWindow_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("hh");
        }
    }
}
