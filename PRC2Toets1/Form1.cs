using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRC2Toets1
{
    public partial class Form1 : Form
    {
        Musicplayer Musicplayer = new Musicplayer();
        OpenFileDialog opf = new OpenFileDialog();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonAddSong_Click(object sender, EventArgs e)
        {
            opf.ShowDialog();
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                foreach( Artist a in Musicplayer.Artists)
                {
                    if (a.Name == comboBoxArtiestAddSong.Text)
                    {
                        Musicplayer.Add(new Song(textBoxTitelAddSong.Text, Convert.ToInt16(textBoxJaarArtiest.Text), opf.FileName.ToString(), a));
                    }
                }
                
            }
            Console.WriteLine(opf.FileName.ToString());
            textBoxTitelAddSong.Clear(); textBoxJaarArtiest.Clear();
        }
        private void buttonAddArtiest_Click(object sender, EventArgs e)
        {
            Musicplayer.Add(new Artist(textBoxNaamArtiestAdd.Text, dateTimePickerAddArtiest.Value));
            textBoxNaamArtiestAdd.Clear();
            MessageBox.Show("Artiest Toegevoegd");
            RefreshBoxen();
        }
        private void buttonAddPlaylist_Click(object sender, EventArgs e)
        {
            Musicplayer.Add(new Playlist(textBoxNaamPLaylisy.Text.ToString()));
            textBoxNaamPLaylisy.Clear();
            RefreshBoxen();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Musicplayer.Add(new Playlist("Mijn Playlist"));
            Musicplayer.Add(new Playlist("Jouw playlist"));
            Musicplayer.Add(new Artist("Gijs"));
            RefreshBoxen();
        }
        private void RefreshBoxen()
        {
            comboBox1.Items.Clear();
            comboBoxArtiestAddSong.Items.Clear();
            comboBoxSelectNummers.Items.Clear();
            foreach(Playlist p in Musicplayer.Playlists)
            {
                comboBox1.Items.Add(p.Name);
            }
            foreach(Artist a in Musicplayer.Artists)
            {
                comboBoxArtiestAddSong.Items.Add(a.Name);
                comboBoxSelectNummers.Items.Add(a.Name);
                comboBoxSelectNummers.Items.Add("All");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPlaylist();
        }
        private void refreshPlaylist()
        {
            string playlist = comboBox1.Text;
            listBoxPlaylistAdd.Items.Clear();
            ListBoxPlaylist.Items.Clear();
            foreach (Song s in Musicplayer.Songs)
            {
                listBoxPlaylistAdd.Items.Add(s.Name);
            }
            foreach (Playlist p in Musicplayer.Playlists)
            {
                if (p.Name == playlist)
                {
                    foreach (Song n in p.Songs)
                    {
                        ListBoxPlaylist.Items.Add(n.Name);
                    }
                }
            }
        }

        private void butNmrAdd_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylistAdd.SelectedItem == null) return;
            string playlist = comboBox1.Text;
            string song = listBoxPlaylistAdd.SelectedItem.ToString();
            foreach (Playlist p in Musicplayer.Playlists)
            {
                if (p.Name == playlist)
                {
                    foreach(Song s in Musicplayer.Songs)
                    {
                        if (s.Name == song)
                        {
                            Musicplayer.Add(s, p);
                        }
                    }
                }
            }
            refreshPlaylist();
        }

        private void butNmrRemove_Click(object sender, EventArgs e)
        {
            if (ListBoxPlaylist.SelectedItem == null) return;
            string playlist = comboBox1.Text;
            string song = ListBoxPlaylist.SelectedItem.ToString();
            foreach (Playlist p in Musicplayer.Playlists)
            {
                if (p.Name == playlist)
                {
                    foreach (Song s in Musicplayer.Songs)
                    {
                        if (s.Name == song)
                        {
                           Musicplayer.Remove(s, p);
                        }
                    }
                }
            }
            refreshPlaylist();
        }

        private void DeletePlaylist_Click(object sender, EventArgs e)
        {
            foreach(Playlist p in Musicplayer.Playlists)
            {
                if (p.Name == comboBox1.Text)
                {
                    Musicplayer.Remove(p);
                }
            }
        }

        private void listBoxNumers_DoubleClick(object sender, EventArgs e)
        {
            foreach(Song s in Musicplayer.Songs)
            {
                if(s.Name == listBoxNumers.SelectedItem.ToString())
                {
                    axWindowsMediaPlayer1.URL = s.PathToFile;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    Musicplayer.Play(s);
                    refreshPlaying();
                }
            }
        }

        private void comboBoxSelectNummers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxNumers.Items.Clear();
            if (comboBoxSelectNummers.Text == "All")
            {
                foreach (Song s in Musicplayer.Songs)
                {
                    listBoxNumers.Items.Add(s.Name);
                }
            }
            else {
                foreach (Song s in Musicplayer.Songs)
                {
                    if (s.Artist.ToString() == comboBoxSelectNummers.Text)
                    {
                        listBoxNumers.Items.Add(s.Name);
                    }
            }
            }
        }
        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }
        private void refreshPlaying()
        {
            var song = (Song)Musicplayer.IsPlaying();
            foreach(Song s in Musicplayer.Songs)
            {
                if( s == song)
                {
                    labelArtist.Text = s.Artist.ToString();
                    labelSong.Text = s.Name;
                    labelRelease.Text = s.Year.ToString();
                }
            }
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void butPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void butPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
