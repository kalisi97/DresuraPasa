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
    public partial class FrmUnosNovogKursa : Form
    {
        public FrmUnosNovogKursa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.kreirajKurs(txtID, btnKreiraj, groupBox1, btnZapamti, cmbInstruktori, cmbVrste);
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.zapamtiKurs(txtNaziv, txtTrajanje, cmbInstruktori, cmbVrste, btnKreiraj, groupBox1, this);
        }
    }
}
