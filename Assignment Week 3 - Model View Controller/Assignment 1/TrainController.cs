using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class TrainController : ITrainController
    {
        private ITrainJourney TrainJourney;
        
        public TrainController(ITrainJourney trainJourney)
        {
            this.TrainJourney = trainJourney;
        }

        public void NextStation()
        {
            TrainJourney.Next();
        }

        public List<string> RemainingStations()
        {
            List<string> stations = TrainJourney.RemainingStations();
            return stations;
        }
    }
}
