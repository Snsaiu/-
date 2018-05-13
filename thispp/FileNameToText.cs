using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingQuickSetup
{
    class FileNameToText
    {
       /// <summary>
       /// 0：返回~年~日~时~分 1：返回清单文本事件 2：返回时间数字串 3：返回具体提醒事件
       /// </summary>
       /// <param name="fullpath"></param>
       /// <returns></returns>
          public static string[] NameToText(string fullpath)
        {
            //转化文件名
            string[] NameInfo = new string[4];
            string name = Path.GetFileNameWithoutExtension(fullpath);//获取到了文件名
            string[] splitname = name.Split(new char[] { '.'},StringSplitOptions.RemoveEmptyEntries);
            NameInfo[2] = splitname[0] + splitname[1] + splitname[2] + splitname[3] + splitname[4];//获得一串数字
            NameInfo[0] = splitname[0] + "年" + splitname[1] + "月" + splitname[2] + "日" + splitname[3] + "时" + splitname[4] + "分"; //将文件名转成时间文本

            //获取内容
            string RemindEvent = "";
            using (StreamReader sr=new StreamReader(fullpath))
            {
                RemindEvent = sr.ReadToEnd();
            }

            int head = RemindEvent.IndexOf(':');
            int tail = RemindEvent.IndexOf('!');
            NameInfo[1] = RemindEvent.Substring(head + 1, tail - head - 1);
            NameInfo[3] = RemindEvent;
            return NameInfo;

        }

    }
}
