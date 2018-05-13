using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingQuickSetup
{

   

    enum DayEnum
    {
        明天,后天,大后天
    }
    enum DayAverEnum
    {
        上午,下午,中午,夜晚,凌晨
    }
 
    class RemindInfo
    {
        static bool _isHidder=true;
        string _text;
        string _tailText;
        string _headText;
        int _indexSplit;
        string _getDayTimeDura;//获取一天中的时间段
        string _getDayName;//获得哪天,类似于后天
        int _getMonth;//获得月份
        int _getDay;//获得具体几号（日）
        int _getHour;//获得具体小时，几点
        int _getMinute;//获得具体分钟
        int _getSecond;//获得具体秒数，无效

        bool _hasMonth;//获取是否写入了月份
        bool _hasDay;//获取是否写入了具体天数
        bool _hasHour;//获取是否写入了具体小时
        bool _hasMinute;//获取是否写入了具体分钟数
        bool _hasDayName;//获取是否写入了明天后天大后天
        bool _hasDayTimeDura;//获取是否写入了上午中午下午晚上
                             /// <summary>
                             /// 构造函数，进行文本的分割与关键字的重新定义
                             /// </summary>
                             /// <param name="text">获取用户输入的文本内容</param>



      
        public RemindInfo(string text)
        {
            try
            {
                RemindInfo.IsHidder = true;
                this.Text = text;

               
                this.IndexSplit = this.Text.IndexOf("提醒");
                this.HeadText = this.Text.Substring(0, this.IndexSplit);
                this.HeadText = this.HeadText.Replace('时', '点');
                this.HeadText = this.HeadText.Replace('号', '日');
                this.HeadText = this.HeadText.Replace("晚上", "夜晚");
                this.HeadText = this.HeadText.Replace("夜里", "夜晚");
                this.HeadText = this.HeadText.Replace("早上", "上午");
                this.TailText = this.Text.Substring(this.IndexSplit);
                if (this.HeadText.Contains("年"))
                {
                    int x = this.HeadText.IndexOf("年");
                    this.HeadText = this.HeadText.Substring(x+1);

                }
            }
            catch
            {
                RemindInfo.IsHidder = false;
                MessageBox.Show("文字初始解析的时候发生了错误！请优化你的内容后重新输入！如果仍然有错误，请将您输入的内容告诉给开发者！");
                
                

            }
        }
      
      
        /// <summary>
        /// 源文本信息
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }

        }
        /// <summary>
        /// 由源文本提取出的提醒的内容
        /// </summary>
        public string TailText
        {
            get
            {
                return _tailText;
            }

            set
            {
                _tailText = value;
            }
        }
        /// <summary>
        /// 由源文本提取出的时间点
        /// </summary>
        public string HeadText
        {
            get
            {
                return _headText;
            }

            set
            {
                _headText = value;
            }
        }
        /// <summary>
        /// 获取源文本提取出的时间点的末尾字符的序列号
        /// </summary>
        public int IndexSplit
        {
            get
            {
                return _indexSplit;
            }

            set
            {
                _indexSplit = value;
            }
        }
        /// <summary>
        /// 获取时间点的月份
        /// </summary>
        public int GetMonth
        {
            get
            {
               
               return _getMonth;
            }

            set
            {
                _getMonth = value;
            }
        }
        /// <summary>
        /// 获取时间点的~日
        /// </summary>
        public int GetDay
        {
            get
            {
                return _getDay;
            }

            set
            {
                _getDay = value;
            }
        }
        /// <summary>
        /// 获取时间点的分钟
        /// </summary>
        public int GetMinute
        {
            get
            {
                return _getMinute;
            }

            set
            {
                _getMinute = value;
            }
        }
        /// <summary>
        /// 获取秒数，没有相关数据，禁止使用
        /// </summary>
        public int GetSecond
        {
            get
            {
                return _getSecond;
            }

            set
            {
                _getSecond = value;
            }
        }
        /// <summary>
        /// 获得明天 后天 大后天
        /// </summary>
        public string GetDayName
        {
            get
            {
                return _getDayName;
            }

            set
            {
                _getDayName = value;
            }
        }
        /// <summary>
        /// 获取一天的早中午
        /// </summary>
        public string GetDayTimeDura
        {
            get
            {
                return _getDayTimeDura;
            }

            set
            {
                _getDayTimeDura = value;
            }
        }
        /// <summary>
        /// 获取小时
        /// </summary>
        public int GetHour
        {
            get
            {
                return _getHour;
            }

            set
            {
                _getHour = value;
            }
        }
        /// <summary>
        /// 判断文本中是否存在~月
        /// </summary>
        public bool HasMonth
        {
            get
            {
                return _hasMonth;
            }

            set
            {
                _hasMonth = value;
            }
        }
        /// <summary>
        /// 判断文本中是否存在~日
        /// </summary>
        public bool HasDay
        {
            get
            {
                return _hasDay;
            }

            set
            {
                _hasDay = value;
            }
        }
        /// <summary>
        /// 判断文本中是否存在~时
        /// </summary>
        public bool HasHour
        {
            get
            {
                return _hasHour;
            }

            set
            {
                _hasHour = value;
            }
        }
        /// <summary>
        /// 判断文本中是否存在~分
        /// </summary>
        public bool HasMinute
        {
            get
            {
                return _hasMinute;
            }

            set
            {
                _hasMinute = value;
            }
        }
        /// <summary>
        /// 获取是否写入了明天后天大后天
        /// </summary>
        public bool HasDayName
        {
            get
            {
                return _hasDayName;
            }

            set
            {
                _hasDayName = value;
            }
        }
        /// <summary>
        /// 获取是否写入了上午中午下午晚上
        /// </summary>
        public bool HasDayTimeDura
        {
            get
            {
                return _hasDayTimeDura;
            }

            set
            {
                _hasDayTimeDura = value;
            }
        }

        public static bool IsHidder
        {
            get
            {
                return _isHidder;
            }

            set
            {
                _isHidder = value;
            }
        }




        //method
        /// <summary>
        /// 判断是否存在DayAverEnum中的一个
        /// </summary>

        public void condition01()
        {
            try
            {
                if (this.HeadText.Contains(DayEnum.明天.ToString()) || this.HeadText.Contains(DayEnum.后天.ToString()) || this.HeadText.Contains(DayEnum.大后天.ToString()))
                {
                    this.HasDayName = true;
                    condition01_1(this.HeadText);
                    return;
                }

                else
                {
                    condition02(this.HeadText);
                }
            }
            catch
            {
                if (MessageBox.Show("这个错误可能继承于构造函数！尝试优化你的内容并重新输入！")==DialogResult.OK)
                {
                    RemindInfo.IsHidder = true;
                }  
                
            }
        }
        /// <summary>
        /// 判断语句是否存在指定月与日
        /// </summary>
        private void condition02(string headContent)
        {
            bool hasMonth = headContent.Contains("月");
            bool hasDate = headContent.Contains("日");
            this.HasMonth = hasMonth;
            this.HasDay = hasDate;
            if (hasMonth&&hasDate)
            {
              
                for (int i = 1; i <= 12; i++)
                {
                    for (int j = 1; j <= 31; j++)
                    {
                        string tempDate = i.ToString() + "月" + j.ToString() + "日";
                        if (headContent.Contains(tempDate))
                        {

                            //
                            condition02_2(headContent);                      
                            return;
                        }
                    }

                }
            }

            else
            {
                condition03(headContent);
            }
           
        
        }
        /// <summary>
        /// 判断语句中是否存在DayAverEnum中的一个
        /// </summary>
        private void condition03(string headContent)
        {
            if (headContent.Contains(DayAverEnum.上午.ToString())|| headContent.Contains(DayAverEnum.下午.ToString())|| headContent.Contains(DayAverEnum.中午.ToString())|| headContent.Contains(DayAverEnum.凌晨.ToString())|| headContent.Contains(DayAverEnum.夜晚.ToString()))
            {

                this.HasDayTimeDura = true;
               condition03_3(headContent);
            }
            else
            {
                condition04(headContent);
            }
        }
        /// <summary>
        /// 判断当前语句是否存在~点~分
        /// </summary>
        private void condition04(string headContent)
        {

            bool HasHour = headContent.Contains("点");
            bool HasMinute = headContent.Contains("分");
            this.HasHour = HasHour;
            this.HasMinute = HasMinute;
            if (HasHour&&HasMinute)
            {
                for (int i = 0; i < 24; i++)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        string TempTime = i.ToString() + "点" + j.ToString() + "分";
                        if (headContent.Contains(TempTime))
                        {

                            conditon04_4(headContent);
                            return;
                        }
                    }
                }
            }


            condition05(headContent);
        }
        /// <summary>
        /// 判断语句是否存在~点
        /// </summary>
        private void condition05(string headContent)
        {
            bool HasHour = headContent.Contains("点");
            this.HasHour = HasHour;
            if (HasHour)
            {
                for (int i = 0; i < 24; i++)
                {
                    string TempHour = i.ToString() + "点";
                    if (headContent.Contains(TempHour))
                    {

                        condition05_5(headContent);
                        return;
                    }
                }
            }
            else
            {
                condition06(headContent);
            }
        }
        /// <summary>
        /// 第一轮最后判断 语句中是否存在~分
        /// </summary>
        private void condition06(string headContent)
        {
            bool HasMinute = headContent.Contains("分钟后");
            this.HasMinute = HasMinute;
            if (HasMinute)
            {
                for (int i = 0; i < 60; i++)
                {
                    string TempMinute = i.ToString() + "分钟后";
                    if (headContent.Contains(TempMinute))
                    {
                        condition06_6(headContent);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("抱歉，当前我的智商并不能愉快的判断何时提醒您！");
            }
        }
        /// <summary>
        /// 第二轮判断，获取具体哪天
        /// </summary>
        private void condition01_1(string headContent)
        {
            int TempDate = headContent.IndexOf('天');
            this.GetDayName = headContent.Substring(0, TempDate + 1);//获得哪天
                                                                     //判断后面是否还有时间提示，如果还有着执行else，否则提示警告
            headContent = headContent.Substring(TempDate + 1);
            if (headContent == "")
            {
                MessageBox.Show("抱歉，当前我的智商并不能愉快的判断何时提醒您！");
                return;
            }
            else
            {
                //判断中午
                condition03(headContent);

                //need method
    }
}
        /// <summary>
        /// 第二轮判断，获取具体月份与日，并进入下一个判断
        /// </summary>
        private void condition02_2(string headContent)
        {
            string[] TempArrStr = headContent.Split(new char[] { '月', '日' }, StringSplitOptions.RemoveEmptyEntries);
            this.GetMonth =Convert.ToInt32(TempArrStr[0]);
            this.GetDay = Convert.ToInt32(TempArrStr[1]);
            int TempDate = headContent.IndexOf('日');
            headContent = headContent.Substring(TempDate + 1);
            if (headContent=="")
            {
                MessageBox.Show("抱歉，当前我的智商并不能愉快的判断何时提醒您！");
                return;
            }
            else
            {
                //判断时间
                /////////////////
                //判断早上中午
                condition03(headContent);

                //need method
    }
}
        /// <summary>
        /// 第二轮判断，获取一天中的时间段，并进入下一个判断
        /// </summary>
        private void condition03_3(string headContent)
        {
            int TempDate = 0;
            if (this.HeadText.Contains('午'))
            {
                 TempDate = headContent.IndexOf('午');
                this.GetDayTimeDura = headContent.Substring(0, TempDate + 1);//获得一天中的时间段
                                                                             //判断后面是否还有时间提示，如果还有执行else，否则提示警告
                headContent = headContent.Substring(TempDate + 1);
                if (headContent == "")
                {
                    MessageBox.Show("抱歉，当前我的智商并不能愉快的判断何时提醒您！");

                    return;
               
                }
                else
                {
                    //获得具体时间
                    condition04(headContent);
                    //need method
                }
            }
            else if (headContent.Contains('晨'))
            {
                TempDate = headContent.IndexOf('晨');
                this.GetDayTimeDura = headContent.Substring(0, TempDate + 1);//获得一天中的时间段
                                                                             //判断后面是否还有时间提示，如果还有执行else，否则提示警告
                                                                           
                headContent = headContent.Substring(TempDate + 1);
                if (headContent == "")
                {
                    MessageBox.Show("抱歉，当前我的智商并不能愉快的判断何时提醒您！");
                    return;
                }
                else
                {
                    //获得具体时间
                    condition04(headContent.Substring(TempDate + 1));
                    //need method
                }
            }
            else 
            {
                TempDate = headContent.IndexOf('晚');
                this.GetDayTimeDura = headContent.Substring(0, TempDate + 1);//获得一天中的时间段
                //判断后面是否还有时间提示，如果还有执行else，否则提示警告
                headContent = headContent.Substring(TempDate + 1);
                if (headContent == "")
                {
                    MessageBox.Show("抱歉，当前我的智商并不能愉快的判断何时提醒您！");
                    return;
                }
                else
                {
                    condition04(headContent);
                    //need method
                }
            }
        }
        /// <summary>
        /// 第二轮判断，获取具体时间点
        /// </summary>
        private void conditon04_4(string headContent)
        {
            string[] TempArrStr = headContent.Split(new char[] { '点', '分' }, StringSplitOptions.RemoveEmptyEntries);
            this.GetHour = Convert.ToInt32(TempArrStr[0]);
            this.GetMinute= Convert.ToInt32(TempArrStr[1]);
            int TempDate = headContent.IndexOf('分');         
        }
        /// <summary>
        /// 第二轮判断，获取具体~时。此判断终结
        /// </summary>
        private void condition05_5(string headContent)
        {
            string[] TempArrStr = headContent.Split(new char[] { '点' });
            this.GetHour = Convert.ToInt32(TempArrStr[0]);
        }
        /// <summary>
        ///第二轮判断  获取分钟，判断终结
        /// </summary>
        /// <param name="headContent"></param>
        private void condition06_6(string headContent)
        {
            string[] TempArrStr = headContent.Split(new char[] { '分' });
            this.GetMinute = Convert.ToInt32(TempArrStr[0]);
        }
    }
}
