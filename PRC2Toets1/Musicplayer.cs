using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets1
{
    class Musicplayer
    {
        public List<Artist> Artists { get; private set; }
        public List<Song> Songs { get; private set; }
        public List<Playlist> Playlists { get; private set; }
        public Musicplayer()
        {
            Artists = new List<Artist>();
            Songs = new List<Song>();
            Playlists = new List<Playlist>();
        }
        public Song PlayingSong { private set; get; }
        public Playlist PlayingList { private set; get; }
        public void Add(Artist artist)
        {
            Artists.Add(artist);
        }
        public void Add(Song song)
        {
            Songs.Add(song);
        }
        public void Add(Song song, Playlist playlist)
        {
            foreach(Playlist p in Playlists)
            {
                if (p == playlist)
                {
                    p.Add(song);
                }
            }
        }
        public void Add(Playlist playlist)
        {
            Playlists.Add(playlist);
        }
        public void Remove(Playlist playlist)
        {
            Playlists.Remove(playlist);
            Playlists.Sort();
        }
        public void Remove(Song song, Playlist playlist)
        {
            Songs.Remove(song);
            Songs.Sort();
        }
        public void Play(Song song)
        {
            PlayingSong = song;
        }
        public void Play(Playlist playlist)
        {
            PlayingList = playlist;
        }
        public Song IsPlaying()
        {
            return PlayingSong;
        }
        public void StopPlaying()
        {
            PlayingList = null;
            PlayingSong = null;
        }
    }
}
