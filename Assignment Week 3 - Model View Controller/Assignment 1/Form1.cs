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
    public partial class Form1 : Form
    {
        private ITrainJourney trainJourney;
        private ITrainController trainController;

        public Form1(ITrainJourney trainJourney, ITrainController trainController)
        {
            InitializeComponent();
            this.trainJourney = trainJourney;
            this.trainController = trainController;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            trainController.NextStation();
        }

        private void btnNewDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay display1 = new TrainDisplay(trainJourney);
            display1.Show(); 
        }

        private void btnStations_Click(object sender, EventArgs e)
        {
            StationsDisplay stations = new StationsDisplay(trainController);
            stations.Show();
        }
    }
}
