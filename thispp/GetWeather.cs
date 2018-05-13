using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace programmingQuickSetup
{
    class GetWeather
    {
        string _getclound;//获取今天天气是阴天还是多云
        string _gettemperature;//获取今天天气温度
        bool _canParse;//是否能正确解析结果
        /// <summary>
        /// 获取明天天气
        /// </summary>
        public string GetTomCloud { get; set; }
        Weather.WeatherWebService weather = new Weather.WeatherWebService();

        /// <summary>
        /// 获取今天天气是阴天还是多云
        /// </summary>
        public string Getclound
        {
            get
            {
                return _getclound;
            }

            set
            {
                _getclound = value;
            }
        }
        /// <summary>
        /// 获取今天天气温度
        /// </summary>
        public string Gettemperature
        {
            get
            {
                return _gettemperature;
            }

            set
            {
                _gettemperature = value;
            }
        }
        /// <summary>
        /// 是否能将地址正确解析
        /// </summary>
        public bool CanParse
        {
            get
            {
                return _canParse;
            }

            set
            {
                _canParse = value;
            }
        }

  
        public void  getWeather(string city)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            try
            {
                string[] weatherInfo = new string[22];
                weatherInfo = weather.getWeatherbyCityName(city);
                this.Getclound = weatherInfo[6];
                this.Gettemperature = weatherInfo[5];
               doc.SelectSingleNode("dataCol/TomCityWeather").Attributes["weather"].Value = weatherInfo[13];
                doc.Save("data.xml");
                this.CanParse = true;
            }
            catch
            {
                this.CanParse = false;
            }
        }
    }
}
