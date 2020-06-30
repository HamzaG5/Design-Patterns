using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class TrainDisplay : Form, IObserver
    {
        private ITrainJourney trainJourney;

        public TrainDisplay(ITrainJourney trainJourney)
        {
            InitializeComponent();

            this.trainJourney = trainJourney;
            this.trainJourney.AddObserver(this);
            Update(this.trainJourney.CurrentStation);
        }

        public void Update(Station currentStation)
        {
            lblStation.Text = currentStation.Name;
            lblPlatform.Text = currentStation.ArrivalTrack;
        }
    }
}
