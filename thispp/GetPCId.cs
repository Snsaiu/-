using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net;
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
using System.Management;
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
using System.Windows.Forms;

namespace programmingQuickSetup
{
   
    class GetPCId
    {
        string _strHostName;
        string _strAddr;
       public GetPCId()
        {
            this.StrHostName = Dns.GetHostName();
          IPHostEntry ipEntry = Dns.GetHostByName(Dns.GetHostName());
            this.StrAddr = ipEntry.AddressList[0].ToString();

        }

        public string StrHostName
        {
            get
            {
                return _strHostName;
            }

            set
            {
                _strHostName = value;
            }
        }

        public string StrAddr
        {
            get
            {
                return _strAddr;
            }

            set
            {
                _strAddr = value;
            }
        }
        /// <summary>
        /// 获取机器名称
        /// </summary>
        /// <returns>返回机器名称</returns>
        public string GetHostName()
        {
            return "本机名称:\r\n" + System.Net.Dns.GetHostName();
        }

        /// <summary>
        /// 获得CPU名称
        /// </summary>
        /// <returns>返回Cpu名称</returns>
        public string GetCPUName()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject item in moc)
                {
                    return "CPU名称:\r\n" + item["Name"].ToString();
                }
                return "CPU名称无法获得";
            }
            catch 
            {

                return "CPU名称无法获得";
            }
        }
        /// <summary>
        /// 获得运行内存
        /// </summary>
        /// <returns>返回运行内存</returns>
        public string GetMemoryInfo()
        {
            try
            {
                ManagementClass mo = new ManagementClass("Win32_OperatingSystem");
                ManagementObjectCollection mjc = mo.GetInstances();
                foreach (ManagementObject item in mjc)
                {
                    return "运行内存:\r\n" + (Convert.ToDouble(item["TotalVisibleMemorySize"]) /1024/1024).ToString("0.00") + "GB";
                  //  return "运行内存:" + item["TotalVisibleMemorySize"].ToString() + "KB";
                }
                return "运行内存无法获得";
            }
            catch
            {
                return "运行内存无法获得";
            }
        }
        /// <summary>
        /// 获得GPU型号
        /// </summary>
        /// <returns>返回GPU型号</returns>
        public string GetGPUInfo()
        {
            ManagementObjectSearcher mos=new ManagementObjectSearcher("SELECT * FROM Win32_DisplayControllerConfiguration");
            foreach (ManagementObject item in mos.Get())
            {
                return "显卡名称:\r\n"+item["name"].ToString();
            }
            return "显卡信息无法获得";
        }
        
        public string GetSolutionInfo()
        {
            return "显示器分辨率:\r\n"+"宽:" + Screen.PrimaryScreen.Bounds.Width.ToString() + "   高:" + Screen.PrimaryScreen.Bounds.Height.ToString();
        }
        //
        /// <summary>
        /// 获取CPU温度
        /// </summary>
        /// <returns>返回当前CPU温度</returns>
        public static string GetCOUTem()
        {
            string str = "";

            ManagementObjectSearcher vManagementObjectSearcher = new ManagementObjectSearcher(@"root\WMI", @"select * from MSAcpi_ThermalZoneTemperature");
            foreach (ManagementObject managementObject in vManagementObjectSearcher.Get())
            {
                str += managementObject.Properties["CurrentTemperature"].Value.ToString();
            }
            float temp = (float.Parse(str) - 2732) / 10;

            return temp.ToString();
        }
    }
}
