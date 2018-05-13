using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingQuickSetup
{
    class HasAppRun
    {
        /// <summary>
        /// 存入要判断是否在运行的程序的名称
        /// </summary>
        public string Appname { get; set; }
        /// <summary>
        /// 构造函数，获取程序的名称
        /// </summary>
        /// <param name="appname"></param>
        public HasAppRun(string appname)
        {
            this.Appname = appname;
        }
        /// <summary>
        /// 判断当前程序是否在运行
        /// </summary>
        /// <returns>如果运行则返回true，否则返回false</returns>
        public bool ConDitionIsrun()
        {
            bool isrun = false;
            //获得当前程序的进程数，如果进程数为0那么该程序没有被运行，否则，则表示在运行
            Process[] myprocess = Process.GetProcessesByName(this.Appname);
            if (myprocess.Length==0)
            {
                isrun = false;
            }
            else
            {
                isrun = true;
            }
            return isrun;
        }
    }
}
