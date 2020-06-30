using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class MP3Player : ISubject
    {
        Random rnd;
        public Song CurrentSong { get; private set; }
        private List<Song> songs = new List<Song>();
        private List<IObserver> mp3Displayes = new List<IObserver>();
        private Song song1 = new Song("Pink Floyd", "Wish You Were Here", "3:12");
        private Song song2  = new Song("Led Zeppelin", "Daze and Confused", "04:00");
        private Song song3 = new Song("Bruno Mars", "Billionaire", "3:33");

        public MP3Player()
        {
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            rnd = new Random();
        }

        public void NextSong()
        {
            int rndvalue = rnd.Next(songs.Count);
            CurrentSong = songs.ElementAt(rndvalue);

            NotifyObservers();
        }

        public void AddObserver(IObserver observer)
        {
            mp3Displayes.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            mp3Displayes.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver display in mp3Displayes)
            {
                display.Update(CurrentSong);
            }
        }
    }
}
