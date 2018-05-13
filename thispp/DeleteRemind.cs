using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingQuickSetup
{
    class DeleteRemind
    {
        public static void delete(int indexfile)
        {
            string[] filename = Directory.GetFiles(Application.StartupPath + "\\" + "RemindFile");
            File.Delete(filename[indexfile]);
        }
    }
}
