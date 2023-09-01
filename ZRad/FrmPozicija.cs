using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrkanDLL;
using OrkanDLL.Models;

namespace ZRad
{
    public partial class FrmPozicija : Form
    {

        private List<Dron> dronovi;

        private List<IDisposable> subscriptions = new List<IDisposable>();
        public FrmPozicija()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int brojDronova = Convert.ToInt32(nupbrojDronova.Value);
            btnGenerate.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            nupbrojDronova.Enabled = false;

            dronovi = new List<Dron>();
            for (int i = 0; i < brojDronova; i++)
            {
                Dron dron = new Dron { Id = i + 1 };
                dron.Location = new Point(100, 100);
                dronovi.Add(dron);

                Point previousLocation = dron.Location;

                var trackerObservable = new DronPositionTrackerObservable(dron);

                var subscription = trackerObservable
                    .Subscribe(location =>
                    {
                        double distance = MathSolver.Dist(previousLocation, location);
                        if (distance >= 2)
                        {
                            MessageBox.Show($"Dron {dron.Id} se pomaknuo za {distance} metara.","Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            previousLocation = location;
                        }
                    });

                subscriptions.Add(subscription);
            }

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            TestDataGenerator.PomicanjeDrona(dronovi);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            nupbrojDronova.Enabled = true;
            btnStart.Enabled = true;
            btnGenerate.Enabled = false;

            foreach (var subscription in subscriptions)
            {
                subscription.Dispose();
            }
            subscriptions.Clear();
        }
    }
}
