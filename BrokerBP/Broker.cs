using Domen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrokerBP
{
    public class Broker
    {
        private SqlConnection konekcija;
        private SqlCommand komanda;
        private SqlTransaction transakcija;
        private SqlDataReader citac;

        private static Broker instanca;
        public static Broker Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new Broker();
                return instanca;
            }
        }

        private Broker() { }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["baza"].ConnectionString);

                    //@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBSkolaZaDresuruPasa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                konekcija.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da se poveže na bazu!");
                throw;
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);

            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da započne transakciju!");
                throw;
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da potvrdi transakciju!");
                throw;
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da poništi transakciju!");
                throw;
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zatvori konekciju!");
                throw;
            }
        }

        public void insert(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"INSERT INTO {odo.NazivTabele} {odo.Insert}";
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void updateJedan(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"UPDATE {odo.NazivTabele} SET {odo.Update} WHERE {odo.UslovID1}";
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }

        public void updateVise(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"UPDATE {odo.NazivTabele} SET {odo.Update} WHERE {odo.OpstiUslov}";
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }

        public void deleteJedan(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"DELETE FROM {odo.NazivTabele} WHERE {odo.UslovID1}";
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteVise(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"DELETE FROM {odo.NazivTabele} WHERE {odo.OpstiUslov}";
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = $"SELECT * FROM {odo.NazivTabele}";
                citac = komanda.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(citac);

                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.citajRedTabele1(red));
                }
                citac.Close();

                return lista;
            }
            catch (Exception)
            {
                citac.Close();

                throw;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveZaOpstiUslov(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = $"SELECT * FROM {odo.NazivTabele} WHERE {odo.OpstiUslov}";
                citac = komanda.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(citac);

                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.citajRedTabele1(red));
                }
                citac.Close();

                return lista;
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveZaOpstiUslovID(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = $"SELECT * FROM {odo.NazivTabele} WHERE {odo.OpstiUslov}";
                citac = komanda.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(citac);

                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.citajRedTabele1(red));
                }
                citac.Close();

                return lista;
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public OpstiDomenskiObjekat vratiJedanZaID(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"SELECT * FROM {odo.NazivTabele} WHERE {odo.UslovID}";
                citac = komanda.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(citac);
                citac.Close();

                if (tabela.Rows.Count == 0)
                    return null;
                else
                    return odo.citajRedTabele(tabela.Rows[0]);
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public int vratiSifru(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"SELECT MAX({odo.ID1}) FROM {odo.NazivTabele}";
                try
                {
                    return Convert.ToInt32(komanda.ExecuteScalar()) + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        
       

        public void insertVise(List<OpstiDomenskiObjekat> odo)
        {
           
            try
            {
                foreach(Ocena o in odo)
                {
                    komanda = new SqlCommand();
                    komanda.Transaction = transakcija;
                    komanda.CommandText = $"INSERT INTO {o.NazivTabele} {o.Insert}";
                    komanda.Connection = konekcija;
                  
                    komanda.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
               
            }
        }
    }
}
