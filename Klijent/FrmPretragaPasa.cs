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
    public partial class FrmPretragaPasa : Form
    {
        public FrmPretragaPasa()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.pretraziPse(txtKriterijum, dgvUcesnici);
        }

        private void FrmPretragaPasa_Load(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.vratiSvePse(dgvUcesnici);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            FrmPodaciOPsu f = new FrmPodaciOPsu(dgvUcesnici.CurrentRow.DataBoundItem as Pas);
            //this.Hide();
            //this.Owner = f;
            f.ShowDialog();
        }
    }
}
