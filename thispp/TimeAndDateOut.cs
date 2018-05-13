using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace programmingQuickSetup
{
    class TimeAndDateOut
    {
        string _saveDate;//用于保存日期
        RemindInfo _remindinfo;
        TimeCondition _timeconditon;
        string _outtext;//提醒文本
        private int NewHour { get; set; }//获取用户~时
        private int NewMinute { get; set; }//获取用户~分
        private int NewMonth { get; set; }//获取用户~月
        private int NewDay { get; set; }//获取用户~日

        //存储用户定义的时间
        /// <summary>
        /// 获取提醒事件的对象
        /// </summary>
        internal RemindInfo Remindinfo
        {
            get
            {
                return _remindinfo;
            }

            set
            {
                _remindinfo = value;
            }
        }
        /// <summary>
        /// 获得时间判断结果
        /// </summary>

        string _filename;//文件保存路径名称,相对路径
        internal TimeCondition Timeconditon
        {
            get
            {
                return _timeconditon;
            }

            set
            {
                _timeconditon = value;
            }
        }
        /// <summary>
        /// 用于保存日期
        /// </summary>
        public string SaveDate
        {
            get
            {
                return _saveDate;
            }

            set
            {
                _saveDate = value;
            }
        }

        public string Filename
        {
            get
            {
                return _filename;
            }

            set
            {
                _filename = value;
            }
        }

        public string Outtext
        {
            get
            {
                return _outtext;
            }

            set
            {
                _outtext = value;
            }
        }

        /// <summary>
        /// 构造函数  并判断格式是否正确
        /// </summary>
        /// <param name="remindinfo"></param>
        /// <param name="timeconditon"></param>
        public TimeAndDateOut(RemindInfo remindinfo,TimeCondition timeconditon)
        {
            //if (this.Timeconditon.IsSafeDay==true&& this.Timeconditon.IsSafeGetDayNameToNumber==true&& this.Timeconditon.IsSafeHour==true&& this.Timeconditon.IsSafeMinute==true&& this.Timeconditon.IsSafeMonth==true)
            //{

         
            this.Remindinfo = remindinfo;
            this.Timeconditon = timeconditon;
          //  }
            //else
            //{
            //    MessageBox.Show("文本解析最后一步出现了错误，请优化你的文本并重新键入");
            //}
        }

      
        public void GetFullDate()
        {
            #region 存入月份

            if (this.Remindinfo.HasDayName == false)
            {

         
             if (this.Remindinfo.HasMonth==true)
             {
               this.NewMonth = this.Remindinfo.GetMonth;
             }
            else
            {
                this.NewMonth = DateTime.Now.Month;
            }
            #endregion

            #region 存入~日
            if (this.Remindinfo.HasDay==true)
            {
                
                this.NewDay = this.Remindinfo.GetDay;
            }
            else
            {

                    this.NewDay = DateTime.Now.Day;
            }
            }
            #endregion
            else
            {

                DateTime dt = new DateTime();
                dt = DateTime.Now.AddDays(this.Timeconditon.GetDayNameToNumber);
                this.NewMonth = dt.Month;
                this.NewDay = dt.Day;
            }


            #region 存入~时  小时为true 分钟为false的情况 分钟为0
             if (this.Remindinfo.HasHour==true)
            {
                this.NewHour= this.Remindinfo.GetHour;
                if (this.Remindinfo.HasMinute==true)
                {
                    this.NewMinute= this.Remindinfo.GetMinute;
                }
                else
                {
                  this.NewMinute =0;
                }
                
            }
            else
            {
                
                if (this.Remindinfo.HasMinute == true)
                {
                 int fullMinutes= this.Remindinfo.GetMinute + DateTime.Now.Minute;
                    if (fullMinutes>=60)
                    {

                        int addHour = DateTime.Now.Hour + (fullMinutes / 60);
                       this.NewHour= addHour;
                       this.NewMinute= (fullMinutes % 60);
                    }
                    else
                    {
                       this.NewHour= DateTime.Now.Hour;
                        this.NewMinute = fullMinutes;
                    }
                }
                else
                {
                    this.NewMinute= DateTime.Now.Minute;
                }
            }
            #endregion


            if (DateTime.Now.Day==this.NewDay&&this.NewHour<DateTime.Now.Hour)
            {
                // this.NewDay += 1;
                this.NewHour += 12;
            }



            //if (this.Remindinfo.HasHour==false)
            //{
            //    return;
            //}
            if (this.NewMonth==DateTime.Now.Hour&&this.NewMinute<DateTime.Now.Minute&&this.Timeconditon.IsSafeGetDayNameToNumber==false)
            {
                this.Outtext = "您让我提醒的时间已经过去了！您需要检查分针！";
                return;
            }
            //if ( this.NewHour < DateTime.Now.Hour)
            //{
            //    this.Outtext = "您让我提醒的时间已经过去了！您需要检查时针！";
            //    return;
            //}

            DateTime saveTime = new DateTime(DateTime.Now.Year, this.NewMonth, this.NewDay, this.NewHour, this.NewMinute,0);

            if (saveTime.TimeOfDay<DateTime.Now.TimeOfDay&&saveTime.Date<=DateTime.Now.Date)
            {
                this.Outtext = "您让提醒的时间已经过去了";
                return;
            }

            if (this.Remindinfo.HasHour==false&&this.Remindinfo.HasMinute==false)
            {
                this.Outtext = "时间模糊无法提醒！";
                return;
            }

            this.SaveDate = saveTime.Year.ToString() +"."+ saveTime.Month.ToString() + "." + saveTime.Day.ToString() + "." + saveTime.Hour.ToString() + "." + saveTime.Minute.ToString()+ "." + saveTime.Second.ToString();
            string path = this.SaveDate + ".txt";

            string content = this.Remindinfo.TailText;
            if (content.Contains("提醒我"))
            {
               content= content.Remove(0, 3);
            }
            else
            {
                content = content.Remove(0, 2);
            }
            content = "提醒您:" + content.Replace("我", "您");

            this.Outtext = "我会在" + saveTime.Month.ToString() + "月" + saveTime.Day.ToString() + "日" + saveTime.Hour.ToString() + "点" + saveTime.Minute.ToString() + "分" + content + "!";

            // this.Outtext = "您让我在今天" + DateTime.Now.Hour + "点" + DateTime.Now.Minute + "分" + content + "!" + "现在时间到了！";

            //保存文件并写入提醒文本
            if ( !Directory.Exists(Application.StartupPath+"\\"+"RemindFile"))
            {
              Directory.CreateDirectory(Application.StartupPath + "\\" + "RemindFile");
                using (StreamWriter sw=new StreamWriter(Application.StartupPath + "\\" + "RemindFile"+"\\"+SaveDate+".txt"))
                {
                    sw.Write("您让我在今天" + DateTime.Now.Hour + "点" + DateTime.Now.Minute + "分" + content + "!" + "现在时间到了！");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "RemindFile" + "\\" + SaveDate + ".txt"))
                {
                    sw.Write("您让我在今天" + DateTime.Now.Hour + "点" + DateTime.Now.Minute + "分" + content + "!" + "现在时间到了！");
                }
            }
           

        }
     
        
       
    }
}
