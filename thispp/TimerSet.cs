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
    public partial class TimerSet : Form
    {
        public TimerSet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void SendTimerNumberEventHandler(object sender, string e);
        public event SendTimerNumberEventHandler SendTimerNumber;

        private void TimerSet_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (txtTimerNum.Text=="")
            {
                return;
            }
            if (SendTimerNumber!=null)
            {
               
                SendTimerNumber(sender, txtTimerNum.Text);
            }
        }


        public class SendTimerNumberEvent:EventArgs
        {
            public string Time { get; set; }

            public SendTimerNumberEvent(object sender,string time)
            {
                this.Time = time;
            }
        }
    }
}
