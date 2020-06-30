using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Station
    {
        public string Name;
        public string ArrivalTrack;
        public DateTime ArrvialTime;
        public DateTime DepatureTime;

        public Station(string name, string arrivalTrack, DateTime arrivalTime, DateTime depatureTime)
        {
            this.Name = name;
            this.ArrivalTrack = arrivalTrack;
            this.ArrvialTime = arrivalTime;
            this.DepatureTime = depatureTime;
        }

    }
}
