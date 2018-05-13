using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace programmingQuickSetup
{
    public partial class SwitchWindow : Form
    {

        
        public SwitchWindow()
        {
            InitializeComponent();
        }




      
        private void SwitchWindow_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;
          
        }

        MainWindow mainwindow = null;


        private void btnOpenManwindow_Click(object sender, EventArgs e)
        {

            mainwindow = new MainWindow();
            this.Visible = false;
            SwitchWindowSave.SwitchWindowObj = this;
           
            mainwindow.Show();
           
        }

        private void SwitchWindow_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 0.3;

        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            TimerSet timerset = new TimerSet();
            timerset.SendTimerNumber += Timerset_SendTimerNumber;
            timerset.Show();


            

        }


        static int OkTime;//声明用户定义的时间
        static int RepeatTime;//声明用于循环定时的时间备份
        private void Timerset_SendTimerNumber(object sender, string e)
        {
            string timeNumber = e;

            bool condition = int.TryParse(timeNumber, out OkTime);
            if (condition == false)
            {
                MessageBox.Show("error!");
                return;
            }
            OkTime *= 60;
            RepeatTime = OkTime;
            timer1.Enabled = true;

        }

        SoundPlayer spOne = new SoundPlayer(Application.StartupPath + "\\" + "Music" + "\\" + "one.WAV");//播放音乐对象
        private void timer1_Tick(object sender, EventArgs e)
        {


            TimerExe();
            if (lbViewTimer.Text=="0")
            {
                this.lbViewTimer.Visible = false;
            }
            else
            {
                this.lbViewTimer.Visible = true;
            }

            if (OkTime < 0 && MessageBox.Show("Time's up！please save you project!\nDo you want repeat?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                OkTime = RepeatTime;
                timer1.Enabled = true;

            }
            spOne.Stop();
        }

        private void TimerExe()
        {

            lbViewTimer.Text = (OkTime--).ToString();

            if (OkTime < 0)
            {
                timer1.Enabled = false;


                spOne.PlayLooping();
            }


        }
        /// <summary>
        /// 内存使用调用对象 全局
        /// </summary>
        GetRAMInfo getraminfo = new GetRAMInfo();

        //定时时间
        static int timingNumber01;
        static int timingNumber02;
        static int timingNumber03;
        static int timingNumber04;
        static int timingNumber05;
        static int timingNumber06;


       

        private void SwitchWindow_Load(object sender, EventArgs e)
        {

         



            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            timingNumber01= Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT1"].Value);
            timingNumber02 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT2"].Value);
            timingNumber03 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT3"].Value);
            timingNumber04 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT4"].Value);
            timingNumber05 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT5"].Value);
            timingNumber06 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT6"].Value);







            WindowLocation();

            ViewRamBarMethod();
            if (!Directory.Exists(Application.StartupPath + "\\" + "RemindFile"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\" + "RemindFile");
            }




        }

        private void ViewRamBarMethod()

        {
            string getTotalRam = GetTotalRamMethod();
            double getTotalParse = double.Parse(getTotalRam);
            string getAvailRam = NewMethod();
            double getAvailRamParse = double.Parse(getAvailRam);
            double usedRAM = getTotalParse - getAvailRamParse;
            double rate = 144 / getTotalParse;
            int usedBar = (int)(usedRAM * rate);        
            btnRamBar.Text = ((usedRAM / getTotalParse) * 100).ToString("0,0")+"%";
            if (((usedRAM / getTotalParse) * 100)>=80)
            {
                this.btnRamBar.BackColor = Color.Red;
            }
            else
            {
                this.btnRamBar.BackColor = Color.Green;
            }
            //CPU温度
            this.labCPUTem.Text = GetPCId.GetCOUTem();
        }
        
        private string GetTotalRamMethod()
        {
            int getTotalRamNumLengh = getraminfo.GetTotalRam.IndexOf("GB");
            string getTotalRam = getraminfo.GetTotalRam.Substring(0, getTotalRamNumLengh);
            return getTotalRam;
        }

        /// <summary>
        /// 获得当前系统的可用内存
        /// </summary>
        /// <returns></returns>
        private string NewMethod()
        {
            int getRamNumLengh = getraminfo.GetAvilRam.IndexOf("GB");
            string getAvailRam = getraminfo.GetAvilRam.Substring(0, getRamNumLengh);
            return getAvailRam;
        }


        /// <summary>
        /// 窗口位置
        /// </summary>
        private void WindowLocation()
        {

            Screen x = Screen.PrimaryScreen;
            Rectangle r = x.Bounds;

            Point p = new Point(r.Width - 300, r.Y);
            this.Location = p;
        }

        private void RAMViewBarTimer_Tick(object sender, EventArgs e)
        {

          

            ViewRamBarMethod();
            //if (this.Location.X < 0)
            //{
            //    this.Location = new Point(0, this.Location.Y);
            //}
            //if (this.Location.Y < 0)
            //{
            //    this.Location = new Point(this.Location.X, 0);
            //}

        }

        private void btnRamBar_Click(object sender, EventArgs e)
        {
            //优化内存

            ClearRam.ClearMemory();
        }

        private void timerRemind_Tick(object sender, EventArgs e)
        {
            RemindList remindlist = new RemindList();

            //  string x = "";
            SoundPlayer sp = new SoundPlayer(Application.StartupPath + "\\" + "Music" + "\\" + "two.WAV");

            for (int i = 0; i < remindlist.Filename.Length; i++)
            {
                string[] NameAndContent = FileNameToText.NameToText(remindlist.Filename[i]);
                string NowTime = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
                //    x = NowTime;
                if (NowTime == NameAndContent[2])
                {

                    sp.PlayLooping();
                    timerRemind.Enabled = false;
                    if (MessageBox.Show(NameAndContent[3], "Time's up", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        File.Delete(remindlist.Filename[i]);
                        sp.Stop();
                        timerRemind.Enabled = true;
                    }
                    else
                    {
                        File.Delete(remindlist.Filename[i]);
                        sp.Stop();
                        timerRemind.Enabled = true;
                    }
                }
                //MessageBox.Show(x);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool canMove;
        private void BtnMove_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
        }

        private void BtnMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove == true)
            {

                this.Location = new Point(Control.MousePosition.X - 90, Control.MousePosition.Y - this.Size.Height + 15);

            }
        }

        private void BtnMove_MouseLeave(object sender, EventArgs e)
        {
            canMove = false;
        }

        private void tAppRun_Tick(object sender, EventArgs e)
        {

            //app1

          
                        
                        this.T1.Enabled = true;
          
         
            //app2
           
                   
                        this.T2.Enabled = true;
          

            //app3
           
                        
                        this.T3.Enabled = true;
            

          
                        this.T4.Enabled = true;
          

            //app5
           
                 
                        this.T5.Enabled = true;
        

         
                        this.T6.Enabled = true;
             
        }
        //
       
   
        
            
     
        private void T1_Tick(object sender, EventArgs e)
        {
            string runfilename;//获得app的程序名不包含后缀

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
         runfilename= doc.SelectSingleNode("dataCol/App1").InnerText;
            runfilename = Path.GetFileNameWithoutExtension(runfilename);
            string appchecked = doc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T1"].Value;//获取xml文档中isappremind属性下的T
            HasAppRun hap = new HasAppRun(runfilename);
            if (!(hap.ConDitionIsrun()&&appchecked=="true"))
            {
                this.T1.Enabled = false;
            }
            else
            {
                timingNumber01--;
                if (timingNumber01==0)
                {
                    this.tAppRun.Enabled = false;//检测定时器不可用
                    appname = runfilename;
                    //T2.Enabled = false;
                    //T3.Enabled = false;
                    //T4.Enabled = false;
                    //T5.Enabled = false;
                    //T6.Enabled = false;
                    this.T1.Enabled = false;//当前计数器不可用
                    //SoundPlayer sp = new SoundPlayer(@"Music/two.wav");
                    //sp.Play();
                  
                    appname = runfilename;
                    timeWinDrop.Enabled = true;//显示定时器打开

                }
            }
        }



        int timedrop = 200;//设置下滑时间
        bool conditionDrop = true;//辅助判断是否下滑





        /// <summary>
        /// 下拉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        bool stopVoice = false;
        private void timeWinDrop_Tick(object sender, EventArgs e)
        {

           
   

            Color[] color = new Color[] {Color.Yellow,Color.Red,Color.SeaGreen };
            Random rd = new Random();

           
            this.btnAppWarn.BackColor = color[rd.Next(0, 3)];
            //下滑
            if (this.Height>=45&&conditionDrop==true)
            {

                
                this.Height ++;
                if (this.Height==70)
                {
                    conditionDrop = false;
                }
               
            }
            timedrop--;
            btnAppWarn.Text ="save  "+ appname+"  project!";


          

            if (stopVoice==false)
            {

                WarnningSave ws = new WarnningSave(appname);
                ws.Show();
                Voice OpenVoice = Voice.GetInstance();
                Action<string> act = new Action<string>(OpenVoice.TextToVoice);
                act.BeginInvoke("now! you should save" + appname + "project", null, null);
             
                stopVoice = true;
            }
          
         


            if (timedrop<=10&&conditionDrop==false)
            {
                this.Height--;
                if (this.Height==45)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("data.xml");
                    conditionDrop = true;
                    this.timeWinDrop.Enabled = false;
                    this.tAppRun.Enabled = true;
                    if (timingNumber01.ToString()=="0")
                    {
                        timingNumber01 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT1"].Value);
                    }
                    if (timingNumber02.ToString() == "0")
                    {
                        timingNumber02 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT2"].Value);
                    }
                    if (timingNumber03.ToString() == "0")
                    {
                        timingNumber03 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT3"].Value);
                    }
                    if (timingNumber04.ToString() == "0")
                    {
                        timingNumber04 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT4"].Value);
                    }
                    if (timingNumber05.ToString() == "0")
                    {
                        timingNumber05= Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT5"].Value);
                    }
                    if (timingNumber06.ToString() == "0")
                    {
                        timingNumber06 = Convert.ToInt32(doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT6"].Value);
                    }

                    timedrop = 200;
                    stopVoice = false;
                }
            }
        }
        static string appname;//全局程序名称
       
        private void T2_Tick(object sender, EventArgs e)
        {
            string runfilename;//获得app的程序名不包含后缀

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            runfilename = doc.SelectSingleNode("dataCol/App2").InnerText;
            runfilename = Path.GetFileNameWithoutExtension(runfilename);
            string appchecked = doc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T2"].Value;//获取xml文档中isappremind属性下的T
            HasAppRun hap = new HasAppRun(runfilename);
            if (!(hap.ConDitionIsrun() && appchecked == "true"))
            {
                this.T2.Enabled = false;
            }
            else
            {
                timingNumber02--;
                if (timingNumber02 == 0)
                {
                    this.tAppRun.Enabled = false;//检测定时器不可用
                    //T1.Enabled = false;
                    //T3.Enabled = false;
                    //T4.Enabled = false;
                    //T5.Enabled = false;
                    //T6.Enabled = false;
                    this.T2.Enabled = false;//当前计数器不可用
                 
                    appname = runfilename;
                  
                    timeWinDrop.Enabled = true;//显示定时器打开

                }
            }
        }
      
        private void T3_Tick(object sender, EventArgs e)
        {
            string runfilename;//获得app的程序名不包含后缀

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            runfilename = doc.SelectSingleNode("dataCol/App3").InnerText;
            runfilename = Path.GetFileNameWithoutExtension(runfilename);
            string appchecked = doc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T3"].Value;//获取xml文档中isappremind属性下的T
            HasAppRun hap = new HasAppRun(runfilename);
            if (!(hap.ConDitionIsrun() && appchecked == "true"))
            {
                this.T3.Enabled = false;
            }
            else
            {
                timingNumber03--;
                if (timingNumber03 == 0)
                {
                    this.tAppRun.Enabled = false;//检测定时器不可用
                    //T1.Enabled = false;
                    //T2.Enabled = false;
                    //T4.Enabled = false;
                    //T5.Enabled = false;
                    //T6.Enabled = false;
                    this.T3.Enabled = false;//当前计数器不可用
                  
                    appname = runfilename;
                  
                    timeWinDrop.Enabled = true;//显示定时器打开
                }
            }
        }
       
        private void T4_Tick(object sender, EventArgs e)
        {
            string runfilename;//获得app的程序名不包含后缀

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            runfilename = doc.SelectSingleNode("dataCol/App4").InnerText;
            runfilename = Path.GetFileNameWithoutExtension(runfilename);
            string appchecked = doc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T4"].Value;//获取xml文档中isappremind属性下的T
            HasAppRun hap = new HasAppRun(runfilename);
            if (!(hap.ConDitionIsrun() && appchecked == "true"))
            {
                this.T4.Enabled = false;
            }
            else
            {
                timingNumber04--;
                if (timingNumber04 == 0)
                {
                    this.tAppRun.Enabled = false;//检测定时器不可用
                    //T1.Enabled = false;
                    //T3.Enabled = false;
                    //T2.Enabled = false;
                    //T5.Enabled = false;
                    //T6.Enabled = false;
                   
                    this.T4.Enabled = false;//当前计数器不可用
                  
                    appname = runfilename;
                  
                    timeWinDrop.Enabled = true;//显示定时器打开
                }
            }
        }
        
        private void T5_Tick(object sender, EventArgs e)
        {
            string runfilename;//获得app的程序名不包含后缀

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            runfilename = doc.SelectSingleNode("dataCol/App5").InnerText;
            runfilename = Path.GetFileNameWithoutExtension(runfilename);
            string appchecked = doc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T5"].Value;//获取xml文档中isappremind属性下的T
            HasAppRun hap = new HasAppRun(runfilename);
            if (!(hap.ConDitionIsrun() && appchecked == "true"))
            {
                this.T5.Enabled = false;
            }
            else
            {
                timingNumber05--;
                if (timingNumber05 == 0)
                {

                    this.tAppRun.Enabled = false;//检测定时器不可用
                    //T1.Enabled = false;
                    //T3.Enabled = false;
                    //T4.Enabled = false;
                    //T2.Enabled = false;
                    //T6.Enabled = false;
                    this.T5.Enabled = false;//当前计数器不可用
                  
                    appname = runfilename;
                    
                    timeWinDrop.Enabled = true;//显示定时器打开
                }
            }
        }
        
        private void T6_Tick(object sender, EventArgs e)
        {
            string runfilename;//获得app的程序名不包含后缀

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            runfilename = doc.SelectSingleNode("dataCol/App6").InnerText;
            runfilename = Path.GetFileNameWithoutExtension(runfilename);
            string appchecked = doc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T6"].Value;//获取xml文档中isappremind属性下的T
            HasAppRun hap = new HasAppRun(runfilename);
            if (!(hap.ConDitionIsrun() && appchecked == "true"))
            {
                this.T6.Enabled = false;
            }
            else
            {
                timingNumber06--;
                if (timingNumber06 == 0)
                {
                    this.tAppRun.Enabled = false;//检测定时器不可用
                    //T1.Enabled = false;
                    //T3.Enabled = false;
                    //T4.Enabled = false;
                    //T5.Enabled = false;
                    //T2.Enabled = false;
                    this.T6.Enabled = false;//当前计数器不可用
                   
                    appname = runfilename;
                   
                    timeWinDrop.Enabled = true;//显示定时器打开
                }
            }
        }

      
        private void TimerClearRam_Tick(object sender, EventArgs e)
        {
            try
            {
               mainwindow.CanClearRamEvents += Mainwindow_CanClearRamEvents;
            }
            catch
            { }
        }

        private void Mainwindow_CanClearRamEvents(bool canclear)
        {
            if (canclear==true)
            {
                ClearRam.ClearMemory();
                canclear = false;
            }
        }
    }
}
