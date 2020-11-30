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
            axWindowsMediaPlayer.uiMode = "None";
            axWindowsMediaPlayer.settings.autoStart = false;
        }

        //3. Implementation of the subscription
        public void Subscription(WMPLib.IWMPPlaylist playlist01)
        {
            axWindowsMediaPlayer.currentPlaylist = playlist01;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }
    }
}
