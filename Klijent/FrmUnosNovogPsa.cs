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
    public partial class FrmUnosNovogPasa : Form
    {
        public FrmUnosNovogPasa()
        {
            InitializeComponent();
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.zapamtiPsa(txtIme, txtDatum, txtRasa, txtID, btnKreiraj, this);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.kreirajPsa(txtID, btnKreiraj, groupBox1, btnZapamti);
        }
    }
}
