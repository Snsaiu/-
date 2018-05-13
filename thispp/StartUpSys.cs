using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;
using System.IO;
using System.Windows.Forms;


namespace programmingQuickSetup
{
    class StartUpSys
    {

        /// <summary>
        /// 创建快捷方式
        /// </summary>
        public void ShortCutAndStartUp()
        {
            //获取当前系统用户启动目录
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            //获得当前系统用户桌面目录
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
          
            FileInfo fileStartUp = new FileInfo(startupPath + "\\QuickStartUp.ink");
            FileInfo fileDeskTop = new FileInfo(desktopPath + "\\QuickStartUp.ink");

           
                if (!fileDeskTop.Exists)
                {
                     WshShell shell = new WshShell();
                //   MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));

                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(desktopPath + "\\"+"hello.ink");
                                
                    shortcut.TargetPath = Application.StartupPath + "\\"+"programmingQuickSetup.exe";
                    shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                    shortcut.WindowStyle = 1;
                    shortcut.Description = "快捷启动";
                    shortcut.IconLocation = Application.ExecutablePath;
                    shortcut.Save();
                }

                if (!fileStartUp.Exists)
                {
                    string exdir = desktopPath + "\\QuickStartUp.ink";
                    System.IO.File.Copy(exdir, startupPath + "\\QuickStartUp.ink", true);
                }
    
          

           }

            

        /// <summary>
        /// 删除快捷方式
        /// </summary>
        public void DelStartUp()
        {
            FileInfo startInk = new FileInfo(Environment.SpecialFolder.Startup + "\\QuickStartUp.ink");
            if (startInk.Exists)
            {
                System.IO.File.Delete(Environment.SpecialFolder.Startup+ "\\QuickStartUp.ink");
            }
        }

    }


  
}
