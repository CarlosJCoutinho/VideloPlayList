using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;       //To make using the objects in the Player namespace easier, you should include the namespace in the using or imports directives of your files.
using System.IO;    //Manipulação do ficheiro

namespace VideloPlayList
{
    public partial class Form1 : Form
    {
        
        
        //1. Declare the delegate
        public delegate void Delegate01(WMPLib.IWMPPlaylist playlist01);

        //2. Create the delegate variable
        public Delegate01 delegate01;

        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer.uiMode = "None";   //Esconde os controlos nativos do Windows Media Player
            axWindowsMediaPlayerAlt.uiMode = "None";
            axWindowsMediaPlayer.settings.autoStart = false;
        }

        // Global variables
        WMPLib.IWMPPlaylist videoPlayList;
        Form2 form2 = null;
        Form2 openedForm = null;

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            openFileDialog.Title = "Abrir ficheiro de video";
            openFileDialog.Filter = "Todos os ficheiros de video (*.avi;*.mp4;*.wmv)|*.avi;*.mp4;*.wmv";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPlayList = axWindowsMediaPlayer.playlistCollection.newPlaylist("Lista de videos");
                foreach (var ficheiroVideo in openFileDialog.FileNames)
                {
                    i++;
                    textBoxForeach.Text = i.ToString();
                    videoPlayList.appendItem(axWindowsMediaPlayer.newMedia(ficheiroVideo));
                    listBox.Items.Add(ficheiroVideo);
                    axWindowsMediaPlayer.currentPlaylist = videoPlayList;
                    /*                    
                    axWindowsMediaPlayer.Ctlcontrols.play();
                    timer.Start();
                    */
                }
                axWindowsMediaPlayer.settings.playCount = 10000;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Verificação se a listbox já tem items
            if (listBox.Items.Count > 0)
            {
                saveFileDialog.Title = "Gravar playlist";
                saveFileDialog.Filter = "Ficheiro texto|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(saveFileDialog.FileName, false);
                    for (int i = 0; i < listBox.Items.Count; i++)
                    {
                        file.WriteLine(listBox.Items[i].ToString());
                    }
                    file.Close();
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Abrir o ficheiro da playlist";
            openFileDialog.Filter = "Ficheiro texto (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader ficheiro = new StreamReader(openFileDialog.FileName);
                while (ficheiro.Peek() != -1)
                {
                    listBox.Items.Add(ficheiro.ReadLine());
                }
                ficheiro.Close();
            }
            videoPlayList = axWindowsMediaPlayer.playlistCollection.newPlaylist("Lista de videos");
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                videoPlayList.appendItem(axWindowsMediaPlayer.newMedia(listBox.Items[i].ToString()));
                axWindowsMediaPlayer.currentPlaylist = videoPlayList;
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                axWindowsMediaPlayer.URL = listBox.SelectedItem.ToString();
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
            listBox.Items.Clear();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                form2 = new Form2();

                //4. Assign the delegate
                this.delegate01 += new Delegate01(form2.Subscription);
                form2.Show();

                //5. Call the delegate
                delegate01(videoPlayList);
                buttonOpenDisplay.Enabled = false;
                buttonCloseDisplay.Enabled = true;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.play();
            timer.Start();
        }

        private void axWindowsMediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
            // If the Player encounters a corrupt or missing file, 
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Abrir ficheiro de video";
            openFileDialog.Filter = "Todos os ficheiros de video (*.avi;*.mp4;*.wmv)|*.avi;*.mp4;*.wmv";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var ficheiroVideo in openFileDialog.FileNames)
                {
                    listBoxAlt.Items.Add(ficheiroVideo);
                }
            }
            textBoxNumberItems.Text = listBoxAlt.Items.Count.ToString();
        }

        private void buttonClearAlt_Click(object sender, EventArgs e)
        {
            listBoxAlt.Items.Clear();
        }

        private void buttonPlayAlt_Click(object sender, EventArgs e)
        {
            if (listBoxAlt.Items.Count > 0)
            {
                listBoxAlt.SetSelected(0, true);
                axWindowsMediaPlayerAlt.URL = listBoxAlt.SelectedItem.ToString();
                axWindowsMediaPlayerAlt.Ctlcontrols.play();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)axWindowsMediaPlayer.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
                labelDuration.Text = axWindowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString();
            }
            labelCurrentPosition.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
        }

        private void listBoxAlt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //timer.Start();
        }

        private void buttonStopAlt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerAlt.Ctlcontrols.stop();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerAlt.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
        }

        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
                this.axWindowsMediaPlayerAlt.Ctlcontrols.play();
        }

        private void buttonCloseDisplay_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                form2.Close();
                form2 = null;
                buttonOpenDisplay.Enabled = true;
                buttonCloseDisplay.Enabled = false;
            }
        }

        private void buttonOpenForm_Click(object sender, EventArgs e)
        {
            if (openedForm == null)
            {
                //There is no Form, so create and open it
                openedForm = new Form2();
                openedForm.Show();
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            if (openedForm != null)
            {
                //there is a form. So close and get rid of the reference
                openedForm.Close();
                openedForm = null;
            }
        }
    }
}
