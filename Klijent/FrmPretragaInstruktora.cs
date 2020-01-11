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
    public partial class FrmPretragaInstruktora : Form
    {
        public FrmPretragaInstruktora()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.pretraziInstruktore(txtKriterijum, dgvInstruktori);
        }

        private void FrmPretragaInstruktora_Load(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.vratiSveInstruktore(dgvInstruktori);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            FrmPodaciOInstruktoru f = new FrmPodaciOInstruktoru(dgvInstruktori.CurrentRow.DataBoundItem as Instruktor);
            //this.Hide();
            //this.Owner = f;
            f.ShowDialog();
        }
    }
}
