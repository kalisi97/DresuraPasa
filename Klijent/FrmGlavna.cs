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
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUnosInstruktora().ShowDialog();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPretragaInstruktora().ShowDialog();
        }

        private void unosNovogPasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUnosNovogPasa().ShowDialog();
        }

        private void pretragaBrisanjePasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPretragaPasa().ShowDialog();
        }

        private void unosNovogKursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUnosNovogKursa().ShowDialog();
        }

        private void pretragaKursevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPretragaKurseva().ShowDialog();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {

        }
    }
}
