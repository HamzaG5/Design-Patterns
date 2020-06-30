using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class TrainJourney : ITrainJourney
    {
        public int counter = 0;
        public bool reverseJourney = false;
        public Station CurrentStation { get; set; }
        private List<string> remaingStaionsList = new List<string>();
        private List<Station> Stations = new List<Station>();
        private List<IObserver> stationObservers = new List<IObserver>();

        Station denHelder = new Station("Den Helder", "3", new DateTime(2019, 05, 10, 09, 04, 00), new DateTime(2019, 05, 10, 09, 04, 00));
        Station denHelderZuid = new Station("Den Helder Zuid", "1", new DateTime(2019, 05, 10, 09, 08, 00), new DateTime(2019, 05, 10, 09, 08, 00));
        Station annaPaulowna = new Station("Anna Paulowna", "1", new DateTime(2019, 05, 10, 09, 15, 00), new DateTime(2019, 05, 10, 09, 16, 00));
        Station schagen = new Station("Schagen", "1", new DateTime(2019, 05, 10, 09, 22, 00), new DateTime(2019, 05, 10, 09, 22, 00));
        Station heerhugowaard = new Station("Heerhugowaard", "1", new DateTime(2019, 05, 10, 09, 31, 00), new DateTime(2019, 05, 10, 09, 31, 00));
        Station alkmaarNoord = new Station("Alkmaar Noord", "1", new DateTime(2019, 05, 10, 09, 36, 00), new DateTime(2019, 05, 10, 09, 36, 00));
        Station alkmaar = new Station("Alkmaar", "5", new DateTime(2019, 05, 10, 09, 41, 00), new DateTime(2019, 05, 10, 09, 44, 00));
        Station heiloo = new Station("Heiloo", "2", new DateTime(2019, 05, 10, 09, 49, 00), new DateTime(2019, 05, 10, 09, 49, 00));
        Station castricum = new Station("Castricum", "2", new DateTime(2019, 05, 10, 09, 55, 00), new DateTime(2019, 05, 10, 09, 55, 00));
        Station zaandam = new Station("Zaandam", "4", new DateTime(2019, 05, 10, 10, 09, 00), new DateTime(2019, 05, 10, 10, 09, 00));
        Station amsterdamSloterdijk = new Station("Amsterdam Sloterdijk", "5", new DateTime(2019, 05, 10, 10, 15, 00), new DateTime(2019, 05, 10, 10, 15, 00));
        Station amsterdamCentraal = new Station("Amsterdam Centraal", "5", new DateTime(2019, 05, 10, 10, 21, 00), new DateTime(2019, 05, 10, 10, 24, 00));
        Station amsterdamAmstel = new Station("Amsterdam Amstel", "4", new DateTime(2019, 05, 10, 10, 31, 00), new DateTime(2019, 05, 10, 10, 33, 00));
        Station utrechtCentraal = new Station("Utrecht Centraal", "19", new DateTime(2019, 05, 10, 10, 52, 00), new DateTime(2019, 05, 10, 10, 54, 00));
        Station veenendaal = new Station("Veenendaal-De Klomp", "2", new DateTime(2019, 05, 10, 11, 12, 00), new DateTime(2019, 05, 10, 11, 12, 00));
        Station edeWageningen = new Station("Ede-Wageningen", "4", new DateTime(2019, 05, 10, 11, 18, 00), new DateTime(2019, 05, 10, 11, 18, 00));
        Station arnhemCentraal = new Station("Arnhem Centraal", "8", new DateTime(2019, 05, 10, 11, 29, 00), new DateTime(2019, 05, 10, 11, 35, 00));
        Station nijmegen = new Station("Nijmegen", "4a", new DateTime(2019, 05, 10, 11, 47, 00), new DateTime(2019, 05, 10, 11, 47, 00));


        public TrainJourney()
        {
            Stations.Add(denHelder);
            Stations.Add(denHelderZuid);
            Stations.Add(annaPaulowna);
            Stations.Add(schagen);
            Stations.Add(heerhugowaard);
            Stations.Add(alkmaarNoord);
            Stations.Add(alkmaar);
            Stations.Add(heiloo);
            Stations.Add(castricum);
            Stations.Add(zaandam);
            Stations.Add(amsterdamSloterdijk);
            Stations.Add(amsterdamCentraal);
            Stations.Add(amsterdamAmstel);
            Stations.Add(utrechtCentraal);
            Stations.Add(veenendaal);
            Stations.Add(edeWageningen);
            Stations.Add(arnhemCentraal);
            Stations.Add(nijmegen);
            CurrentStation = denHelder;
        }

        public void AddObserver(IObserver observer)
        {
            stationObservers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            stationObservers.Remove(observer);
        }

        public void Next()
        {
            if (reverseJourney == false)
            {
                CurrentStation = Stations[counter];
                counter++;

                if (counter == Stations.Count)
                {
                    reverseJourney = true;
                }
            }
            else
            {
                counter--;
                CurrentStation = Stations[counter];

                if (counter == 0)
                {
                    reverseJourney = false;
                }
            }
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (IObserver observer in stationObservers)
            {
                observer.Update(CurrentStation);
            }
        }

        public List<string> RemainingStations()
        {
            if (reverseJourney == false)
            {
                for (int i = counter; i < Stations.Count; i++)
                {
                    remaingStaionsList.Add(Stations[i].Name);
                }
            }
            else
            {
                for (int i = counter; i > -1 && i < Stations.Count; i--)
                {
                    remaingStaionsList.Add(Stations[i].Name);
                }
            }

            return remaingStaionsList;
        }
    }
}
