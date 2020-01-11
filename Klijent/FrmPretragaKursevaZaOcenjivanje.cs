using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmPretragaKursevaZaOcenjivanje : Form
    {
        public FrmPretragaKursevaZaOcenjivanje()
        {
            InitializeComponent();
        }

        private void FrmPretragaPasaZaOcenjivanje_Load(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.prikaziKurseveZaInstruktora(dgvKursevi);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.pretraziKurseveZaInstruktora(txtKriterijum, dgvKursevi);
        }

        private void btnOcena_Click(object sender, EventArgs e)
        {
            FrmOcenjivanje f = new FrmOcenjivanje(dgvKursevi.CurrentRow.DataBoundItem as Kurs);
            //this.Hide();
            //this.Owner = f;
            f.ShowDialog();
        }
    }
}
