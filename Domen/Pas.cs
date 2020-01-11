using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Pas : OpstiDomenskiObjekat
    {
        int pasID;
        string imePrezime;
        DateTime datumRodjenja;
        string rasa;

        [DisplayName("ID")]
        public int PasID { get => pasID; set => pasID = value; }
        [DisplayName("Ime i prezime")]
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        [DisplayName("Datum rođenja")]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Rasa { get => rasa; set => rasa = value; }



        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Pas";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "PasID";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return $" PasID = {PasID}";
            }
        }

        [Browsable(false)]
        public string ID1
        {
            get
            {
                return "PasID";
            }
        }

        [Browsable(false)]
        public string UslovID1
        {
            get
            {
                return " PasID = " + PasID;
            }
        }

        public string USLOVI;

        [Browsable(false)]
        public string OpstiUslov
        {
            get
            {
                return USLOVI;
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return $"(PasID) VALUES ({PasID})";
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return $"ImePrezime = '{ImePrezime}', DatumRodjenja = '{DatumRodjenja.ToString("MM.dd.yyyy")}', Rasa = '{Rasa}'";
            }
        }



        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Pas u = new Pas
            {
                PasID = (int)red["PasID"],
                ImePrezime = red["ImePrezime"].ToString(),
                DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]),
                Rasa = red["Rasa"].ToString()
            };
            return u;
        }

        public OpstiDomenskiObjekat citajRedTabeleID(DataRow red)
        {
            Pas u = new Pas
            {
                PasID = (int)red["PasID"]
            };
            return u;
        }

        public OpstiDomenskiObjekat citajRedTabele1(DataRow red)
        {
            Pas u = new Pas
            {
                PasID = (int)red["PasID"],
                ImePrezime = red["ImePrezime"].ToString(),
                DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]),
                Rasa = red["Rasa"].ToString()
            };
            return u;
        }

        public override string ToString()
        {
            return ImePrezime;
        }
    }
}
