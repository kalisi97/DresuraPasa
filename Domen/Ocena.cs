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
    public class Ocena : OpstiDomenskiObjekat
    {
        Pas pas;
        Kurs kurs;
        int ocena;
        DateTime datum;

        public Pas Pas { get => pas; set => pas = value; }
        public Kurs Kurs { get => kurs; set => kurs = value; }
        public int OcenaVrednost { get => ocena; set => ocena = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Ocene";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return $" PasID = {Pas.PasID} AND KursID = {Kurs.KursID}";
            }
        }

        [Browsable(false)]
        public string ID1
        {
            get
            {
                return "";
            }
        }

        [Browsable(false)]
        public string UslovID1
        {
            get
            {
                return $" PasID = {Pas.PasID} AND KursID = {Kurs.KursID}";
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
                return $"(PasID,KursID,Ocena,Datum) VALUES ({Pas.PasID}, {Kurs.KursID}, {OcenaVrednost}, '{Datum.ToString("dd.MM.yyyy")}')";
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return $"Ocena = {OcenaVrednost}, Datum = '{Datum.ToString("dd.MM.yyyy")}'";
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
            Ocena c = new Ocena
            {
                Pas = new Pas
                {
                    PasID = (int)red["PasID"]
                },
                Kurs = new Kurs
                {
                    KursID = (int)red["KursID"]
                }
            };
            return c;
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
    }
}
