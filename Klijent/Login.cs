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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /*private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.kraj();
        }*/

        /*private void FrmLogin_Load(object sender, EventArgs e)
        {

        }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = KontrolerKI.poveziSeNaServer();
            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
                return;
            }

            if (txtKorisnickoIme.Text=="admin" && txtLozinka.Text=="admin")
            {
                FrmGlavna g = new FrmGlavna();
                this.Hide();
                this.Owner = g;
                g.Show();
            }
            else
            {
                MessageBox.Show("Uneli ste neispravne podatke, pokušajte ponovo!");
                return;
            }
        }

        private void btnLoginInstruktor_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = KontrolerKI.poveziSeNaServer();
            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
                return;
            }

            if (KontrolerKI.Instanca.prijaviSe(txtKorisnickoIme, txtLozinka))
            {
                FrmPretragaKursevaZaOcenjivanje g = new FrmPretragaKursevaZaOcenjivanje();
                this.Hide();
                this.Owner = g;
                g.Show();
            }
        }
    }
}
