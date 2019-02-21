namespace PRC2Toets1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxSelectNummers = new System.Windows.Forms.ComboBox();
            this.listBoxNumers = new System.Windows.Forms.ListBox();
            this.DeletePlaylist = new System.Windows.Forms.Button();
            this.butNmrRemove = new System.Windows.Forms.Button();
            this.butNmrAdd = new System.Windows.Forms.Button();
            this.ListBoxPlaylist = new System.Windows.Forms.ListBox();
            this.listBoxPlaylistAdd = new System.Windows.Forms.ListBox();
            this.comboBoxPlaylistEdit = new System.Windows.Forms.ComboBox();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.textBoxNaamPLaylisy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddArtiest = new System.Windows.Forms.Button();
            this.dateTimePickerAddArtiest = new System.Windows.Forms.DateTimePicker();
            this.textBoxNaamArtiestAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelSong = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelRelease = new System.Windows.Forms.Label();
            this.butStop = new System.Windows.Forms.Button();
            this.butPause = new System.Windows.Forms.Button();
            this.butPlay = new System.Windows.Forms.Button();
            this.butPlayPlaylist = new System.Windows.Forms.Button();
            this.butForward = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.comboBoxArtiestAddSong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJaarArtiest = new System.Windows.Forms.TextBox();
            this.textBoxTitelAddSong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectSongs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBoxSelectNummers
            // 
            this.comboBoxSelectNummers.FormattingEnabled = true;
            this.comboBoxSelectNummers.Location = new System.Drawing.Point(3265, 218);
            this.comboBoxSelectNummers.Name = "comboBoxSelectNummers";
            this.comboBoxSelectNummers.Size = new System.Drawing.Size(250, 39);
            this.comboBoxSelectNummers.TabIndex = 1;
            // 
            // listBoxNumers
            // 
            this.listBoxNumers.FormattingEnabled = true;
            this.listBoxNumers.ItemHeight = 31;
            this.listBoxNumers.Location = new System.Drawing.Point(274, 43);
            this.listBoxNumers.Name = "listBoxNumers";
            this.listBoxNumers.Size = new System.Drawing.Size(356, 562);
            this.listBoxNumers.TabIndex = 0;
            this.listBoxNumers.DoubleClick += new System.EventHandler(this.listBoxNumers_DoubleClick);
            // 
            // DeletePlaylist
            // 
            this.DeletePlaylist.Location = new System.Drawing.Point(82, 223);
            this.DeletePlaylist.Name = "DeletePlaylist";
            this.DeletePlaylist.Size = new System.Drawing.Size(188, 45);
            this.DeletePlaylist.TabIndex = 6;
            this.DeletePlaylist.Text = "Delete";
            this.DeletePlaylist.UseVisualStyleBackColor = true;
            this.DeletePlaylist.Click += new System.EventHandler(this.DeletePlaylist_Click);
            // 
            // butNmrRemove
            // 
            this.butNmrRemove.Location = new System.Drawing.Point(872, 417);
            this.butNmrRemove.Name = "butNmrRemove";
            this.butNmrRemove.Size = new System.Drawing.Size(160, 110);
            this.butNmrRemove.TabIndex = 5;
            this.butNmrRemove.Text = "<<";
            this.butNmrRemove.UseVisualStyleBackColor = true;
            this.butNmrRemove.Click += new System.EventHandler(this.butNmrRemove_Click);
            // 
            // butNmrAdd
            // 
            this.butNmrAdd.Location = new System.Drawing.Point(872, 62);
            this.butNmrAdd.Name = "butNmrAdd";
            this.butNmrAdd.Size = new System.Drawing.Size(160, 88);
            this.butNmrAdd.TabIndex = 4;
            this.butNmrAdd.Text = ">>";
            this.butNmrAdd.UseVisualStyleBackColor = true;
            this.butNmrAdd.Click += new System.EventHandler(this.butNmrAdd_Click);
            // 
            // ListBoxPlaylist
            // 
            this.ListBoxPlaylist.FormattingEnabled = true;
            this.ListBoxPlaylist.ItemHeight = 31;
            this.ListBoxPlaylist.Location = new System.Drawing.Point(1038, 37);
            this.ListBoxPlaylist.Name = "ListBoxPlaylist";
            this.ListBoxPlaylist.Size = new System.Drawing.Size(398, 593);
            this.ListBoxPlaylist.TabIndex = 3;
            // 
            // listBoxPlaylistAdd
            // 
            this.listBoxPlaylistAdd.FormattingEnabled = true;
            this.listBoxPlaylistAdd.ItemHeight = 31;
            this.listBoxPlaylistAdd.Location = new System.Drawing.Point(454, 37);
            this.listBoxPlaylistAdd.Name = "listBoxPlaylistAdd";
            this.listBoxPlaylistAdd.Size = new System.Drawing.Size(398, 593);
            this.listBoxPlaylistAdd.TabIndex = 2;
            // 
            // comboBoxPlaylistEdit
            // 
            this.comboBoxPlaylistEdit.FormattingEnabled = true;
            this.comboBoxPlaylistEdit.Location = new System.Drawing.Point(50, 62);
            this.comboBoxPlaylistEdit.Name = "comboBoxPlaylistEdit";
            this.comboBoxPlaylistEdit.Size = new System.Drawing.Size(248, 39);
            this.comboBoxPlaylistEdit.TabIndex = 1;
            this.comboBoxPlaylistEdit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAddPlaylist
            // 
            this.buttonAddPlaylist.Location = new System.Drawing.Point(125, 100);
            this.buttonAddPlaylist.Name = "buttonAddPlaylist";
            this.buttonAddPlaylist.Size = new System.Drawing.Size(143, 51);
            this.buttonAddPlaylist.TabIndex = 3;
            this.buttonAddPlaylist.Text = "Add";
            this.buttonAddPlaylist.UseVisualStyleBackColor = true;
            this.buttonAddPlaylist.Click += new System.EventHandler(this.buttonAddPlaylist_Click);
            // 
            // textBoxNaamPLaylisy
            // 
            this.textBoxNaamPLaylisy.Location = new System.Drawing.Point(125, 38);
            this.textBoxNaamPLaylisy.Name = "textBoxNaamPLaylisy";
            this.textBoxNaamPLaylisy.Size = new System.Drawing.Size(177, 38);
            this.textBoxNaamPLaylisy.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Naam:";
            // 
            // buttonAddArtiest
            // 
            this.buttonAddArtiest.Location = new System.Drawing.Point(254, 150);
            this.buttonAddArtiest.Name = "buttonAddArtiest";
            this.buttonAddArtiest.Size = new System.Drawing.Size(142, 37);
            this.buttonAddArtiest.TabIndex = 5;
            this.buttonAddArtiest.Text = "Add";
            this.buttonAddArtiest.UseVisualStyleBackColor = true;
            this.buttonAddArtiest.Click += new System.EventHandler(this.buttonAddArtiest_Click);
            // 
            // dateTimePickerAddArtiest
            // 
            this.dateTimePickerAddArtiest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAddArtiest.Location = new System.Drawing.Point(321, 711);
            this.dateTimePickerAddArtiest.Name = "dateTimePickerAddArtiest";
            this.dateTimePickerAddArtiest.Size = new System.Drawing.Size(258, 38);
            this.dateTimePickerAddArtiest.TabIndex = 4;
            // 
            // textBoxNaamArtiestAdd
            // 
            this.textBoxNaamArtiestAdd.Location = new System.Drawing.Point(254, 46);
            this.textBoxNaamArtiestAdd.Name = "textBoxNaamArtiestAdd";
            this.textBoxNaamArtiestAdd.Size = new System.Drawing.Size(161, 38);
            this.textBoxNaamArtiestAdd.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Geboorte datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Naam:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1416, 926);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(181, 111);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.axWindowsMediaPlayer1_CurrentItemChange);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(941, 905);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "Playing:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(947, 964);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "Artist:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(947, 1022);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 32);
            this.label13.TabIndex = 4;
            this.label13.Text = "Release Date:";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Location = new System.Drawing.Point(1116, 905);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(109, 32);
            this.labelSong.TabIndex = 5;
            this.labelSong.Text = "label14";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(1122, 963);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(109, 32);
            this.labelArtist.TabIndex = 6;
            this.labelArtist.Text = "label15";
            // 
            // labelRelease
            // 
            this.labelRelease.AutoSize = true;
            this.labelRelease.Location = new System.Drawing.Point(1159, 1021);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(109, 32);
            this.labelRelease.TabIndex = 7;
            this.labelRelease.Text = "label16";
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(58, 908);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(183, 44);
            this.butStop.TabIndex = 8;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butPause
            // 
            this.butPause.Location = new System.Drawing.Point(285, 908);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(200, 44);
            this.butPause.TabIndex = 9;
            this.butPause.Text = "Pause";
            this.butPause.UseVisualStyleBackColor = true;
            this.butPause.Click += new System.EventHandler(this.butPause_Click);
            // 
            // butPlay
            // 
            this.butPlay.Location = new System.Drawing.Point(547, 905);
            this.butPlay.Name = "butPlay";
            this.butPlay.Size = new System.Drawing.Size(169, 51);
            this.butPlay.TabIndex = 10;
            this.butPlay.Text = "Play";
            this.butPlay.UseVisualStyleBackColor = true;
            this.butPlay.Click += new System.EventHandler(this.butPlay_Click);
            // 
            // butPlayPlaylist
            // 
            this.butPlayPlaylist.Location = new System.Drawing.Point(82, 139);
            this.butPlayPlaylist.Name = "butPlayPlaylist";
            this.butPlayPlaylist.Size = new System.Drawing.Size(188, 45);
            this.butPlayPlaylist.TabIndex = 7;
            this.butPlayPlaylist.Text = "Play";
            this.butPlayPlaylist.UseVisualStyleBackColor = true;
            this.butPlayPlaylist.Click += new System.EventHandler(this.butPlayPlaylist_Click);
            // 
            // butForward
            // 
            this.butForward.Location = new System.Drawing.Point(448, 998);
            this.butForward.Name = "butForward";
            this.butForward.Size = new System.Drawing.Size(169, 51);
            this.butForward.TabIndex = 11;
            this.butForward.Text = ">>";
            this.butForward.UseVisualStyleBackColor = true;
            this.butForward.Click += new System.EventHandler(this.butForward_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(193, 998);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(169, 51);
            this.butBack.TabIndex = 12;
            this.butBack.Text = "<<";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.Location = new System.Drawing.Point(187, 220);
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.Size = new System.Drawing.Size(136, 50);
            this.buttonAddSong.TabIndex = 7;
            this.buttonAddSong.Text = "Add";
            this.buttonAddSong.UseVisualStyleBackColor = true;
            this.buttonAddSong.Click += new System.EventHandler(this.buttonAddSong_Click);
            // 
            // comboBoxArtiestAddSong
            // 
            this.comboBoxArtiestAddSong.FormattingEnabled = true;
            this.comboBoxArtiestAddSong.Location = new System.Drawing.Point(187, 154);
            this.comboBoxArtiestAddSong.Name = "comboBoxArtiestAddSong";
            this.comboBoxArtiestAddSong.Size = new System.Drawing.Size(257, 39);
            this.comboBoxArtiestAddSong.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jaar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Artiest";
            // 
            // textBoxJaarArtiest
            // 
            this.textBoxJaarArtiest.Location = new System.Drawing.Point(187, 103);
            this.textBoxJaarArtiest.MaxLength = 4;
            this.textBoxJaarArtiest.Name = "textBoxJaarArtiest";
            this.textBoxJaarArtiest.Size = new System.Drawing.Size(257, 38);
            this.textBoxJaarArtiest.TabIndex = 8;
            // 
            // textBoxTitelAddSong
            // 
            this.textBoxTitelAddSong.Location = new System.Drawing.Point(187, 51);
            this.textBoxTitelAddSong.Name = "textBoxTitelAddSong";
            this.textBoxTitelAddSong.Size = new System.Drawing.Size(370, 38);
            this.textBoxTitelAddSong.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxJaarArtiest);
            this.groupBox1.Controls.Add(this.textBoxTitelAddSong);
            this.groupBox1.Controls.Add(this.buttonAddSong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxArtiestAddSong);
            this.groupBox1.Location = new System.Drawing.Point(55, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 306);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add song";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddPlaylist);
            this.groupBox2.Controls.Add(this.textBoxNaamPLaylisy);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(55, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 179);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add playlist";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAddArtiest);
            this.groupBox3.Controls.Add(this.textBoxNaamArtiestAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(55, 618);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 225);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add artist";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.butPlayPlaylist);
            this.groupBox4.Controls.Add(this.DeletePlaylist);
            this.groupBox4.Controls.Add(this.butNmrRemove);
            this.groupBox4.Controls.Add(this.butNmrAdd);
            this.groupBox4.Controls.Add(this.ListBoxPlaylist);
            this.groupBox4.Controls.Add(this.listBoxPlaylistAdd);
            this.groupBox4.Controls.Add(this.comboBoxPlaylistEdit);
            this.groupBox4.Location = new System.Drawing.Point(674, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1505, 640);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit playlist";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxSelectSongs);
            this.groupBox5.Controls.Add(this.listBoxNumers);
            this.groupBox5.Location = new System.Drawing.Point(2208, 47);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(682, 639);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Songs";
            // 
            // comboBoxSelectSongs
            // 
            this.comboBoxSelectSongs.FormattingEnabled = true;
            this.comboBoxSelectSongs.Location = new System.Drawing.Point(36, 87);
            this.comboBoxSelectSongs.Name = "comboBoxSelectSongs";
            this.comboBoxSelectSongs.Size = new System.Drawing.Size(223, 39);
            this.comboBoxSelectSongs.TabIndex = 1;
            this.comboBoxSelectSongs.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSongs_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2937, 1092);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dateTimePickerAddArtiest);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSelectNummers);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butForward);
            this.Controls.Add(this.butPlay);
            this.Controls.Add(this.butPause);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.labelRelease);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxNumers;
        private System.Windows.Forms.Button DeletePlaylist;
        private System.Windows.Forms.Button butNmrRemove;
        private System.Windows.Forms.Button butNmrAdd;
        private System.Windows.Forms.ListBox ListBoxPlaylist;
        private System.Windows.Forms.ListBox listBoxPlaylistAdd;
        private System.Windows.Forms.ComboBox comboBoxPlaylistEdit;
        private System.Windows.Forms.Button buttonAddPlaylist;
        private System.Windows.Forms.TextBox textBoxNaamPLaylisy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddArtiest;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddArtiest;
        private System.Windows.Forms.TextBox textBoxNaamArtiestAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSelectNummers;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelRelease;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butPause;
        private System.Windows.Forms.Button butPlay;
        private System.Windows.Forms.Button butPlayPlaylist;
        private System.Windows.Forms.Button butForward;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button buttonAddSong;
        private System.Windows.Forms.ComboBox comboBoxArtiestAddSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxJaarArtiest;
        private System.Windows.Forms.TextBox textBoxTitelAddSong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxSelectSongs;
    }
}

