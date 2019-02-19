using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets1
{
    class Song
    {
        public string Name { private set; get; }
        public int Year { private set; get; }
        public string PathToFile { private set; get; }
        public string Lyrics { private set; get; }
        public Artist Artist { private set; get; }
        public Song(string name, int year, string path, Artist artist)
        {
            Name = name;
            Year = year;
            PathToFile = path;
            Artist = artist;
        }
        public Song(string name, int year, string path, string lyrics)
        {
            Name = name;
            Year = year;
            PathToFile = path;
            Lyrics = lyrics;
        }
        public override string ToString()
        {
            return Name + "," + Year + "," + Artist.Name;
        }
    }
}
