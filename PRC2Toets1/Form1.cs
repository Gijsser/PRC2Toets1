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
            Artist Lil_Peep = new Artist("Lil Peep");
            Musicplayer.Add(Lil_Peep);
            Artist Tame_Impala = new Artist("Tame Impala");
            Musicplayer.Add(Tame_Impala);
            Musicplayer.Add(new Song("Star Shopping", 2017, "C:\\Users\\Gijs\\Downloads\\Lil Peep - Star Shopping (Removed At 1.9 Mil Views).mp3", Lil_Peep));
            Musicplayer.Add(new Song("Elephant", 2012, "C:\\Users\\Gijs\\Downloads\\Tame Impala - Elephant (Official Video).mp3", Tame_Impala));
            RefreshBoxen();
        }

        private void RefreshBoxen()
        {
            comboBoxPlaylistEdit.Items.Clear();
            comboBoxArtiestAddSong.Items.Clear();
            comboBoxSelectSongs.Items.Clear();
            foreach(Playlist p in Musicplayer.Playlists)
            {
                comboBoxPlaylistEdit.Items.Add(p.Name);
            }
            foreach(Artist a in Musicplayer.Artists)
            {
                comboBoxArtiestAddSong.Items.Add(a.Name);
                comboBoxSelectSongs.Items.Add(a.Name);
               
            }
            comboBoxSelectSongs.Items.Add("All");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPlaylist();
        }

        private void refreshPlaylist()
        {
            string playlist = comboBoxPlaylistEdit.Text;
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
            string playlist = comboBoxPlaylistEdit.Text;
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
            string playlist = comboBoxPlaylistEdit.Text;
            string song = ListBoxPlaylist.SelectedItem.ToString();
            foreach (Playlist p in Musicplayer.Playlists)
            {
                if (p.Name == playlist)
                {
                    foreach (Song s in Musicplayer.Songs.ToList())
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
            foreach(Playlist p in Musicplayer.Playlists.ToList())
            {
                if (p.Name == comboBoxPlaylistEdit.Text)
                {
                    Musicplayer.Remove(p);
                    RefreshBoxen();
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
            Musicplayer.StopPlaying();
        }

        private void butPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void butPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void butPlayPlaylist_Click(object sender, EventArgs e)
        {
            foreach(Playlist p in Musicplayer.Playlists)
            {
                if(p.Name == comboBoxPlaylistEdit.Text)
                {
                    Musicplayer.Play(p);
                    playPlaylist(p);
                }
            }
        }

        private void playPlaylist(Playlist playlist)
        {
            var myPlayList = axWindowsMediaPlayer1.playlistCollection.newPlaylist("MyPlayList");
          foreach(Song s in playlist.Songs)
            {
                var mediaItem = axWindowsMediaPlayer1.newMedia(s.PathToFile);
                myPlayList.appendItem(mediaItem);
            }

            axWindowsMediaPlayer1.currentPlaylist = myPlayList;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            foreach(Song s in Musicplayer.Songs)
            {
                if(s.PathToFile == axWindowsMediaPlayer1.currentMedia.sourceURL)
                {
                    Musicplayer.Play(s);
                }
            }
            refreshPlaying();
        }

        private void butForward_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentPlaylist == null) return;
            axWindowsMediaPlayer1.Ctlcontrols.next();
            foreach (Song s in Musicplayer.Songs)
            {
                if (s.PathToFile == axWindowsMediaPlayer1.currentMedia.sourceURL)
                {
                    Musicplayer.Play(s);
                }
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentPlaylist == null) return;
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            foreach(Song s in Musicplayer.Songs)
            {
                if (s.PathToFile == axWindowsMediaPlayer1.currentMedia.sourceURL)
                {
                    Musicplayer.Play(s);
                }
            }
            
        }

        private void comboBoxSelectSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxNumers.Items.Clear();
            if (comboBoxSelectSongs.Text == "All")
            {
                foreach (Song s in Musicplayer.Songs)
                {
                    listBoxNumers.Items.Add(s.Name);
                }
            }
            else
            {
                foreach (Song s in Musicplayer.Songs)
            {
                if (s.Artist.Name == comboBoxSelectSongs.Text)
                {
                    listBoxNumers.Items.Add(s.Name);
                }
            }
          }
        }
    }
}
