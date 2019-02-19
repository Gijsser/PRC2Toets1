using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets1
{
    class Playlist
    {
        public string Name
        {
            get; private set;
        }
        public List<Song> Songs
        {
            get; private set;
        } 
        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }
        public void Add(Song song)
        {
            Songs.Add(song);
        }
        public void Add(List<Song> songs)
        {
            foreach ( Song s in songs)
            {
                Songs.Add(s);
            }
        }
        public void Remove(Song song)
        {
            Songs.Remove(song);
            Songs.Sort();
        }
        //public List<Song> getSongs()
        //{
        //    return this.Songs;
        //}
        public override string ToString()
        {
            return this.Name;
        }
    }
}
