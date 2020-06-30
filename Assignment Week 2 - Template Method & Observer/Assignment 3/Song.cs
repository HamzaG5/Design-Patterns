using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Song
    {
        public String Artist;
        public String Title;
        public String Duration;

        public Song(string artist, string title, string duration)
        {
            this.Artist = artist;
            this.Title = title;
            this.Duration = duration;
        }
    }
}
