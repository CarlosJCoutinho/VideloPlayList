using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideloPlayList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //3. Implementation of the subscription
        public void Subscription(string string01, WMPLib.IWMPPlaylist playlist01)
        {
            textBox1.Text = string01;
            axWindowsMediaPlayer.currentPlaylist = playlist01;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }
    }
}
