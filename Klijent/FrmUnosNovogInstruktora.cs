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
    public partial class frmUnosInstruktora : Form
    {
        public frmUnosInstruktora()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.kreirajInstruktora(txtID, btnKreiraj, groupBox1, btnZapamti);
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.zapamtiInstruktora(txtIme, txtPrezime, txtEmail, txtRasa, txtKorisnickoIme, txtSifra, txtID, btnKreiraj, lbl, this);
        }
    }
}
