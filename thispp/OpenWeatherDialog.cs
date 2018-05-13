using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingQuickSetup
{
    public partial class OpenWeatherDialog : Form
    {
        public OpenWeatherDialog()
        {
            InitializeComponent();
        }


        public delegate void SendWeatherCityEventHandler(object sender, CitySendArgs e);
        public event SendWeatherCityEventHandler SendWeatherCity;

        private void btnCityOk_Click(object sender, EventArgs e)
        {
            if (SendWeatherCity!=null)
            {
               
                SendWeatherCity(sender, new CitySendArgs(txtCityName.Text));
            }
        }

        private void OpenWeatherDialog_Load(object sender, EventArgs e)
        {

            this.Location = new Point(Control.MousePosition.X, Control.MousePosition.Y);
        }
    }

    public class CitySendArgs:EventArgs
    {
       

        public CitySendArgs(string txt)
        {
            this.Name = txt;
        }


        string _name;
        /// <summary>
        /// 查询城市的名称
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

       
    }
}
