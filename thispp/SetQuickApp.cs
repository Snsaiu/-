using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Diagnostics;

namespace programmingQuickSetup
{
    class SetQuickApp
    {

        /// <summary>
        /// 获得当前按钮应用的路径
        /// </summary>
        public string  AppPath { get { return ofd.FileName; }  }
        OpenFileDialog ofd = new OpenFileDialog();
        XmlDocument doc = new XmlDocument();
        /// <summary>
        /// 新建快捷应用方法
        /// </summary>
        /// <param name="curBtn">指定的按钮</param>
        /// <returns>如果新建成功那么返回true，否则返回false</returns>
        public bool NewApp(Button curBtn)
        {
           
            ofd.Filter = "应用程序|*.exe|所有文件|*.*";
            ofd.Title = "Add Quick App";
            ofd.ShowDialog();

            //如果用户没有指定路径，那么返回
            if (ofd.FileName=="")
            {
                return false;
            }
            //将路径存入xml文档中

        
            if (File.Exists("data.xml"))//如果data存在，那么将路径存到data中
            {
                
                doc.Load("data.xml");

               // doc.SelectSingleNode(@"dataCol/App1").InnerText = "jj";
        GetBtnXML(curBtn).InnerText =ofd.FileName ;//将当前应用的路径与名称存入xml文档中
                doc.Save("data.xml");//保存
                Voice OpenVoice = Voice.GetInstance();
                OpenVoice.TextToVoice("Create succussfully");
                return true;
            }
            else
            {
                return false;
            }
      
        }

        /// <summary>
        /// 获取指定按钮下的xml节点
        /// </summary>
        /// <param name="curbtn"> 索引按钮控件，寻找xml中指定节点的索引条件</param>
        /// <returns>返回指定按钮控件的xml节点,如果索引失败返回null</returns>
        public XmlNode GetBtnXML(Button curBtn)
        {
          
            XmlNode AppXml = null;
            if (File.Exists("data.xml"))
            {
                doc.Load("data.xml");//读取data文档
                switch (curBtn.Name)
                {
                    case "btnApp1":
                        AppXml = doc.SelectSingleNode(@"dataCol/App1");
                        break;
                    case "btnApp2":
                        AppXml = doc.SelectSingleNode(@"dataCol/App2");
                        break;
                    case "btnApp3":
                        AppXml = doc.SelectSingleNode(@"dataCol/App3");
                        break;
                    case "btnApp4":
                        AppXml = doc.SelectSingleNode(@"dataCol/App4");
                        break;
                    case "btnApp5":
                        AppXml = doc.SelectSingleNode(@"dataCol/App5");
                        break;
                    case "btnApp6":
                        AppXml = doc.SelectSingleNode(@"dataCol/App6");
                        break;
                    default:
                        break;
                   }
                return AppXml;
              }
            else
            {
                return null;
            }

          
        }

            
        /// <summary>
        /// 获得对话框内打开的应用的路径
        /// </summary>


        /// <summary>
        /// 仅获得程序名称
        /// </summary>
     
      /// <summary>
      /// 删除快捷应用的方法
      /// </summary>
      /// <param name="curBtn"><获取当前删除应用的按钮/param>
      /// <returns>如果删除成功，那么返回true，否则返回false</returns>
        public bool DeleteAPP(Button curBtn)
        {
            if (File.Exists("data.xml"))
            {
            
                doc.Load("data.xml");

                GetBtnXML(curBtn).InnerText = null;
                doc.Save("data.xml");
                Voice OpenVoice = Voice.GetInstance();
                OpenVoice.TextToVoice("Delete successfully");

                return true;
            }
            else
            {
                return false;
            }
           
        }

 /// <summary>
 /// 显示应用图标
 /// </summary>
 /// <param name="btnlist">按钮控件数组</param>
    public void SetIcomn(Button[] btnlist)
        {
            doc.Load("data.xml");
            for (int i = 0; i < btnlist.Length; i++)
            {
                try
                {
                    if (doc.SelectSingleNode("dataCol/App" + (i + 1).ToString()).InnerText!="")
                    {
                        btnlist[i].Image = (GetExeIcon.GetIcon(doc.SelectSingleNode("dataCol/App" + (i + 1).ToString()).InnerText, true)).ToBitmap();
                    }
                    else
                    {
                        
                        btnlist[i].Image = Image.FromFile(@"assets\NoAPP.png");
                      
                    }
                    
                }
                catch
                {
                  
                }
            


                }
        }

        /// <summary>
        /// 打开APP的方法
        /// </summary>
        /// <param name="curbtn">打开应用的按钮控件</param>
        /// <returns>如果可以打开,返回true，否则返回false</returns>
        public bool OpenApp(Button curbtn)
        {
            doc.Load("data.xml");
            string exePath = GetBtnXML(curbtn).InnerText;
            string exename = Path.GetFileNameWithoutExtension(exePath);
            try
            {
                if (exePath == "")
                {
                    return false;
                }
                else
                {
                    ProcessStartInfo psi = new ProcessStartInfo(exePath);
                    Process.Start(psi);
                    Voice OpenVoice = Voice.GetInstance();
                    OpenVoice.TextToVoice("Openning" + exename+"please waiting");
                    return true;
                }
            }
            catch
            {
                
                return false;
            }
        }

        //单例模式
        private SetQuickApp() { }
        private static SetQuickApp getinstance = null;
        public static SetQuickApp GetInstace()
        {
            getinstance = new SetQuickApp();
            return getinstance;
        }
  
    }
}
