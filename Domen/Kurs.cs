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
    public class Kurs : OpstiDomenskiObjekat
    {
        int kursID;
        string nazivKursa;
        double trajanje;
        Instruktor instruktor;
        VrstaKursa vrsta;

        [DisplayName("ID")]
        public int KursID { get => kursID; set => kursID = value; }
        [DisplayName("Naziv")]
        public string NazivKursa { get => nazivKursa; set => nazivKursa = value; }
        public double Trajanje { get => trajanje; set => trajanje = value; }
        [Browsable(false)]
        public Instruktor Instruktor { get => instruktor; set => instruktor = value; }
        [Browsable(false)]
        public VrstaKursa Vrsta { get => vrsta; set => vrsta = value; }

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Kurs";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "KursID";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return $" KursID = {KursID}";
            }
        }

        [Browsable(false)]
        public string ID1
        {
            get
            {
                return "KursID";
            }
        }

        [Browsable(false)]
        public string UslovID1
        {
            get
            {
                return " KursID = " + KursID;
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
                return $"(KursID) VALUES ({KursID})";
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return $"NazivKursa = '{NazivKursa}', Trajanje = {Trajanje}, InstruktorID = {Instruktor.InstruktorID}, VrstaID = {Vrsta.VrstaID}";
            }
        }

        

        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Kurs k = new Kurs
            {
                KursID = (int)red["KursID"],
                NazivKursa = red["NazivKursa"].ToString(),
                Trajanje = (float)red["Trajanje"],
                Instruktor = new Instruktor
                {
                    InstruktorID = (int)red["InstruktorID"]
                },
                Vrsta = new VrstaKursa
                {
                    VrstaID = (int)red["VrstaID"]
                }
            };
            return k;
        }

        public OpstiDomenskiObjekat citajRedTabeleID(DataRow red)
        {
            Kurs k = new Kurs
            {
                KursID = (int)red["KursID"]
            };
            return k;
        }

        public OpstiDomenskiObjekat citajRedTabele1(DataRow red)
        {
            Kurs k = new Kurs
            {
                KursID = (int)red["KursID"],
                NazivKursa = red["NazivKursa"].ToString(),
                Trajanje = Convert.ToDouble(red["Trajanje"]),
                Instruktor = new Instruktor
                {
                    InstruktorID = (int)red["InstruktorID"]
                },
                Vrsta = new VrstaKursa
                {
                    VrstaID = (int)red["VrstaID"]
                }
            };
            return k;
        }

        string instruktorString;
        string vrstaKursaString;

        [DisplayName("Instruktor")]
        public string InstruktorString { get => Instruktor.ImePrezime; set => instruktorString = value; }
        [DisplayName("Vrsta kursa")]
        public string VrstaKursaString { get => Vrsta.NazivVrste; set => vrstaKursaString = value; }


        public override string ToString()
        {
            return NazivKursa;
        }
    }
}
