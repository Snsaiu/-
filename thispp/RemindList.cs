using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace programmingQuickSetup
{
   
    class RemindList
    {

        string[] filename;//获取提醒的文件名
        /// <summary>
        /// 获取提醒的文件名
        /// </summary>
        public string[] Filename
        {
            get
            {
                return filename;
            }

            set
            {
                filename = value;
            }
        }
        public RemindList()
        {
            this.Filename = Directory.GetFiles(Application.StartupPath + "\\" + "RemindFile");
        }

        // Dictionary<string, string> RemindListKV = new Dictionary<string, string>();
    
    }
}
