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
    public partial class FrmPretragaKurseva : Form
    {
        public FrmPretragaKurseva()
        {
            InitializeComponent();
        }

        private void FrmPretragaKurseva_Load(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.popuniDGV(dgvKursevi);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            KontrolerKI.Instanca.pretraziKurseve(txtKriterijum, dgvKursevi);
        }
    }
}
