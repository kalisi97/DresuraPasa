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
    public partial class FrmPodaciOInstruktoru : Form
    {
        public FrmPodaciOInstruktoru(Instruktor instruktor)
        {
            InitializeComponent();
            KontrolerKI.Instanca.inst = instruktor;
        }

        private void FrmPodaciOInstruktoru_Load(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.prikaziPodatkeOInstruktoru(txtID, txtImePrezime, txtEmail, txtRasa, txtKorisnickoIme, txtLozinka, this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.izmeniInstruktora(txtID, txtImePrezime, txtEmail, txtRasa, txtKorisnickoIme, txtLozinka, btnSacuvaj, this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.sacuvajIzmene(txtID, txtImePrezime, txtEmail, txtRasa, txtKorisnickoIme, txtLozinka, this);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.obrisiInstruktora(txtID, this);
        }
    }
}
