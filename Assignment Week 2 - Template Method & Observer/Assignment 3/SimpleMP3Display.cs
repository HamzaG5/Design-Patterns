using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class SimpleMP3Display : IObserver
    {
        private ISubject mp3Player;

        public SimpleMP3Display(ISubject mp3Player)
        {
            this.mp3Player = mp3Player;
            mp3Player.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Simple Display: '{song.Artist}' - {song.Title}");
        }
    }
}
