using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Xml; 

namespace programmingQuickSetup
{
    public partial class MainWindow : Form
    {


      

        public MainWindow()
        {
            InitializeComponent();
           
        }

     

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            SwitchWindowSave.SwitchWindowObj.Visible = true;

            
          

        }

        string GetTomWeather = null;
        private void MainWindow_Load(object sender, EventArgs e)
        {
          
          
          
            //创建xml文档
            XmlDocument xmldoc = new XmlDocument();

       
            if (!File.Exists("data.xml"))
            {
              XmlDeclaration dec= xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmldoc.AppendChild(dec);
                XmlElement root1 = xmldoc.CreateElement("dataCol");
                xmldoc.AppendChild(root1);
                xmldoc.Save("data.xml");
                labInfo.Text = "xml created successful!";
             
            }

           

            xmldoc.Load("data.xml");
            //应用帮助提示
            if(xmldoc.SelectSingleNode("dataCol/MainWindow").Attributes["help"].Value=="true")
            {
                this.cbHelp.Checked = true;
                this.ttMainWindow.Active = true;
            }
            else
            {
                this.cbHelp.Checked = false;
                this.ttMainWindow.Active = false;
            }

            GetTomWeather = xmldoc.SelectSingleNode("dataCol/TomCityWeather").Attributes["weather"].Value;
            //
            if (xmldoc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T1"].Value=="true")
            {
                this.cbT1.Checked = true;
            }
            else
            {
                this.cbT1.Checked = false;
            }

            if (xmldoc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T2"].Value == "true")
            {
                this.cbT2.Checked = true;
            }
            else
            {
                this.cbT2.Checked = false;
            }

            if (xmldoc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T3"].Value == "true")
            {
                this.cbT3.Checked = true;
            }
            else
            {
                this.cbT3.Checked = false;
            }

            if (xmldoc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T4"].Value == "true")
            {
                this.cbT4.Checked = true;
            }
            else
            {
                this.cbT4.Checked = false;
            }

            if (xmldoc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T5"].Value == "true")
            {
                this.cbT5.Checked = true;
            }
            else
            {
                this.cbT5.Checked = false;
            }

            if (xmldoc.SelectSingleNode("dataCol/IsAppRemind").Attributes["T6"].Value == "true")
            {
                this.cbT6.Checked = true;
            }
            else
            {
                this.cbT6.Checked = false;
            }


            XmlElement root = xmldoc.DocumentElement;
            XmlNodeList list = root.ChildNodes;
            foreach (XmlNode node in list)
            {
                if (node.Name == "CityWeather")
                {
                    XmlNode repleaseWeather = xmldoc.SelectSingleNode("dataCol/CityWeather");
                    //获得cityweather节点下的所有属性
                    //判断是否需要更新天气
                    //1个小时更新一次，判断方法当前时间减去上次更新时间，如果时间差大于1个小时进行更新                                                                     
                    int latestTime = int.Parse(repleaseWeather.Attributes["latestTime"].Value);//获得后更新时间
                    int currentHour = DateTime.UtcNow.Hour;
                    //如果当前时间-最后更新时间大于等于1，那么进行天气更新
                    if (Math.Abs(currentHour-latestTime)>=1)    
                    {
                        GetWeather getweather = new GetWeather();
                        getweather.getWeather(repleaseWeather.Attributes["cityname"].Value);
                        repleaseWeather.Attributes["weather"].Value = getweather.Getclound;
                        repleaseWeather.Attributes["temp"].Value = getweather.Gettemperature;
                        repleaseWeather.Attributes["latestTime"].Value = DateTime.Now.Hour.ToString();
                       
                        xmldoc.Save("data.xml");
                        
                        lbWeather.Text = repleaseWeather.Attributes["cityname"].Value + repleaseWeather.Attributes["weather"].Value + repleaseWeather.Attributes["temp"].Value;
                    }
                    else
                    {
                        lbWeather.Text = repleaseWeather.Attributes["cityname"].Value + repleaseWeather.Attributes["weather"].Value + repleaseWeather.Attributes["temp"].Value;
                    }
                    break;
                }
                else
                {
         
                    XmlElement CityInfo = xmldoc.CreateElement("CityWeather");
                    CityInfo.SetAttribute("cityname", "南京");
                    CityInfo.SetAttribute("weather", "good");
                    CityInfo.SetAttribute("temp", "20");
                    CityInfo.SetAttribute("latestTime", "1");
                    root.AppendChild(CityInfo);
                    xmldoc.Save("data.xml");
                    break;
                   // labInfo.Text = "create CityInfo!";
                  //  xmldoc.Load("data.xml");
                  //  lbWeather.Text = xmldoc.SelectSingleNode("dataCol/CityWeather").Attributes["weather"].Value.ToString();
                }

            }

            //判断下滑
            isdroped = false;
            string sourcePath = Application.StartupPath;
            string shortcut = Path.GetFileName(Application.ExecutablePath) + " - Shortcut.lnk";
            string targetPath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp" + "\\" + shortcut;
           
            if (File.Exists(targetPath))
            {
                cbAutoSetup.Checked = true;
            }
            else
            {
                cbAutoSetup.Checked = false;
            }



            //读取时间提醒
            RemindList remindlist = new RemindList();

            for (int i = 0; i < remindlist.Filename.Length; i++)
            {
                string[] NameAndContent = FileNameToText.NameToText(remindlist.Filename[i]);
                ListViewItem lv = new ListViewItem(new string[] { NameAndContent[0], NameAndContent[1] });
                lvRemind.Items.Add(lv);
            }



           




            //string SaveWeatherCity = Application.StartupPath + "\\" + "cityOfWeather";
            //if (!Directory.Exists(SaveWeatherCity))
            //{
            //    Directory.CreateDirectory(SaveWeatherCity);
            //}
            //string saceWeatherCityFile = SaveWeatherCity + "\\" + "City.txt";
            //if (!File.Exists(saceWeatherCityFile))
            //{
            //    lbWeather.Text = "双击添加天气";
            //}
            //else
            //{
            //    string cityName;
            //    using (StreamReader sr = new StreamReader(saceWeatherCityFile))
            //    {
            //        cityName = sr.ReadToEnd();
            //    }
            //    programmingQuickSetup.GetWeather getweather = new programmingQuickSetup.GetWeather();
            //    getweather.getWeather(cityName);
            //    lbWeather.Text = cityName + ":" + getweather.Getclound + ";温度:" + getweather.Gettemperature;
            //}




            #region windowLocation
            RemindInfo.IsHidder = true;
            //Screen x = Screen.PrimaryScreen;
            //Rectangle r = x.Bounds;

            //Point p = new Point(r.Width-300, r.Y);
            this.Location = new Point(Control.MousePosition.X-100, Control.MousePosition.Y-20);



            #endregion



            //废弃初始化应用方法
            #region
            /*

                        #region app1 init
                        {
                            if (File.Exists(fullpath + "\\" + "btnApp1.txt") == false)
                            {

                                return;
                            }
                            string appfilename;
                            using (StreamReader sr = new StreamReader(fullpath + "\\" + "btnApp1.txt"))
                            {

                                appfilename = sr.ReadToEnd();

                            }

                            if (appfilename != "")
                            {
                               // btnApp1.Text = Path.GetFileNameWithoutExtension(appfilename);
                                btnApp1.Image = (GetExeIcon.GetIcon(appfilename, true)).ToBitmap();
                            }

                        }
                        #endregion
                        #region  app2 init
                        {
                            if (File.Exists(fullpath + "\\" + "btnApp2.txt") == false)
                            {

                                return;
                            }
                            string appfilename;
                            using (StreamReader sr = new StreamReader(fullpath + "\\" + "btnApp2.txt"))
                            {

                                appfilename = sr.ReadToEnd();

                            }

                            if (appfilename != "")
                            {
                               // btnApp2.Text = Path.GetFileNameWithoutExtension(appfilename);
                                btnApp2.Image = (GetExeIcon.GetIcon(appfilename, true)).ToBitmap();
                            }
                            else
                            {
                                this.btnApp2.Text = "右击添加快捷应用";
                            }
                        }
                        #endregion
                        #region app3init
                        {
                            if (File.Exists(fullpath + "\\" + "btnApp3.txt") == false)
                            {

                                return;
                            }
                            string appfilename;
                            using (StreamReader sr = new StreamReader(fullpath + "\\" + "btnApp3.txt"))
                            {

                                appfilename = sr.ReadToEnd();

                            }

                            if (appfilename != "")
                            {
                               // btnApp3.Text = Path.GetFileNameWithoutExtension(appfilename);
                                btnApp3.Image = (GetExeIcon.GetIcon(appfilename, true)).ToBitmap();
                            }

                        }
                        #endregion
                        #region app4init
                        {
                            if (File.Exists(fullpath + "\\" + "btnApp4.txt") == false)
                            {

                                return;
                            }
                            string appfilename;
                            using (StreamReader sr = new StreamReader(fullpath + "\\" + "btnApp4.txt"))
                            {

                                appfilename = sr.ReadToEnd();

                            }

                            if (appfilename != "")
                            {
                               // btnApp4.Text = Path.GetFileNameWithoutExtension(appfilename);
                                btnApp4.Image = (GetExeIcon.GetIcon(appfilename, true)).ToBitmap();
                            }

                        }

                        #endregion
                        #region app5init
                        {
                            if (File.Exists(fullpath + "\\" + "btnApp5.txt") == false)
                            {

                                return;
                            }
                            string appfilename;
                            using (StreamReader sr = new StreamReader(fullpath + "\\" + "btnApp5.txt"))
                            {

                                appfilename = sr.ReadToEnd();

                            }

                            if (appfilename != "")
                            {
                               // btnApp5.Text = Path.GetFileNameWithoutExtension(appfilename);
                                btnApp5.Image = (GetExeIcon.GetIcon(appfilename, true)).ToBitmap();
                            }

                        }
                        #endregion

                        #region app6init
                        {
                            if (File.Exists(fullpath + "\\" + "btnApp6.txt") == false)
                            {

                                return;
                            }
                            string appfilename;
                            using (StreamReader sr = new StreamReader(fullpath + "\\" + "btnApp6.txt"))
                            {

                                appfilename = sr.ReadToEnd();

                            }

                            if (appfilename != "")
                            {
                               // btnApp6.Text = Path.GetFileNameWithoutExtension(appfilename);
                                btnApp6.Image = (GetExeIcon.GetIcon(appfilename, true)).ToBitmap();
                            }

                        }
                        #endregion

                        */

            #endregion
            Button[] btnlists = new Button[] { btnApp1, btnApp2, btnApp3, btnApp4, btnApp5, btnApp6 };
            SetQuickApp initApp = SetQuickApp.GetInstace();
            initApp.SetIcomn(btnlists);


            //天气显示



         
            if (GetTomWeather.Contains("雨")|| GetTomWeather.Contains("雪"))
            {
                Timer timerWeatherWarn = new Timer();
                timerWeatherWarn.Interval = 1500;
                timerWeatherWarn.Enabled = true;
                timerWeatherWarn.Tick += TimerWeatherWarn_Tick;
            }

        }

        private void TimerWeatherWarn_Tick(object sender, EventArgs e)
        {
            Color[] color = new Color[] { Color.Yellow, Color.Red, Color.SteelBlue,Color.Azure,Color.BlueViolet,Color.DarkKhaki};
            Random rand = new Random();
            this.labInfo.ForeColor= color[rand.Next(0, 5)];
           
          string[]getTomInfo= GetTomWeather.Split(' ');
            this.labInfo.Text = "明天" + getTomInfo[1] + "出门记得带伞,衣服记得收!";
        }






        /*    读取到此结束*/





        static string  fullpath= Application.StartupPath+"\\"+"apppath";//全局路径
       /// <summary>
       /// 创建一个新的快捷应用app1
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerWindowHidder.Enabled = false;
            SetQuickApp newapp = SetQuickApp.GetInstace();
            //SetQuickApp newapp = new SetQuickApp();
            newapp.NewApp(btnApp1);
           this.btnApp1.Image=( GetExeIcon.GetIcon(newapp.AppPath, true)).ToBitmap();
            timerWindowHidder.Enabled = true;
            
        }
        /// <summary>
        /// 新建应用的方法
        /// </summary>
        /// <param name="CurrentBtn">当前按钮</param>
    

        /// <summary>
        /// 打开app1快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApp1_Click(object sender, EventArgs e)
        {
            SetQuickApp openApp = SetQuickApp.GetInstace();
           if( openApp.OpenApp(btnApp1))
            {
                labInfo.Text = "应用正在打开";
               
            }
            else
            {
                labInfo.Text = "应用无法打开";
            }
        }
       
        /// <summary>
        /// 删除app1快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            SetQuickApp deleteapp = SetQuickApp.GetInstace();
            deleteapp.DeleteAPP(btnApp1);
            labInfo.Text = "App1 delete OK";
        }
        /// <summary>
        /// 创建一个新的快捷应用app2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timerWindowHidder.Enabled = false;
             SetQuickApp newapp = SetQuickApp.GetInstace();
            //SetQuickApp newapp = new SetQuickApp();
            newapp.NewApp(btnApp2);
            timerWindowHidder.Enabled = true;
        }
        /// <summary>
        /// 删除app2快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            SetQuickApp deleteapp = SetQuickApp.GetInstace();
            deleteapp.DeleteAPP(btnApp2);
            labInfo.Text = "App2 delete OK";
        }
        /// <summary>
        /// 打开app2快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApp2_Click(object sender, EventArgs e)
        {
            SetQuickApp openApp = SetQuickApp.GetInstace();
            if (openApp.OpenApp(btnApp2))
            {
                labInfo.Text = "应用正在打开";
            }
            else
            {
                labInfo.Text = "应用无法打开";
            }
        }
        /// <summary>
        /// 创建一个新的快捷应用app3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timerWindowHidder.Enabled = false;
            SetQuickApp newapp = SetQuickApp.GetInstace();
            //SetQuickApp newapp = new SetQuickApp();
            newapp.NewApp(btnApp3);
            timerWindowHidder.Enabled = true;
        }
        /// <summary>
        /// 删除app3快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
         
            SetQuickApp deleteapp = SetQuickApp.GetInstace();
            deleteapp.DeleteAPP(btnApp3);
            labInfo.Text = "App3 delete OK";
        }
        /// <summary>
        /// 打开app3快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApp3_Click(object sender, EventArgs e)
        {
            SetQuickApp openApp = SetQuickApp.GetInstace();
            if (openApp.OpenApp(btnApp3))
            {
                labInfo.Text = "应用正在打开";
            }
            else
            {
                labInfo.Text = "应用无法打开";
            }
        }
        /// <summary>
        /// 创建一个新的快捷应用app4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timerWindowHidder.Enabled = false;
            SetQuickApp newapp = SetQuickApp.GetInstace();
            //SetQuickApp newapp = new SetQuickApp();
            newapp.NewApp(btnApp4);
            timerWindowHidder.Enabled = true;
        }
        /// <summary>
        /// 删除app4快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
         
            SetQuickApp deleteapp = SetQuickApp.GetInstace();
            deleteapp.DeleteAPP(btnApp4);
            labInfo.Text = "App4 delete OK";
        }
        /// <summary>
        /// 打开app4快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApp4_Click(object sender, EventArgs e)
        {
            SetQuickApp openApp = SetQuickApp.GetInstace();
            if (openApp.OpenApp(btnApp4))
            {
                labInfo.Text = "应用正在打开";
            }
            else
            {
                labInfo.Text = "应用无法打开";
            }
        }
        /// <summary>
        /// 新建一个新的快捷应用app5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timerWindowHidder.Enabled = false;
            SetQuickApp newapp = SetQuickApp.GetInstace();
            //SetQuickApp newapp = new SetQuickApp();
            newapp.NewApp(btnApp5);
            timerWindowHidder.Enabled = true;
        }
        /// <summary>
        /// 删除app5快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
          
            SetQuickApp deleteapp = SetQuickApp.GetInstace();
            deleteapp.DeleteAPP(btnApp5);
            labInfo.Text = "App5 delete OK";
        }
        /// <summary>
        /// 打开快捷应用app5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApp5_Click(object sender, EventArgs e)
        {
            SetQuickApp openApp = SetQuickApp.GetInstace();
            if (openApp.OpenApp(btnApp5))
            {
                labInfo.Text = "应用正在打开";
            }
            else
            {
                labInfo.Text = "应用无法打开";
            }
        }
        /// <summary>
        /// 新建一个快捷应用app6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            timerWindowHidder.Enabled = false;
            SetQuickApp newapp = SetQuickApp.GetInstace();
            //SetQuickApp newapp = new SetQuickApp();
            newapp.NewApp(btnApp6);
            timerWindowHidder.Enabled = true;
        }
        /// <summary>
        /// 删除app6快捷应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            SetQuickApp deleteapp = SetQuickApp.GetInstace();
            deleteapp.DeleteAPP(btnApp6);
            labInfo.Text = "App6 delete OK";
        }
        /// <summary>
        /// 打开app6应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApp6_Click(object sender, EventArgs e)
        {
            SetQuickApp openApp = SetQuickApp.GetInstace();
            if (openApp.OpenApp(btnApp6))
            {
                labInfo.Text = "应用正在打开";
            }
            else
            {
                labInfo.Text = "应用无法打开";
            }
        }

        private void MainWindow_MouseHover(object sender, EventArgs e)
        {
            timerWindowHidder.Enabled = true;
            timerWindowHidder.Start();
        }

        /// <summary>
        ///
        /// </summary>
       public static bool loop = true;//
        private void timerWindowHidder_Tick(object sender, EventArgs e)
        {

            Point p = Control.MousePosition;
            int windowHeight = this.Size.Height;//获得当前窗口的高度
            int windowWidth = this.Size.Width;//获得当前窗口的宽度
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;//获得当前屏幕的高度
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;//获得当前屏幕的宽度

            int NullPointXLeft = this.Location.X;//获得当前左边窗口的空白区域
            int NullPointXRight = this.Location.X + windowWidth;//获得当前右边窗口的空白区域

            int NullPointYTop = this.Location.Y;//获得当前窗口顶部的空白区域
            int NullPointYBottom = this.Location.Y + windowHeight;//获得当前窗口底部的空白区域

            int MousePointX = Control.MousePosition.X;//获取当前鼠标的x位置
            int MousePointY = Control.MousePosition.Y;//获取当前鼠标的Y位置

            
            if ((MousePointX < NullPointXLeft || MousePointX > NullPointXRight || MousePointY < NullPointYTop || MousePointY > NullPointYBottom)&&RemindInfo.IsHidder==true)
            {
               
              
                this.Opacity -= 0.2;
                if (this.Opacity==0)
                {
                    lvRemind.Clear();
                    this.Close();
                }
            }
            else 
            {
                this.Opacity = 1;
            }

            
            if (!(txtRWcontent.Text == "") && char.IsDigit(txtRWcontent.Text.Substring(0, 1)[0])&&loop==true)
            {
                this.btnMonth.Enabled = true;
                this.btnDay.Enabled = true;
                this.btnHour.Enabled = true;
                this.btnMinute.Enabled = true;
                loop = false;
            }
            else if( (txtRWcontent.Text.Contains("明天") || txtRWcontent.Text.Contains("后天") || txtRWcontent.Text.Contains("大后天"))&&loop==true)
            {
                this.btnHour.Enabled = true;
                //this.btnMinute.Enabled = true;
                loop = false;
            }
            //else
            //{
            //    this.btnMonth.Enabled = false;
            //    this.btnDay.Enabled = false;
            //    this.btnHour.Enabled = false;
            //    this.btnMinute.Enabled = false;
            //}



            if (txtRWcontent.Text.Contains("提醒") == false && (txtRWcontent.Text.Contains("日") || txtRWcontent.Text.Contains("点") || txtRWcontent.Text.Contains("分")))
            {


                this.btnRemindOK.Enabled = true;



            }
            else if (txtRWcontent.Text.Contains("提醒") == false && (txtRWcontent.Text.Contains("明天") || txtRWcontent.Text.Contains("后天") || txtRWcontent.Text.Contains("大后天")))
            {
                this.btnRemindOK.Enabled = true;
            }
            else if (txtRWcontent.Text.Contains("提醒") == false && (txtRWcontent.Text.Contains("上午") || txtRWcontent.Text.Contains("早上") || txtRWcontent.Text.Contains("中午") || txtRWcontent.Text.Contains("下午") || txtRWcontent.Text.Contains("晚上") || txtRWcontent.Text.Contains("凌晨")))
            {
                this.btnRemindOK.Enabled = true;
            }
            else
            {
                this.btnRemindOK.Enabled = false;


            }

            if (txtRWcontent.Text.Contains("提醒") == true)
            {
                this.btnMonth.Enabled = false;
                this.btnDay.Enabled = false;
                this.btnHour.Enabled = false;
                this.btnMinute.Enabled = false;
            }



            if (txtRWcontent.Text != "")
            {
                this.Opacity = 1;

            }

        }

        private void btnGetId_Click(object sender, EventArgs e)
        {
            GetPCId getpcid = new GetPCId();
            txtRWcontent.Text = "IP地址为:\r\n" + getpcid.StrAddr+"\r\n"+getpcid.GetCPUName()+"\r\n"+getpcid.GetHostName()+"\r\n"+getpcid.GetMemoryInfo()+"\r\n"+getpcid.GetGPUInfo()+"\r\n"+getpcid.GetSolutionInfo();
            this.labInfo.Text = "支持的信息已被读入！";
        }

        private void btnOpenPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void btnOpenNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void btnOpenCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }


     
        private void btnRemind_Click(object sender, EventArgs e)
        {
           
            if (txtRWcontent.Text=="")
            {
                RemindInfo.IsHidder = false;
               labInfo.Text= "您没有输入任何内容！我不知道该怎么办！";               
                return;
            }
            
            RemindInfo remindinfo = new RemindInfo(txtRWcontent.Text);
            remindinfo.condition01();
            TimeCondition timecondition = new TimeCondition(remindinfo);
            TimeAndDateOut tdo = new TimeAndDateOut(remindinfo, timecondition);
            tdo.GetFullDate();
            txtRWcontent.Text = tdo.Outtext;
           
          
            
        }

        private void btnRegedit_Click(object sender, EventArgs e)
        {
            Process.Start("regedit");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                int indexname = this.lvRemind.SelectedItems[0].Index;
                DeleteRemind.delete(indexname);

                this.lvRemind.Refresh();
            }
            catch
            {
                
            }
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            this.txtRWcontent.Text += "月";
            if (txtRWcontent.Text.Contains("月"))
            {

                this.btnMonth.Enabled = false;
                this.btnHour.Enabled = false;
                this.btnMinute.Enabled = false;
            }
            txtRWcontent.Focus();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            this.txtRWcontent.Text += "日";
            if (txtRWcontent.Text.Contains("日"))
            {
                this.btnDay.Enabled = false;
                this.btnMonth.Enabled = false;
                this.btnMinute.Enabled = false;
                this.btnHour.Enabled = true;
            }
            txtRWcontent.Focus();
        }

        


        private void btnHour_Click(object sender, EventArgs e)
        {
            this.txtRWcontent.Text += "点";

            if (txtRWcontent.Text.Contains("点"))
            {
                this.btnHour.Enabled = false;
                this.btnMonth.Enabled = false;
                this.btnDay.Enabled = false;
                this.btnMinute.Enabled = true;
            }
            txtRWcontent.Focus();
        }

        private void btnMinute_Click(object sender, EventArgs e)
        {
            this.txtRWcontent.Text += "分";

            if (txtRWcontent.Text.Contains("分"))
            {
                this.btnMonth.Enabled = false;
                this.btnDay.Enabled = false;
                this.btnHour.Enabled = false;
                this.btnMinute.Enabled = false;
            }
            txtRWcontent.Focus();
        }

        private void btnRemindOK_Click(object sender, EventArgs e)
        {
            this.txtRWcontent.Text += "提醒我";
            txtRWcontent.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtRWcontent.Text = "";

            this.btnMonth.Enabled = false;
            this.btnDay.Enabled = false;
            this.btnHour.Enabled = false;
            this.btnMinute.Enabled = false;
            loop = true;
        }


        public static bool isdroped = false;
        private void timerDropWindow_Tick(object sender, EventArgs e)
        {
           
            if (isdroped == true &&this.Height<=740)
            {
                this.Height -= 1;
                if (this.Height == 630)
                {
                    timerDropWindow.Enabled = false;
                    isdroped = false;
                    return;
                }
            }

            if (isdroped == false&&this.Height>=630)
            {
                this.Height += 1;
                if (this.Height == 740)
                {
                    timerDropWindow.Enabled = false;
                    isdroped = true;
                    return;
                }
            }


        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            timerDropWindow.Enabled = true;
        }

        private void cbAutoSetup_CheckedChanged(object sender, EventArgs e)
        {

            //StartUpSys startupInfo = new StartUpSys();

            //if (this.cbAutoSetup.Checked==true)
            //{
            //    startupInfo.ShortCutAndStartUp();
            //    this.labInfo.Text = "Create Successful!";
            //}

            //else
            //{
            //    startupInfo.DelStartUp();
            //    this.labInfo.Text = "Delete Successful!";
            //}


            //string sourcePath = Application.StartupPath;
            //string shortcut = Path.GetFileName(Application.ExecutablePath) + " - Shortcut.lnk";
            //string targetPath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp" + "\\" + shortcut;
            //try
            //{
            //    if (this.cbAutoSetup.Checked == true)
            //    {

            //        File.Copy(sourcePath + "\\" + shortcut, targetPath);
            //        txtRWcontent.Text = "true";
            //    }
            //    else
            //    {
            //        File.Delete(targetPath);
            //        txtRWcontent.Text = "false";
            //    }

            //}
            //catch
            //{


            //}

        }

        private void lbWeather_DoubleClick(object sender, EventArgs e)
        {
            string SaveWeatherCity = Application.StartupPath + "\\" + "cityOfWeather";
            if (!Directory.Exists(SaveWeatherCity))
            {
                Directory.CreateDirectory(SaveWeatherCity);
            }
            string saveWeatherCityFile = SaveWeatherCity + "\\" + "City.txt";
            if (!File.Exists(saveWeatherCityFile))
            {
                File.Create(saveWeatherCityFile);
            }

            OpenWeatherDialog openweatherdialo = new OpenWeatherDialog();
            openweatherdialo.SendWeatherCity += Openweatherdialo_SendWeatherCity;
            timerWindowHidder.Enabled = false;
            openweatherdialo.ShowDialog();
            timerWindowHidder.Enabled = true;



        }

        private void Openweatherdialo_SendWeatherCity(object sender, CitySendArgs e)
        {

            GetWeather getweather = new GetWeather();
            getweather.getWeather(e.Name);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("data.xml");
            XmlNode node = xmldoc.SelectSingleNode("dataCol/CityWeather");//获得cityweather节点
                                                                          //将设置的城市付给cityname属性
            node.Attributes["cityname"].Value = e.Name;
            node.Attributes["weather"].Value = getweather.Getclound;
            node.Attributes["temp"].Value = getweather.Gettemperature;
            xmldoc.Save("data.xml");
            lbWeather.Text = e.Name + node.Attributes["weather"].Value + node.Attributes["temp"].Value;





            //string SaveWeatherCity = Application.StartupPath + "\\" + "cityOfWeather";
            //string saveWeatherCityFile = SaveWeatherCity + "\\" + "City.txt";
            //using (StreamWriter sw=new StreamWriter(saveWeatherCityFile))
            //{
            //    sw.Write(e.Name);
            //}

            //GetWeather getweather = new GetWeather();
            //getweather.getWeather(e.Name);

            //lbWeather.Text = e.Name + ":" + getweather.Getclound + ";温度:" + getweather.Gettemperature;
        }

        private void btnExtended_Click(object sender, EventArgs e)
        {
            ExtensionFunction extensionfunction = new ExtensionFunction();
            extensionfunction.Show();
        }

        private void cbT1_CheckedChanged(object sender, EventArgs e)
        {
            //如果被选中，那么xml文档中的isappremind 中的Tx属性会被赋值为true 否则为false
            if (this.cbT1.Checked==true)
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T1的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T1"].Value = "true";
                doc.Save("data.xml");//保存
                labInfo.Text = "App1 will automatic timing";
            }
            else
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T1的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T1"].Value = "false";
                doc.Save("data.xml");//保存
                labInfo.Text = "App1 will cancel automatic timing";
            }
        }

        private void cbT2_CheckedChanged(object sender, EventArgs e)
        {
            //如果被选中，那么xml文档中的isappremind 中的Tx属性会被赋值为true 否则为false
            if (this.cbT2.Checked == true)
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T2的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T2"].Value = "true";
                doc.Save("data.xml");//保存
                labInfo.Text = "App2 will automatic timing";
            }
            else
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T2的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T2"].Value = "false";
                doc.Save("data.xml");//保存
                labInfo.Text = "App2 will cancel automatic timing";
            }
        }

        private void cbT3_CheckedChanged(object sender, EventArgs e)
        {
            //如果被选中，那么xml文档中的isappremind 中的Tx属性会被赋值为true 否则为false
            if (this.cbT3.Checked == true)
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T3的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T3"].Value = "true";
                doc.Save("data.xml");//保存
                labInfo.Text = "App3 will automatic timing";
            }
            else
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T3的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T3"].Value = "false";
                doc.Save("data.xml");//保存
                labInfo.Text = "App3 will cancel automatic timing";
            }
        }

        private void cbT4_CheckedChanged(object sender, EventArgs e)
        {
            //如果被选中，那么xml文档中的isappremind 中的Tx属性会被赋值为true 否则为false
            if (this.cbT4.Checked == true)
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T4的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T4"].Value = "true";
                doc.Save("data.xml");//保存
                labInfo.Text = "App4 will automatic timing";
            }
            else
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T4的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T4"].Value = "false";
                doc.Save("data.xml");//保存
                labInfo.Text = "App4 will cancel automatic timing";
            }
        }

        private void cbT5_CheckedChanged(object sender, EventArgs e)
        {
            //如果被选中，那么xml文档中的isappremind 中的Tx属性会被赋值为true 否则为false
            if (this.cbT5.Checked == true)
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T5的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T5"].Value = "true";
                doc.Save("data.xml");//保存
                labInfo.Text = "App5 will automatic timing";
            }
            else
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T5的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T5"].Value = "false";
                doc.Save("data.xml");//保存
                labInfo.Text = "App5 will cancel automatic timing";
            }
        }

        private void cbT6_CheckedChanged(object sender, EventArgs e)
        {
            //如果被选中，那么xml文档中的isappremind 中的Tx属性会被赋值为true 否则为false
            if (this.cbT6.Checked == true)
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T6的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T6"].Value = "true";
                doc.Save("data.xml");//保存
                labInfo.Text = "App6 will automatic timing";
            }
            else
            {
                XmlDocument doc = new XmlDocument();//声明xml对象
                doc.Load("data.xml");//读取根目录下data.xml文档
                                     //修改文档内IsAppRemind T6的属性为true；
                XmlNode node = doc.SelectSingleNode("dataCol/IsAppRemind");
                node.Attributes["T6"].Value = "false";
                doc.Save("data.xml");//保存
                labInfo.Text = "App6 will cancel automatic timing";
            }
        }

        private void cbApp_SelectedIndexChanged(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");

            switch (this.cbApp.SelectedItem.ToString())
            {
                case "APP1":
                    doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT1"].Value = txtSetTime.Text;
                    doc.Save("data.xml");
                    labInfo.Text = "modify APP1 Timer " + txtSetTime.Text + " Minutes";
                    break;
                case "APP2":
                    doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT2"].Value = txtSetTime.Text;
                    doc.Save("data.xml");
                    labInfo.Text = "modify APP2 Timer " + txtSetTime.Text + " Minutes";
                    break;
                case "APP3":
                    doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT3"].Value = txtSetTime.Text;
                    doc.Save("data.xml");
                    labInfo.Text = "modify APP3 Timer " + txtSetTime.Text + " Minutes";
                    break;
                case "APP4":
                    doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT4"].Value = txtSetTime.Text;
                    doc.Save("data.xml");
                    labInfo.Text = "modify APP4 Timer " + txtSetTime.Text + " Minutes";
                    break;
                case "APP5":
                    doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT5"].Value = txtSetTime.Text;
                    doc.Save("data.xml");
                    labInfo.Text = "modify APP5 Timer " + txtSetTime.Text + " Minutes";
                    break;
                case "APP6":
                    doc.SelectSingleNode("dataCol/AppTiming").Attributes["AT6"].Value = txtSetTime.Text;
                    doc.Save("data.xml");
                    labInfo.Text = "modify APP6 Timer " + txtSetTime.Text + " Minutes";
                    break;

                default:
                    break;
            }
        }

        private void txtSetTime_TextChanged(object sender, EventArgs e)
        {
            if (txtSetTime.Text==""||txtSetTime.Text==null)
            {
                this.cbApp.Enabled = false;
            }
            else
            {
                this.cbApp.Enabled = true;
            }
        }


        public delegate void CanClearRamEventHandler( bool canclear);
        public event CanClearRamEventHandler CanClearRamEvents;

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CanClearRamEvents != null)
            {
                bool canclear = true;
                CanClearRamEvents(canclear);
            }
        }

        private void ctmsQuickApp3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
           
            if (this.cbHelp.Checked==true)
            {
                this.ttMainWindow.Active = true;
                doc.SelectSingleNode("dataCol/MainWindow").Attributes["help"].Value = "true";
                doc.Save("data.xml");
                this.labInfo.Text = "应用提示已打开";
            }
            else
            {
                this.ttMainWindow.Active= false;
                doc.SelectSingleNode("dataCol/MainWindow").Attributes["help"].Value = "false";
                doc.Save("data.xml");
                this.labInfo.Text = "应用提示已关闭";
            }

        }
    }
}
