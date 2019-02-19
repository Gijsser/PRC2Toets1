using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets1
{
    class Artist
    {
        public string Name { private set; get; }
        public DateTime Birthday { private set; get; }
        public List<Song> Songs { private set; get; }
        public Artist(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
            Songs = new List<Song>();
        }
        public Artist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }
        public void Add(Song song)
        {
            Songs.Add(song);
        }
        public override string ToString()
        {
            return Name + "," + Birthday;
        }
    }
}
