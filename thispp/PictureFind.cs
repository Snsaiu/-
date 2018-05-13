using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace programmingQuickSetup
{
    class PictureFind
    {

        string _strpath;//保存文件夹路径
        /// <summary>
        /// 保存文件夹路径
        /// <summary>
        /// </summary>
        public string StrPath
        {
            get
            {
                return _strpath;
            }

            set
            {
                _strpath = value;
            }
        }
        /// <summary>
        /// 保存可以使用的图片路径与文件名
        /// </summary>
        public string[] CanOpenPicArr
        {
            get
            {
                return _CanOpenPicArr;
            }

            set
            {
                _CanOpenPicArr = value;
            }
        }
        /// <summary>
        /// 保存PNG格式文件
        /// </summary>
        public string[] PngFile { get; set; }
        // 保存可以使用的图片路径与文件名
        string[] _CanOpenPicArr;


        /// <summary>
        /// 构造函数  传入文件夹路径
        /// </summary>
        /// <param name="path"></param>
        public PictureFind(string path)
        {
            this.StrPath = path;//接受文件夹
        }
        /// <summary>
        /// 获取照片
        /// </summary>
        /// <returns>如果没有获取到照片，那么返回false，否则返回true</returns>
        public bool IsJpg()
        {

            if (this.StrPath == "")
            {
                return false;
            }
            else
            {
                string[] filename = Directory.GetFiles(this.StrPath,"*.PNG",SearchOption.AllDirectories);
               
                this.CanOpenPicArr = filename;
                return true;
            }

        }

        public bool IsPNG()
        {

            if (this.StrPath == "")
            {
                return false;
            }
            else
            {
                string[] filename = Directory.GetFiles(this.StrPath, "*.JPG", SearchOption.AllDirectories);

                this.PngFile = filename;
                return true;
            }
        }
    }


}
