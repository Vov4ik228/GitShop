using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitShop
{
    public partial class MainForm : Form
    {
        private Timer _timerUpdateTime = new Timer();

        public MainForm()
        {
            InitializeComponent();
            myToolStrip_TimeNow.Text = DateTime.Now.ToLongTimeString();
            myToolStrip_UserStatusInfo.Text = "Login or registration please !!!";
            myToolStrip_UserStatusInfo.ForeColor = Color.Red;
            _timerUpdateTime.Enabled = true;
            _timerUpdateTime.Interval = 1000;
            _timerUpdateTime.Tick += TimerUpdateTime;
        }

        private void TimerUpdateTime(object sender, EventArgs e)
        {
            myToolStrip_TimeNow.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
