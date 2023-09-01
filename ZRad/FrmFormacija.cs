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
    public partial class FrmFormacija : Form
    {

        private List<Dron> dronovi = new List<Dron>();
        private IDisposable locationSubscription;

        public FrmFormacija()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            nupbrojDronova.Enabled = false;
            int brojDronova = Convert.ToInt32(nupbrojDronova.Value);
            if (FormationChecker.ProvjeraDronova(brojDronova))
            {
                List<Point> fakeLokacije = TestDataGenerator.KreirajPocetnePozicijeDronovaZaFormacije(brojDronova);

                for (int i = 0; i < brojDronova; i++)
                {
                    dronovi.Add(TestDataGenerator.DodijeliPocetniPolozajDrona(fakeLokacije[i]));
                }

                foreach (var dron in dronovi)
                {

                    var formationObservable = new FormationObservable(dron);

                    formationObservable.Subscribe(location =>
                    {
                        this.Invalidate();
                        if (FormationChecker.ProvjeriFormaciju(dronovi))
                        {
                            lblFormation.ForeColor = Color.Green;
                            lblFormation.Text = "Formacija je ispravna!";
                        }
                        else
                        {
                            lblFormation.ForeColor = Color.Red;
                            lblFormation.Text = "Formacija nije ispravna!";
                        }
                    });
                }
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            foreach (var dron in dronovi)
            {
                int velicinaDrona = 10;
                Brush bojaDrona = Brushes.Red;

                g.FillEllipse(bojaDrona, dron.Location.X, dron.Location.Y, velicinaDrona, velicinaDrona);
            }

            for (int i = 0; i < dronovi.Count - 1; i++)
            {
                g.DrawLine(Pens.Black, dronovi[i].Location, dronovi[i + 1].Location);
            }

            if (dronovi.Count > 2)
            {
                g.DrawLine(Pens.Black, dronovi[dronovi.Count - 1].Location, dronovi[0].Location);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            TestDataGenerator.KreirajNasumicnePozicijeDronovaZaFormacije(Convert.ToInt16(nupbrojDronova.Value), dronovi);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            nupbrojDronova.Enabled = true;
            lblFormation.ForeColor = Color.White;

            dronovi.Clear();

            locationSubscription?.Dispose();

            this.Invalidate();
        }
    }
}
