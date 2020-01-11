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
    public partial class FrmOcenjivanje : Form
    {
        public FrmOcenjivanje(Kurs kurs)
        {
            InitializeComponent();

            KontrolerKI.Instanca.kurs1 = kurs;
        }

        private void FrmOcenjivanje_Load(object sender, EventArgs e)
        {

            KontrolerKI.Instanca.popuniCmbPsi(cmbPsi);
        }

     
       
 

        private void btnDodajOcenu_Click(object sender, EventArgs e)
        {

            KontrolerKI.Instanca.kreirajOcenu(btnDodajOcenu, dgvOcene, groupBox1, btnSacuvajOcene, cmbPsi, txtOcena, txtDatum);

        }

        private void btnSacuvajOcene_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.zapamtiOcene(dgvOcene, btnSacuvajOcene, this);
        }
    }
}
