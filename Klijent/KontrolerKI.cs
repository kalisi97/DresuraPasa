using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    internal class KontrolerKI
    {
        public static Instruktor instruktor;
        internal Instruktor inst = new Instruktor();
        internal Pas pas = new Pas();
        internal Kurs kurs = new Kurs();
        internal Kurs kurs1 = new Kurs();
   
        private DataGridView dgvInstruktori, dgvUcesnici, dgvKursevi;
        private BindingList<Ocena> ocene = new BindingList<Ocena>();
        #region Singleton
        private static KontrolerKI instanca;
       
        public static KontrolerKI Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new KontrolerKI();
                return instanca;
            }
        }

      

        internal void pretraziKurseveZaInstruktora(TextBox txtKriterijum, DataGridView dgvKursevi)
        {

            kurs = new Kurs();
            kurs.USLOVI = $"NazivKursa LIKE '%{txtKriterijum.Text}%' AND InstruktorId = {instruktor.InstruktorID}";
            List<Kurs> kursevi = (List<Kurs>)Komunikacija.Instanca.pretraziKurseve(kurs);
            if (kursevi.Count == 0)
            {
                MessageBox.Show("Nijedan kurs nije pronađen!");
                txtKriterijum.Clear();
                return;
            }
            else
            {
                List<Instruktor> instruktori = (List<Instruktor>)Komunikacija.Instanca.ucitajInstruktore();
                List<VrstaKursa> vrste = (List<VrstaKursa>)Komunikacija.Instanca.ucitajVrsteKursa();
                foreach (Kurs k in kursevi)
                {
                    foreach (Instruktor p in instruktori)
                    {
                        if (k.Instruktor.InstruktorID == p.InstruktorID)
                        {
                            k.Instruktor = p;
                        }
                    }

                    foreach (VrstaKursa vk in vrste)
                    {
                        if (k.Vrsta.VrstaID == vk.VrstaID)
                        {
                            k.Vrsta = vk;
                        }
                    }
                }
                dgvKursevi.DataSource = new BindingList<Kurs>(kursevi);
            }
        }

        internal void zapamtiOcene(DataGridView dgvOcene, Button btnSacuvajOcene, FrmOcenjivanje frmOcenjivanje)
        {
            
         if(Komunikacija.Instanca.zapamtiOcene(ocene))
            {
                MessageBox.Show("Ocene uspesno sacuvane!");
                btnSacuvajOcene.Enabled = false;
                dgvOcene.DataSource = null;
                frmOcenjivanje.Close();
            }
            else
            {
                MessageBox.Show("Ocene nisu uspesno sacuvane!");
                return;
            }
        }






        #endregion

        internal static string poveziSeNaServer()
        {
            if (Komunikacija.Instanca.poveziSe())
            {
                return "Klijent je povezan na server!";
            }
            else
            {
                throw new Exception("Klijent nije povezan na server!");
            }
        }

        internal bool prijaviSe(TextBox txtKorisnickoIme, TextBox txtLozinka)
        {
            instruktor = new Instruktor();
            instruktor.KorisnickoIme = txtKorisnickoIme.Text;
            instruktor.Lozinka = txtLozinka.Text;

            instruktor = (Instruktor)Komunikacija.Instanca.prijaviSe(instruktor);

            if (instruktor == null)
            {
                MessageBox.Show("Neuspešno prijavljivanje na sistem!");
                return false;
            }
            else
            {
                MessageBox.Show("Uspešno prijavljivanje na sistem!");
                return true;
            }
        }

        internal void zapamtiInstruktora(TextBox txtIme, TextBox txtPrezime, TextBox txtEmail, TextBox txtRasa, TextBox txtKorisnickoIme, TextBox txtSifra, TextBox txtID, Button btnKreiraj, Label lbl, frmUnosInstruktora frm)
        {
            lbl.Text = "";

            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                lbl.Text = "Ime nije ispravno uneto!";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                lbl.Text = "Prezime nije ispravno uneto!";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lbl.Text = "Email nije ispravno unet!";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRasa.Text))
            {
                lbl.Text = "Telefon nije ispravno unet!";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                lbl.Text = "Korisnicko ime nije ispravno uneto!";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                lbl.Text = "Sifra nije ispravno uneta!";
                return;
            }


            inst.ImePrezime = txtIme.Text+" "+txtPrezime.Text;
            inst.Email = txtEmail.Text;
            inst.Telefon = txtRasa.Text;
            inst.KorisnickoIme = txtKorisnickoIme.Text;
            inst.Lozinka = txtSifra.Text;

            if (!Komunikacija.Instanca.zapamtiInstruktora(inst))
            {
                MessageBox.Show("Sistem ne može da zapamti podatke o instruktoru!");
                frm.Close();
                return;
            }

            MessageBox.Show("Sistem je zapamtio podatke o instruktoru.");
            txtIme.Clear();
            txtPrezime.Clear();
            txtEmail.Clear();
            txtRasa.Clear();
            txtKorisnickoIme.Clear();
            txtSifra.Clear();
            txtID.Clear();
            btnKreiraj.Enabled = true;
        }

        internal void kreirajInstruktora(TextBox txtID, Button btnKreiraj, GroupBox gbPodaci, Button btnZapamti)
        {
            inst = (Instruktor)Komunikacija.Instanca.kreirajInstruktora();
            if (inst == null)
            {
                MessageBox.Show("Sistem ne može da kreira instruktora!");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je kreirao instruktora!");
                txtID.Text = inst.InstruktorID.ToString();
                btnKreiraj.Enabled = false;
                btnZapamti.Enabled = true;
                gbPodaci.Enabled = true;
            }
        }

        internal void kreirajPsa(TextBox txtID, Button btnKreiraj, GroupBox gbPodaci, Button btnZapamti)
        {
            pas = (Pas)Komunikacija.Instanca.kreirajPsa();
            if (pas == null)
            {
                MessageBox.Show("Sistem ne može da kreira psa!");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je kreirao psa!");
                txtID.Text = pas.PasID.ToString();
                btnKreiraj.Enabled = false;
                btnZapamti.Enabled = true;
                gbPodaci.Enabled = true;
            }
        }

        internal void zapamtiPsa(TextBox txtIme, TextBox txtDatum, TextBox txtRasa, TextBox txtID, Button btnKreiraj, FrmUnosNovogPasa frm)
        {

            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Ime nije ispravno uneto!");
                return;
            }
         
            try
            {
                pas.DatumRodjenja = DateTime.ParseExact(txtDatum.Text, "MM.dd.yyyy", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite datum rodjenja u sledećem formatu: MM.dd.yyyy");
                txtDatum.Clear();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRasa.Text))
            {
                MessageBox.Show("Rasa nije ispravno uneta!");
                return;
            }

            pas.ImePrezime = txtIme.Text;
            pas.Rasa = txtRasa.Text;

            if (!Komunikacija.Instanca.zapamtiPsa(pas))
            {
                MessageBox.Show("Sistem ne može da zapamti poodatke o psu.");
                frm.Close();
                return;
            }

            MessageBox.Show("Sistem je zapamtio podatke o psu.");
            txtIme.Clear();
  
            txtDatum.Clear();
            txtRasa.Clear();
            txtID.Clear();
            btnKreiraj.Enabled = true;
        }

        internal void kreirajKurs(TextBox txtID, Button btnKreiraj, GroupBox gbPodaci, Button btnZapamti, ComboBox cmbInstruktori, ComboBox cmbVrste)
        {
            kurs = (Kurs)Komunikacija.Instanca.kreirajKurs();
            if (kurs == null)
            {
                MessageBox.Show("Sistem ne može da kreira kurs!");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je kreirao kurs!");
                txtID.Text = kurs.KursID.ToString();
                btnKreiraj.Enabled = false;
                btnZapamti.Enabled = true;
                gbPodaci.Enabled = true;

                List<VrstaKursa> vrste = (List<VrstaKursa>)Komunikacija.Instanca.ucitajVrsteKursa();
                if (vrste.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da učita vrste kursa!");
                    return;
                }
                cmbVrste.DataSource = vrste;
                cmbVrste.DisplayMember = "NazivVrste";
                cmbVrste.SelectedItem = null;

                List<Instruktor> instruktori = new List<Instruktor>();
                instruktori = (List<Instruktor>)Komunikacija.Instanca.ucitajInstruktore();
                if (instruktori.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da učita instruktore!");
                    return;
                }
                cmbInstruktori.DataSource = instruktori;
                cmbInstruktori.DisplayMember = "ImePrezime";
                cmbInstruktori.SelectedItem = null;

                
            }
        }

        internal void zapamtiKurs(TextBox txtNaziv, TextBox txtTrajanje, ComboBox cmbInstruktori, ComboBox cmbVrste, Button btnKreiraj, GroupBox gbPodaci, FrmUnosNovogKursa frm)
        {

            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv nije ispravno unet!");
                return;
            }

            if (cmbInstruktori.SelectedItem == null)
            {
                MessageBox.Show("Instruktor nije odabran!");
                return;
            }
            kurs.Instruktor = (Instruktor)cmbInstruktori.SelectedItem;
            if (cmbVrste.SelectedItem == null)
            {
                MessageBox.Show("Vrsta kursa nije odabrana!");
                return;
            }
            kurs.Vrsta = (VrstaKursa)cmbVrste.SelectedItem;

            try
            {
                
                kurs.Trajanje = (float)Convert.ToDouble(txtTrajanje.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Trajanje nije ispravno uneto!");
                txtTrajanje.Clear();
                return;
            }

            kurs.NazivKursa = txtNaziv.Text;

            if (!Komunikacija.Instanca.zapamtiKurs(kurs))
            {
                MessageBox.Show("Sistem ne može da zapamti poodatke o kursu.");
                frm.Close();
                return;
            }

            MessageBox.Show("Sistem je zapamtio podatke o kursu.");
            txtNaziv.Clear();
            txtTrajanje.Clear();
            gbPodaci.Enabled = false;
            cmbInstruktori.SelectedItem = null;
            cmbVrste.SelectedItem = null;
            btnKreiraj.Enabled = true;
        }

        internal void pretraziInstruktore(TextBox txtKriterijum, DataGridView dgvInstruktori)
        {
            inst = new Instruktor();
            inst.USLOVI = $"ImePrezime LIKE '%{txtKriterijum.Text}%' OR Email LIKE '%{txtKriterijum.Text}%'";
            List<Instruktor> instruktori = (List<Instruktor>)Komunikacija.Instanca.pretraziInstruktore(inst);
            if (instruktori.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe instruktore po zadatoj vrednosti!");
                txtKriterijum.Clear();
                return;
            }
            else
            {
                dgvInstruktori.DataSource = new BindingList<Instruktor>(instruktori);
            }
        }

        internal void vratiSveInstruktore(DataGridView dgvInstruktori)
        {
            this.dgvInstruktori = dgvInstruktori;
            inst = new Instruktor();
            inst.USLOVI = "ImePrezime NOT LIKE ' '";
            List<Instruktor> instruktori = (List<Instruktor>)Komunikacija.Instanca.pretraziInstruktore(inst);
            dgvInstruktori.DataSource = new BindingList<Instruktor>(instruktori);
        }

        internal void prikaziPodatkeOInstruktoru(TextBox txtID, TextBox txtImePrezime, TextBox txtEmail, TextBox txtRasa, TextBox txtKorisnickoIme, TextBox txtLozinka, FrmPodaciOInstruktoru forma)
        {
            try
            {
                txtID.Text = inst.InstruktorID.ToString();
                txtImePrezime.Text = inst.ImePrezime;
                txtEmail.Text = inst.Email;
                txtRasa.Text = inst.Telefon;
                txtKorisnickoIme.Text = inst.KorisnickoIme;
                txtLozinka.Text = inst.Lozinka;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o odabranom instruktoru!");
                forma.Close();
                return;
            }
        }

        internal void izmeniInstruktora(TextBox txtID, TextBox txtImePrezime, TextBox txtEmail, TextBox txtRasa, TextBox txtKorisnickoIme, TextBox txtLozinka, Button btnSacuvaj, FrmPodaciOInstruktoru frm)
        {
            txtImePrezime.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtRasa.ReadOnly = false;
            txtKorisnickoIme.ReadOnly = false;
            txtLozinka.ReadOnly = false;
            btnSacuvaj.Enabled = true;

            inst.InstruktorID = Convert.ToInt32(txtID.Text);
        }

        internal void sacuvajIzmene(TextBox txtID, TextBox txtImePrezime, TextBox txtEmail, TextBox txtRasa, TextBox txtKorisnickoIme, TextBox txtLozinka, FrmPodaciOInstruktoru forma)
        {
            inst.ImePrezime = txtImePrezime.Text;
            inst.Email = txtEmail.Text;
            inst.Telefon = txtRasa.Text;
            inst.KorisnickoIme = txtKorisnickoIme.Text;
            inst.Lozinka = txtLozinka.Text;

            if (Komunikacija.Instanca.sacuvajIzmene(inst))
            {
                MessageBox.Show("Instruktor je izmenjen!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da sačuva izmene!");
            }
            forma.Close();
            return;
        }

        internal void obrisiInstruktora(TextBox txtID, FrmPodaciOInstruktoru forma)
        {
            inst = new Instruktor
            {
                InstruktorID = Convert.ToInt32(txtID.Text)
            };

            if (!Komunikacija.Instanca.obrisiInstruktora(inst))
            {
                MessageBox.Show("Sistem ne može da obriše odabranog instruktora!");
                return;
            }

            MessageBox.Show("Instruktor je izbrisan!");
            forma.Close();
            vratiSveInstruktore(dgvInstruktori);
            return;
        }

        internal void pretraziPse(TextBox txtKriterijum, DataGridView dgvUcesnici)
        {
            pas = new Pas();
            pas.USLOVI = $"ImePrezime LIKE '%{txtKriterijum.Text}%'";
            List<Pas> ucesnici = (List<Pas>)Komunikacija.Instanca.pretraziPse(pas);
            if (ucesnici.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe pse po zadatoj vrednosti!");
                txtKriterijum.Clear();
                return;
            }
            else
            {
                MessageBox.Show("Sistem je našao pse po zadatoj vrednosti!");
                dgvUcesnici.DataSource = new BindingList<Pas>(ucesnici);
            }
        }

        internal void vratiSvePse(DataGridView dgvUcesnici)
        {
            this.dgvUcesnici = dgvUcesnici;
            pas = new Pas();
            pas.USLOVI = "ImePrezime NOT LIKE ' '";
            List<Pas> ucesnici = (List<Pas>)Komunikacija.Instanca.pretraziPse(pas);
            dgvUcesnici.DataSource = new BindingList<Pas>(ucesnici);
        }


        internal void prikaziPodatkeOPsu(TextBox txtID, TextBox txtImePrezime, TextBox txtDatum, TextBox txtRasa, FrmPodaciOPsu forma)
        {
            try
            {
                txtID.Text = pas.PasID.ToString();
                txtImePrezime.Text = pas.ImePrezime;
                txtDatum.Text = pas.DatumRodjenja.ToShortDateString();
                txtRasa.Text = pas.Rasa;

            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o odabranom psu!");
                forma.Close();
                return;
            }
        }

        internal void obrisiPsa(TextBox txtID, FrmPodaciOPsu forma)
        {
            pas = new Pas
            {
                PasID = Convert.ToInt32(txtID.Text)
            };

            if (!Komunikacija.Instanca.obrisiPasa(pas))
            {
                MessageBox.Show("Sistem ne može da obriše odabranog psa!");
                return;
            }

            MessageBox.Show("Sistem je obrisao psa!");
            forma.Close();
            vratiSvePse(dgvUcesnici);
            return;
        }

        internal void vratiSveKurseve(DataGridView dgvKursevi)
        {
            this.dgvKursevi = dgvKursevi;
            kurs = new Kurs();
            kurs.USLOVI = "NazivKursa NOT LIKE ' '";
            List<Kurs> kursevi = (List<Kurs>)Komunikacija.Instanca.pretraziKurseve(kurs);
            dgvKursevi.DataSource = new BindingList<Kurs>(kursevi);
        }

        internal void pretraziKurseve(TextBox txtKriterijum, DataGridView dgvKursevi)
        {
            kurs = new Kurs();
            kurs.USLOVI = $"NazivKursa LIKE '%{txtKriterijum.Text}%'";
            List<Kurs> kursevi = (List<Kurs>)Komunikacija.Instanca.pretraziKurseve(kurs);
            if (kursevi.Count == 0)
            {
                MessageBox.Show("Nijedan kurs nije pronađen!");
                txtKriterijum.Clear();
                return;
            }
            else
            {
                List<Instruktor> instruktori = (List<Instruktor>)Komunikacija.Instanca.ucitajInstruktore();
                List<VrstaKursa> vrste = (List<VrstaKursa>)Komunikacija.Instanca.ucitajVrsteKursa();
                foreach (Kurs k in kursevi)
                {
                    foreach (Instruktor p in instruktori)
                    {
                        if (k.Instruktor.InstruktorID == p.InstruktorID)
                        {
                            k.Instruktor = p;
                        }
                    }

                    foreach (VrstaKursa vk in vrste)
                    {
                        if (k.Vrsta.VrstaID == vk.VrstaID)
                        {
                            k.Vrsta = vk;
                        }
                    }
                }
                dgvKursevi.DataSource = new BindingList<Kurs>(kursevi);
            }
        }

        internal void popuniDGV(DataGridView dgvPodaci)
        {
            List<Kurs> kursevi = (List<Kurs>)Komunikacija.Instanca.vratiSveKurseve();

            List<Instruktor> instruktori = (List<Instruktor>)Komunikacija.Instanca.ucitajInstruktore();
            List<VrstaKursa> vrste = (List<VrstaKursa>)Komunikacija.Instanca.ucitajVrsteKursa();
            foreach (Kurs k in kursevi)
            {
                foreach (Instruktor p in instruktori)
                {
                    if (k.Instruktor.InstruktorID == p.InstruktorID)
                    {
                        k.Instruktor = p;
                    }
                }

                foreach (VrstaKursa vk in vrste)
                {
                    if (k.Vrsta.VrstaID == vk.VrstaID)
                    {
                        k.Vrsta = vk;
                    }
                }
            }

            dgvPodaci.DataSource = new BindingList<Kurs>(kursevi);

         
        }

  

        internal void popuniCmbKurseva(ComboBox cmbKursevi)
        {
            List<Kurs> kursevi = new List<Kurs>();
            kursevi = (List<Kurs>)Komunikacija.Instanca.vratiSveKurseve();
            if (kursevi.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita kurseve!");
                return;
            }
            cmbKursevi.DataSource = kursevi;
            cmbKursevi.DisplayMember = "NazivKursa";
            cmbKursevi.SelectedItem = null;
        }

        internal void popuniCmbPsi(ComboBox cmbPsi)
        {
            List<Pas> psi = new List<Pas>();
            psi = (List<Pas>)Komunikacija.Instanca.vratiSvePse();
            if (psi.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita pse!");
                return;
            }
            cmbPsi.DataSource = psi;
            cmbPsi.DisplayMember = "ImePrezime";
            cmbPsi.SelectedItem = null;
        }
 




        internal void kreirajOcenu(Button btnDodajOcenu, DataGridView dgvOcene, GroupBox groupBox1, Button btnSacuvajOcene, ComboBox cmbPsi, TextBox txtOcena, TextBox txtDatum)
        {
            Ocena ocena = new Ocena();
            ocena.Kurs = kurs1;
            if (cmbPsi.SelectedItem == null)
            {
                MessageBox.Show("Pas nije odabran!");
                return;
            }
           ocena.Pas = (Pas)cmbPsi.SelectedItem;

        

                try
                {
                    if (string.IsNullOrWhiteSpace(txtOcena.Text))
                    {
                        MessageBox.Show("Ocena nije ispravno uneta!");
                        return;
                    }

                    try
                    {

                        ocena.OcenaVrednost = Convert.ToInt32(txtOcena.Text);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocena nije ispravno uneta!");
                        txtOcena.Clear();
                        return;
                    }

                    if (ocena.OcenaVrednost < 5 && ocena.OcenaVrednost > 10)
                    {
                        MessageBox.Show("Ocena mora biti između 5 i 10!");
                        txtOcena.Clear();
                        return;
                    }

                    try
                    {
                        ocena.Datum = DateTime.ParseExact(txtDatum.Text, "MM.dd.yyyy", null);
                    if (ocena.Datum < ocena.Pas.DatumRodjenja.AddMonths((int)ocena.Kurs.Trajanje)) throw new Exception();
                   
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unesite datum u sledećem formatu: MM.dd.yyyy");
                        txtDatum.Clear();
                        return;
                    }


                
                if (VecUneta(ocena.Pas.PasID,ocena.Kurs.KursID))
                {
                    MessageBox.Show("Vec je uneta ocena za ovog psa i dati kurs!");
                    throw new Exception();
                }
                  


                    MessageBox.Show("Uspesno je uneta ocena!");
                    btnDodajOcenu.Enabled = true;
                    btnSacuvajOcene.Enabled = true;
                    groupBox1.Enabled = true;
                    ocene.Add(ocena);
                    dgvOcene.DataSource = ocene;
                }catch(Exception)
                {
                MessageBox.Show("Neuspesno uneta ocena!");
                txtDatum.Clear();
                txtOcena.Clear();
                cmbPsi.SelectedItem = null;
                return;
                }
            
        }

        private bool VecUneta(int pasID,  int kursID)
        {
            Ocena unetaOcena = null;
            foreach(Ocena o in ocene)
            {
                if(o.Pas.PasID == pasID && o.Kurs.KursID == kursID)
                {
                    unetaOcena = o;
                }
            }

            if (unetaOcena != null) return true;
            return false;
        }

        internal void prikaziKurseveZaInstruktora(DataGridView dgvPodaci)
        {
            try
            {
                List<Kurs> kursevi = (List<Kurs>)Komunikacija.Instanca.ucitajKurseveZaInstruktora(instruktor);
                dgvPodaci.DataSource = new BindingList<Kurs>(kursevi);

            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita pse!");
                return;
            }
        }
    }
}
