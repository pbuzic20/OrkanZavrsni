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
    public partial class FrmBaterija : Form
    {

        private List<Dron> dronovi = new List<Dron>();
        private IDisposable pretplata;

        public FrmBaterija()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnGenerirajPodatke.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            nudBrojDronova.Enabled = false;

            int brojDronova = Convert.ToUInt16(nudBrojDronova.Value);
            if (FormationChecker.ProvjeraDronova(brojDronova))
            {
                for (int i = 0; i < brojDronova; i++)
                {
                    var dron = new Dron();
                    dronovi.Add(dron);
                    int dronId = i + 1;

                    var batteryObservable = new BatteryLowObservable(dron);

                    var subscription = batteryObservable.Subscribe(batteryStatus =>
                    {
                        MessageBox.Show($"Dron {dronId} ima manje od 20% baterije: {batteryStatus}%", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    });
                }
            }
            else
            {
                MessageBox.Show("Neispravan broj dronova", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerirajPodatke_Click(object sender, EventArgs e)
        {
            TestDataGenerator.GenerirajPodatkeBaterije(dronovi);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            nudBrojDronova.Enabled = true;
            btnStop.Enabled = false;
            btnGenerirajPodatke.Enabled = false;
            pretplata?.Dispose();
            dronovi.Clear();
        }
    }
}
