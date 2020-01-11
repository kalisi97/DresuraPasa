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
    public class Instruktor : OpstiDomenskiObjekat
    {
        int instruktorID;
        string imePrezime;
        string email;
        string telefon;
        string korisnickoIme;
        string lozinka;

        [DisplayName("ID")]
        public int InstruktorID { get => instruktorID; set => instruktorID = value; }
        [DisplayName("Ime i prezime")]
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public string Email { get => email; set => email = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        [Browsable(false)]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        [Browsable(false)]
        public string Lozinka { get => lozinka; set => lozinka = value; }

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Instruktor";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "KorisnickoIme";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return $" KorisnickoIme = '{KorisnickoIme}' AND Lozinka = '{Lozinka}'";
            }
        }

        [Browsable(false)]
        public string ID1
        {
            get
            {
                return "InstruktorID";
            }
        }

        [Browsable(false)]
        public string UslovID1
        {
            get
            {
                return " InstruktorID = " + InstruktorID;
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
                return $"(InstruktorID) VALUES ({InstruktorID})";
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return $"ImePrezime = '{ImePrezime}', Email = '{Email}', Telefon = '{Telefon}', KorisnickoIme = '{KorisnickoIme}', Lozinka = '{Lozinka}'";
            }
        }

        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Instruktor p = new Instruktor
            {
                InstruktorID = (int)red["InstruktorID"],
                ImePrezime = red["ImePrezime"].ToString(),
                Email = red["Email"].ToString(),
                Telefon = red["Telefon"].ToString(),
                KorisnickoIme = red["KorisnickoIme"].ToString(),
                Lozinka = red["Lozinka"].ToString()
            };
            return p;
        }

        public OpstiDomenskiObjekat citajRedTabele1(DataRow red)
        {
            Instruktor p = new Instruktor
            {
                InstruktorID = (int)red["InstruktorID"],
                ImePrezime = red["ImePrezime"].ToString(),
                Email = red["Email"].ToString(),
                Telefon = red["Telefon"].ToString(),
                KorisnickoIme = red["KorisnickoIme"].ToString(),
                Lozinka = red["Lozinka"].ToString()              
            };
            return p;
        }

        public OpstiDomenskiObjekat citajRedTabeleID(DataRow red)
        {
            Instruktor p = new Instruktor
            {
                KorisnickoIme = red["KorisnickoIme"].ToString()
            };
            return p;
        }

        /*public override string ToString()
        {
            return ImePrezime;
        }*/
    }
}
