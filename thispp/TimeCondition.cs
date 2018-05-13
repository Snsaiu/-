using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingQuickSetup
{
    class TimeCondition
    {

        RemindInfo _rInfo;
        bool _isSafeHour;//判断小时是否正确
        bool _isSafeDay;//判断天数
        bool _isSafeMonth;//判断月份是否正确
        bool _isSafeMinute;//判断分钟是否正确
        bool _isSafeGetDayNameToNumber;//判断明天后天等是否转化成数字
        int _getDayNameToNumber;//将明天后天等转化成数字

        /// <summary>
        /// 构造函数，获取提醒对象
        /// </summary>
        /// <param name="rlnfo">提醒的对象</param>
        public TimeCondition(RemindInfo rlnfo)
        {
            this.RInfo = rlnfo;
            ParseInfo();
        }
 
        internal RemindInfo RInfo
        {
            get
            {
                return _rInfo;
            }

            set
            {
                _rInfo = value;
            }
        }

 
        /// <summary>
        /// 判断是否~日是否正确
        /// </summary>
        public bool IsSafeDay
        {
            get
            {
                return _isSafeDay;
            }

            set
            {
                _isSafeDay = value;
            }
        }
        /// <summary>
        /// 判断小时是否正确转化
        /// </summary>
        public bool IsSafeHour
        {
            get
            {
                return _isSafeHour;
            }

            set
            {
                _isSafeHour = value;
            }
        }
        /// <summary>
        /// 判断月份是否正确
        /// </summary>
        public bool IsSafeMonth
        {
            get
            {
                return _isSafeMonth;
            }

            set
            {
                _isSafeMonth = value;
            }
        }
        /// <summary>
        /// 判断分钟是否正确
        /// </summary>
        public bool IsSafeMinute
        {
            get
            {
                return _isSafeMinute;
            }

            set
            {
                _isSafeMinute = value;
            }
        }
        /// <summary>
        /// 获取明天后天大后天转化后的数字
        /// </summary>
        public int GetDayNameToNumber
        {
            get
            {
                return _getDayNameToNumber;
            }

            set
            {
                _getDayNameToNumber = value;
            }
        }
        /// <summary>
        /// 判断是否将明天后天大后天转化成1，2，3
        /// </summary>
        public bool IsSafeGetDayNameToNumber
        {
            get
            {
                return _isSafeGetDayNameToNumber;
            }

            set
            {
                _isSafeGetDayNameToNumber = value;
            }
        }

        /// <summary>
        /// 判断时间
        /// </summary>
   
        public void ParseInfo()
        {

            #region 将明天后天等转成具体数字 并返回Bool
            if (this.RInfo.HasDayName)
            {

   
            switch (this.RInfo.GetDayName)
            {
                case "明天":
                    this.GetDayNameToNumber = 1;
                    this.IsSafeGetDayNameToNumber = true;
                    break;
                case "后天":
                    this.GetDayNameToNumber = 2;
                    this.IsSafeGetDayNameToNumber = true;
                    break;
                case "大后天":
                    this.GetDayNameToNumber = 3;
                    this.IsSafeGetDayNameToNumber = true;
                    break;
                default:
                    this.IsSafeGetDayNameToNumber = false;
                    break;
            }
            }
            #endregion

            #region 判断上下午时差是否相等
            if (this.RInfo.HasHour)
            {

         
            if (this.RInfo.GetHour>=0&&this.RInfo.GetHour<24)
            {

          
            if ((this.RInfo.GetDayTimeDura==DayAverEnum.上午.ToString()||this.RInfo.GetDayTimeDura==DayAverEnum.中午.ToString()|| this.RInfo.GetDayTimeDura==DayAverEnum.凌晨.ToString()) )
            {
                if (this.RInfo.GetHour>=13)
                {
                    this.IsSafeHour = false;
                }
            }
            if(this.RInfo.GetDayTimeDura==DayAverEnum.下午.ToString()|| this.RInfo.GetDayTimeDura==DayAverEnum.夜晚.ToString())
            {
                if (this.RInfo.GetHour<13)
                {
                    this.RInfo.GetHour += 12;
                }
            }
          
            }
            else
            {
                this.IsSafeHour = false;
            }
            }
            #endregion
            #region 判断分钟是否正确
        
            if (this.RInfo.HasMinute)
            {

        
            if (this.RInfo.GetMinute<0||this.RInfo.GetMinute>60)
            {
                this.IsSafeMinute = false;
            }
            }
            #endregion
            #region 判断月份与日期
                
            if (this.RInfo.GetMonth>=13)
            {
                this.IsSafeMonth = false;
            }
            else
            {
                #region 判断月份与日期是否匹配
                //判断月份
                switch (this.RInfo.GetMonth)
                {
                    case 1:
                        if (this.RInfo.GetDay >= 32)
                        {
                            this.IsSafeDay = false;
                        }
                        break;

                    case 3:
                        if (this.RInfo.GetDay >= 32)
                        {
                            this.IsSafeDay = false;
                        }
                        break;

                    case 5:
                        if (this.RInfo.GetDay >= 32)
                        {
                            this.IsSafeDay = false;
                        }
                        break;
                    case 7:
                        if (this.RInfo.GetDay >= 32)
                        {
                            this.IsSafeDay = false;
                        }
                        break;
                    case 8:
                        if (this.RInfo.GetDay >= 32)
                        {
                            this.IsSafeDay = false;
                        }
                        break;
                    case 10:
                        if (this.RInfo.GetDay >= 32)
                        {
                            this.IsSafeDay = false;
                        }
                        break;
                    case 12:
                        if (this.RInfo.GetDay >= 32)
                        {
                            this.IsSafeDay = false;
                        }
                        break;

                    case 4:
                        if (this.RInfo.GetDay >= 31)
                        {
                            this.IsSafeDay = false;
                        }
                        break;
                    case 6:
                        if (this.RInfo.GetDay >= 31)
                        {
                            this.IsSafeDay = false;
                        }
                        break;
                    case 9:
                        if (this.RInfo.GetDay >= 31)
                        {
                            this.IsSafeDay = false;
                        }
                        break;
                    case 11:
                        if (this.RInfo.GetDay >= 31)
                        {
                            this.IsSafeDay = false;
                        }
                        break;

                    case 2:
                        if ((DateTime.Now.Year % 100 != 0) && (DateTime.Now.Year % 4 == 0) || (DateTime.Now.Year % 400 == 0))
                        {
                            if (this.RInfo.GetDay >= 30)
                            {
                                this.IsSafeDay = false;
                            }
                            break;
                        }
                        else
                        {
                            if (this.RInfo.GetDay >= 29)
                            {
                                this.IsSafeDay = false;
                            }
                            break;
                        }

                    default:
                        break;
                }
                #endregion
            }
            #endregion


        }

    }
}
