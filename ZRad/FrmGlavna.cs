namespace ZRad
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
            this.FormClosing += FrmGlavna_FormClosing;
        }

        private void btnBaterija_Click(object sender, EventArgs e)
        {
            FrmBaterija frmBaterija = new FrmBaterija();
            frmBaterija.Show();
        }

        private void FrmGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnFormacija_Click(object sender, EventArgs e)
        {
            FrmFormacija frmFormacija = new FrmFormacija();
            frmFormacija.Show();
        }

        private void btnPomicanje_Click(object sender, EventArgs e)
        {
            FrmPozicija frmPozicija = new FrmPozicija();
            frmPozicija.Show();
        }
    }
}