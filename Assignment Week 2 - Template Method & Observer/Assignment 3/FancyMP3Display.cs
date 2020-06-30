using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class FancyMP3Display : IObserver
    {
        private ISubject mp3Player;

        public FancyMP3Display (ISubject mp3Player)
        {
            this.mp3Player = mp3Player;
            mp3Player.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Fancy Display: '{song.Title}' by {song.Artist} ({song.Duration})");
        }
    }
}
