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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.comboBoxSelectNummers = new System.Windows.Forms.ComboBox();
            this.listBoxNumers = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DeletePlaylist = new System.Windows.Forms.Button();
            this.butNmrRemove = new System.Windows.Forms.Button();
            this.butNmrAdd = new System.Windows.Forms.Button();
            this.ListBoxPlaylist = new System.Windows.Forms.ListBox();
            this.listBoxPlaylistAdd = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.textBoxNaamPLaylisy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddArtiest = new System.Windows.Forms.Button();
            this.dateTimePickerAddArtiest = new System.Windows.Forms.DateTimePicker();
            this.textBoxNaamArtiestAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxJaarArtiest = new System.Windows.Forms.TextBox();
            this.textBoxTitelAddSong = new System.Windows.Forms.TextBox();
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArtiestAddSong = new System.Windows.Forms.ComboBox();
            this.Tabs = new System.Windows.Forms.TabControl();
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
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.comboBoxSelectNummers);
            this.tabPage6.Controls.Add(this.listBoxNumers);
            this.tabPage6.Location = new System.Drawing.Point(10, 48);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1482, 724);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Library";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // comboBoxSelectNummers
            // 
            this.comboBoxSelectNummers.FormattingEnabled = true;
            this.comboBoxSelectNummers.Location = new System.Drawing.Point(619, 88);
            this.comboBoxSelectNummers.Name = "comboBoxSelectNummers";
            this.comboBoxSelectNummers.Size = new System.Drawing.Size(250, 39);
            this.comboBoxSelectNummers.TabIndex = 1;
            this.comboBoxSelectNummers.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectNummers_SelectedIndexChanged);
            // 
            // listBoxNumers
            // 
            this.listBoxNumers.FormattingEnabled = true;
            this.listBoxNumers.ItemHeight = 31;
            this.listBoxNumers.Location = new System.Drawing.Point(64, 61);
            this.listBoxNumers.Name = "listBoxNumers";
            this.listBoxNumers.Size = new System.Drawing.Size(487, 593);
            this.listBoxNumers.TabIndex = 0;
            this.listBoxNumers.DoubleClick += new System.EventHandler(this.listBoxNumers_DoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(10, 48);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1482, 724);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Play Music";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DeletePlaylist);
            this.tabPage4.Controls.Add(this.butNmrRemove);
            this.tabPage4.Controls.Add(this.butNmrAdd);
            this.tabPage4.Controls.Add(this.ListBoxPlaylist);
            this.tabPage4.Controls.Add(this.listBoxPlaylistAdd);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(10, 48);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1482, 724);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Edit Playlist";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DeletePlaylist
            // 
            this.DeletePlaylist.Location = new System.Drawing.Point(74, 245);
            this.DeletePlaylist.Name = "DeletePlaylist";
            this.DeletePlaylist.Size = new System.Drawing.Size(188, 45);
            this.DeletePlaylist.TabIndex = 6;
            this.DeletePlaylist.Text = "Delete";
            this.DeletePlaylist.UseVisualStyleBackColor = true;
            this.DeletePlaylist.Click += new System.EventHandler(this.DeletePlaylist_Click);
            // 
            // butNmrRemove
            // 
            this.butNmrRemove.Location = new System.Drawing.Point(864, 439);
            this.butNmrRemove.Name = "butNmrRemove";
            this.butNmrRemove.Size = new System.Drawing.Size(160, 110);
            this.butNmrRemove.TabIndex = 5;
            this.butNmrRemove.Text = "<<";
            this.butNmrRemove.UseVisualStyleBackColor = true;
            this.butNmrRemove.Click += new System.EventHandler(this.butNmrRemove_Click);
            // 
            // butNmrAdd
            // 
            this.butNmrAdd.Location = new System.Drawing.Point(864, 84);
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
            this.ListBoxPlaylist.Location = new System.Drawing.Point(1030, 59);
            this.ListBoxPlaylist.Name = "ListBoxPlaylist";
            this.ListBoxPlaylist.Size = new System.Drawing.Size(398, 593);
            this.ListBoxPlaylist.TabIndex = 3;
            // 
            // listBoxPlaylistAdd
            // 
            this.listBoxPlaylistAdd.FormattingEnabled = true;
            this.listBoxPlaylistAdd.ItemHeight = 31;
            this.listBoxPlaylistAdd.Location = new System.Drawing.Point(446, 59);
            this.listBoxPlaylistAdd.Name = "listBoxPlaylistAdd";
            this.listBoxPlaylistAdd.Size = new System.Drawing.Size(398, 593);
            this.listBoxPlaylistAdd.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 39);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Playlist aanpassen";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAddPlaylist);
            this.tabPage3.Controls.Add(this.textBoxNaamPLaylisy);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1482, 724);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Playlist";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlaylist
            // 
            this.buttonAddPlaylist.Location = new System.Drawing.Point(128, 138);
            this.buttonAddPlaylist.Name = "buttonAddPlaylist";
            this.buttonAddPlaylist.Size = new System.Drawing.Size(143, 51);
            this.buttonAddPlaylist.TabIndex = 3;
            this.buttonAddPlaylist.Text = "Add";
            this.buttonAddPlaylist.UseVisualStyleBackColor = true;
            this.buttonAddPlaylist.Click += new System.EventHandler(this.buttonAddPlaylist_Click);
            // 
            // textBoxNaamPLaylisy
            // 
            this.textBoxNaamPLaylisy.Location = new System.Drawing.Point(128, 76);
            this.textBoxNaamPLaylisy.Name = "textBoxNaamPLaylisy";
            this.textBoxNaamPLaylisy.Size = new System.Drawing.Size(177, 38);
            this.textBoxNaamPLaylisy.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Naam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Add playlist:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddArtiest);
            this.tabPage2.Controls.Add(this.dateTimePickerAddArtiest);
            this.tabPage2.Controls.Add(this.textBoxNaamArtiestAdd);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1482, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Artist";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddArtiest
            // 
            this.buttonAddArtiest.Location = new System.Drawing.Point(287, 196);
            this.buttonAddArtiest.Name = "buttonAddArtiest";
            this.buttonAddArtiest.Size = new System.Drawing.Size(142, 37);
            this.buttonAddArtiest.TabIndex = 5;
            this.buttonAddArtiest.Text = "Add:";
            this.buttonAddArtiest.UseVisualStyleBackColor = true;
            this.buttonAddArtiest.Click += new System.EventHandler(this.buttonAddArtiest_Click);
            // 
            // dateTimePickerAddArtiest
            // 
            this.dateTimePickerAddArtiest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAddArtiest.Location = new System.Drawing.Point(287, 135);
            this.dateTimePickerAddArtiest.Name = "dateTimePickerAddArtiest";
            this.dateTimePickerAddArtiest.Size = new System.Drawing.Size(333, 38);
            this.dateTimePickerAddArtiest.TabIndex = 4;
            // 
            // textBoxNaamArtiestAdd
            // 
            this.textBoxNaamArtiestAdd.Location = new System.Drawing.Point(287, 92);
            this.textBoxNaamArtiestAdd.Name = "textBoxNaamArtiestAdd";
            this.textBoxNaamArtiestAdd.Size = new System.Drawing.Size(161, 38);
            this.textBoxNaamArtiestAdd.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Geboorte datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Naam:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add artist:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxJaarArtiest);
            this.tabPage1.Controls.Add(this.textBoxTitelAddSong);
            this.tabPage1.Controls.Add(this.buttonAddSong);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxArtiestAddSong);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1482, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Song";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxJaarArtiest
            // 
            this.textBoxJaarArtiest.Location = new System.Drawing.Point(188, 139);
            this.textBoxJaarArtiest.Name = "textBoxJaarArtiest";
            this.textBoxJaarArtiest.Size = new System.Drawing.Size(257, 38);
            this.textBoxJaarArtiest.TabIndex = 8;
            // 
            // textBoxTitelAddSong
            // 
            this.textBoxTitelAddSong.Location = new System.Drawing.Point(188, 87);
            this.textBoxTitelAddSong.Name = "textBoxTitelAddSong";
            this.textBoxTitelAddSong.Size = new System.Drawing.Size(370, 38);
            this.textBoxTitelAddSong.TabIndex = 6;
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.Location = new System.Drawing.Point(188, 256);
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.Size = new System.Drawing.Size(136, 50);
            this.buttonAddSong.TabIndex = 7;
            this.buttonAddSong.Text = "Add";
            this.buttonAddSong.UseVisualStyleBackColor = true;
            this.buttonAddSong.Click += new System.EventHandler(this.buttonAddSong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Artiest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jaar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add song:";
            // 
            // comboBoxArtiestAddSong
            // 
            this.comboBoxArtiestAddSong.FormattingEnabled = true;
            this.comboBoxArtiestAddSong.Location = new System.Drawing.Point(188, 190);
            this.comboBoxArtiestAddSong.Name = "comboBoxArtiestAddSong";
            this.comboBoxArtiestAddSong.Size = new System.Drawing.Size(257, 39);
            this.comboBoxArtiestAddSong.TabIndex = 0;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Controls.Add(this.tabPage4);
            this.Tabs.Controls.Add(this.tabPage5);
            this.Tabs.Controls.Add(this.tabPage6);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1502, 782);
            this.Tabs.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2303, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(181, 111);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1539, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "Playing:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1545, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "Artist:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1545, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 32);
            this.label13.TabIndex = 4;
            this.label13.Text = "Release Date:";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Location = new System.Drawing.Point(1714, 94);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(109, 32);
            this.labelSong.TabIndex = 5;
            this.labelSong.Text = "label14";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(1720, 152);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(109, 32);
            this.labelArtist.TabIndex = 6;
            this.labelArtist.Text = "label15";
            // 
            // labelRelease
            // 
            this.labelRelease.AutoSize = true;
            this.labelRelease.Location = new System.Drawing.Point(1757, 210);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(109, 32);
            this.labelRelease.TabIndex = 7;
            this.labelRelease.Text = "label16";
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(1682, 528);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(183, 44);
            this.butStop.TabIndex = 8;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butPause
            // 
            this.butPause.Location = new System.Drawing.Point(1909, 528);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(200, 44);
            this.butPause.TabIndex = 9;
            this.butPause.Text = "Pause";
            this.butPause.UseVisualStyleBackColor = true;
            this.butPause.Click += new System.EventHandler(this.butPause_Click);
            // 
            // butPlay
            // 
            this.butPlay.Location = new System.Drawing.Point(2171, 525);
            this.butPlay.Name = "butPlay";
            this.butPlay.Size = new System.Drawing.Size(169, 51);
            this.butPlay.TabIndex = 10;
            this.butPlay.Text = "Play";
            this.butPlay.UseVisualStyleBackColor = true;
            this.butPlay.Click += new System.EventHandler(this.butPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2510, 809);
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
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox listBoxNumers;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button DeletePlaylist;
        private System.Windows.Forms.Button butNmrRemove;
        private System.Windows.Forms.Button butNmrAdd;
        private System.Windows.Forms.ListBox ListBoxPlaylist;
        private System.Windows.Forms.ListBox listBoxPlaylistAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonAddPlaylist;
        private System.Windows.Forms.TextBox textBoxNaamPLaylisy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAddArtiest;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddArtiest;
        private System.Windows.Forms.TextBox textBoxNaamArtiestAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxJaarArtiest;
        private System.Windows.Forms.TextBox textBoxTitelAddSong;
        private System.Windows.Forms.Button buttonAddSong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxArtiestAddSong;
        private System.Windows.Forms.TabControl Tabs;
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
    }
}

