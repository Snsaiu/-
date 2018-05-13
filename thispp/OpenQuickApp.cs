using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace programmingQuickSetup
{
    class OpenQuickApp
    {


        string _filename;
        string _viewFileName;
        OpenFileDialog ofd = new OpenFileDialog();
        public void open()
        {
           
            ofd.Filter = "应用程序|*.exe|所有文件|*.*";
            ofd.Title = "Add Quick App";
            ofd.ShowDialog();
          
        }
            

        public string Filename
        {
            get
            {

                return ofd.FileName;
            }

            set
            {
                _filename = value;
            }
        }

        public string ViewFileName
        {
            get
            {
                return Path.GetFileNameWithoutExtension(ofd.FileName);
            }

            set
            {
                _viewFileName = value;
            }
        }
    }
}
