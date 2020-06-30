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
    public partial class StationsDisplay : Form
    {
        private ITrainController trainController;

        public StationsDisplay(ITrainController trainController)
        {
            InitializeComponent();
            this.trainController = trainController;
            RemainingStations();
        }

        private void RemainingStations()
        {
            lstStations.Clear();

            lstStations.GridLines = true;
            lstStations.View = View.Details;
            lstStations.Columns.Add("Stations:", 150, HorizontalAlignment.Center);

            List<string> stations = trainController.RemainingStations();

            foreach (string item in stations)
            {
                ListViewItem li = new ListViewItem(item);
                lstStations.Items.Add(li);

            }

        }

    }
}
