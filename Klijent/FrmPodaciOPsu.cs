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
    public partial class FrmPodaciOPsu : Form
    {
        public FrmPodaciOPsu(Pas pas)
        {
            InitializeComponent();
            KontrolerKI.Instanca.pas = pas;
        }

        private void FrmPodaciOPasu_Load(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.prikaziPodatkeOPsu(txtID, txtImePrezime, txtDatum, txtRasa, this);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.obrisiPsa(txtID, this);
        }
    }
}
