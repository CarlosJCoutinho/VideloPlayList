namespace VideloPlayList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpenDisplay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerAlt = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxAlt = new System.Windows.Forms.ListBox();
            this.buttonClearAlt = new System.Windows.Forms.Button();
            this.buttonPlayAlt = new System.Windows.Forms.Button();
            this.textBoxNumberItems = new System.Windows.Forms.TextBox();
            this.textBoxCurrentItem = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonStopAlt = new System.Windows.Forms.Button();
            this.labelCurrentPosition = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonPlay2 = new System.Windows.Forms.Button();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.buttonOpen2 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxForeach = new System.Windows.Forms.TextBox();
            this.buttonCloseDisplay = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonOpenForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(512, 384);
            this.axWindowsMediaPlayer.TabIndex = 0;
            this.axWindowsMediaPlayer.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.axWindowsMediaPlayer_MediaError);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 402);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(512, 69);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 474);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(93, 474);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(174, 474);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(255, 474);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonOpenDisplay
            // 
            this.buttonOpenDisplay.Location = new System.Drawing.Point(432, 474);
            this.buttonOpenDisplay.Name = "buttonOpenDisplay";
            this.buttonOpenDisplay.Size = new System.Drawing.Size(92, 23);
            this.buttonOpenDisplay.TabIndex = 6;
            this.buttonOpenDisplay.Text = "Open Display";
            this.buttonOpenDisplay.UseVisualStyleBackColor = true;
            this.buttonOpenDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(93, 503);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(174, 503);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 503);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1024, 568);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(584, 474);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // axWindowsMediaPlayerAlt
            // 
            this.axWindowsMediaPlayerAlt.Enabled = true;
            this.axWindowsMediaPlayerAlt.Location = new System.Drawing.Point(584, 12);
            this.axWindowsMediaPlayerAlt.Name = "axWindowsMediaPlayerAlt";
            this.axWindowsMediaPlayerAlt.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerAlt.OcxState")));
            this.axWindowsMediaPlayerAlt.Size = new System.Drawing.Size(512, 384);
            this.axWindowsMediaPlayerAlt.TabIndex = 12;
            // 
            // listBoxAlt
            // 
            this.listBoxAlt.FormattingEnabled = true;
            this.listBoxAlt.Location = new System.Drawing.Point(584, 402);
            this.listBoxAlt.Name = "listBoxAlt";
            this.listBoxAlt.Size = new System.Drawing.Size(512, 69);
            this.listBoxAlt.TabIndex = 13;
            this.listBoxAlt.SelectedIndexChanged += new System.EventHandler(this.listBoxAlt_SelectedIndexChanged);
            // 
            // buttonClearAlt
            // 
            this.buttonClearAlt.Location = new System.Drawing.Point(665, 474);
            this.buttonClearAlt.Name = "buttonClearAlt";
            this.buttonClearAlt.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAlt.TabIndex = 14;
            this.buttonClearAlt.Text = "Clear";
            this.buttonClearAlt.UseVisualStyleBackColor = true;
            this.buttonClearAlt.Click += new System.EventHandler(this.buttonClearAlt_Click);
            // 
            // buttonPlayAlt
            // 
            this.buttonPlayAlt.Location = new System.Drawing.Point(746, 474);
            this.buttonPlayAlt.Name = "buttonPlayAlt";
            this.buttonPlayAlt.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayAlt.TabIndex = 15;
            this.buttonPlayAlt.Text = "Play";
            this.buttonPlayAlt.UseVisualStyleBackColor = true;
            this.buttonPlayAlt.Click += new System.EventHandler(this.buttonPlayAlt_Click);
            // 
            // textBoxNumberItems
            // 
            this.textBoxNumberItems.Location = new System.Drawing.Point(584, 503);
            this.textBoxNumberItems.Name = "textBoxNumberItems";
            this.textBoxNumberItems.Size = new System.Drawing.Size(75, 20);
            this.textBoxNumberItems.TabIndex = 16;
            this.textBoxNumberItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrentItem
            // 
            this.textBoxCurrentItem.Location = new System.Drawing.Point(746, 503);
            this.textBoxCurrentItem.Name = "textBoxCurrentItem";
            this.textBoxCurrentItem.Size = new System.Drawing.Size(75, 20);
            this.textBoxCurrentItem.TabIndex = 17;
            this.textBoxCurrentItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 540);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(360, 13);
            this.progressBar.TabIndex = 20;
            // 
            // buttonStopAlt
            // 
            this.buttonStopAlt.Location = new System.Drawing.Point(827, 473);
            this.buttonStopAlt.Name = "buttonStopAlt";
            this.buttonStopAlt.Size = new System.Drawing.Size(75, 23);
            this.buttonStopAlt.TabIndex = 21;
            this.buttonStopAlt.Text = "Stop";
            this.buttonStopAlt.UseVisualStyleBackColor = true;
            this.buttonStopAlt.Click += new System.EventHandler(this.buttonStopAlt_Click);
            // 
            // labelCurrentPosition
            // 
            this.labelCurrentPosition.AutoSize = true;
            this.labelCurrentPosition.Location = new System.Drawing.Point(52, 540);
            this.labelCurrentPosition.Name = "labelCurrentPosition";
            this.labelCurrentPosition.Size = new System.Drawing.Size(34, 13);
            this.labelCurrentPosition.TabIndex = 22;
            this.labelCurrentPosition.Text = "00:00";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(459, 540);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(34, 13);
            this.labelDuration.TabIndex = 23;
            this.labelDuration.Text = "00:00";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(12, 568);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 24;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonPlay2
            // 
            this.buttonPlay2.Location = new System.Drawing.Point(93, 568);
            this.buttonPlay2.Name = "buttonPlay2";
            this.buttonPlay2.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay2.TabIndex = 25;
            this.buttonPlay2.Text = "Play";
            this.buttonPlay2.UseVisualStyleBackColor = true;
            // 
            // buttonStop2
            // 
            this.buttonStop2.Location = new System.Drawing.Point(174, 568);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(75, 23);
            this.buttonStop2.TabIndex = 26;
            this.buttonStop2.Text = "Stop";
            this.buttonStop2.UseVisualStyleBackColor = true;
            // 
            // buttonOpen2
            // 
            this.buttonOpen2.Location = new System.Drawing.Point(255, 568);
            this.buttonOpen2.Name = "buttonOpen2";
            this.buttonOpen2.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen2.TabIndex = 27;
            this.buttonOpen2.Text = "Open";
            this.buttonOpen2.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 12);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(68, 13);
            this.labelMessage.TabIndex = 28;
            this.labelMessage.Text = "Media Player";
            // 
            // textBoxForeach
            // 
            this.textBoxForeach.Location = new System.Drawing.Point(255, 506);
            this.textBoxForeach.Name = "textBoxForeach";
            this.textBoxForeach.Size = new System.Drawing.Size(75, 20);
            this.textBoxForeach.TabIndex = 29;
            this.textBoxForeach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCloseDisplay
            // 
            this.buttonCloseDisplay.Enabled = false;
            this.buttonCloseDisplay.Location = new System.Drawing.Point(432, 500);
            this.buttonCloseDisplay.Name = "buttonCloseDisplay";
            this.buttonCloseDisplay.Size = new System.Drawing.Size(92, 23);
            this.buttonCloseDisplay.TabIndex = 30;
            this.buttonCloseDisplay.Text = "Close Display";
            this.buttonCloseDisplay.UseVisualStyleBackColor = true;
            this.buttonCloseDisplay.Click += new System.EventHandler(this.buttonCloseDisplay_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(1004, 500);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(92, 23);
            this.buttonCloseForm.TabIndex = 32;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonOpenForm
            // 
            this.buttonOpenForm.Location = new System.Drawing.Point(1004, 474);
            this.buttonOpenForm.Name = "buttonOpenForm";
            this.buttonOpenForm.Size = new System.Drawing.Size(92, 23);
            this.buttonOpenForm.TabIndex = 31;
            this.buttonOpenForm.Text = "Open Form";
            this.buttonOpenForm.UseVisualStyleBackColor = true;
            this.buttonOpenForm.Click += new System.EventHandler(this.buttonOpenForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 599);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonOpenForm);
            this.Controls.Add(this.buttonCloseDisplay);
            this.Controls.Add(this.textBoxForeach);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonOpen2);
            this.Controls.Add(this.buttonStop2);
            this.Controls.Add(this.buttonPlay2);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelCurrentPosition);
            this.Controls.Add(this.buttonStopAlt);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxCurrentItem);
            this.Controls.Add(this.textBoxNumberItems);
            this.Controls.Add(this.buttonPlayAlt);
            this.Controls.Add(this.buttonClearAlt);
            this.Controls.Add(this.listBoxAlt);
            this.Controls.Add(this.axWindowsMediaPlayerAlt);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonOpenDisplay);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonOpenDisplay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerAlt;
        private System.Windows.Forms.ListBox listBoxAlt;
        private System.Windows.Forms.Button buttonClearAlt;
        private System.Windows.Forms.Button buttonPlayAlt;
        private System.Windows.Forms.TextBox textBoxNumberItems;
        private System.Windows.Forms.TextBox textBoxCurrentItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonStopAlt;
        private System.Windows.Forms.Label labelCurrentPosition;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonPlay2;
        private System.Windows.Forms.Button buttonStop2;
        private System.Windows.Forms.Button buttonOpen2;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxForeach;
        private System.Windows.Forms.Button buttonCloseDisplay;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonOpenForm;
    }
}

