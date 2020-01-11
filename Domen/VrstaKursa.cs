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
    public class VrstaKursa : OpstiDomenskiObjekat
    {
        int vrstaID;
        string nazivVrste;

        public int VrstaID { get => vrstaID; set => vrstaID = value; }
        public string NazivVrste { get => nazivVrste; set => nazivVrste = value; }

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "VrstaKursa";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "VrstaID";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return $" VrstaID = {VrstaID}";
            }
        }

        [Browsable(false)]
        public string ID1
        {
            get
            {
                return "VrstaID";
            }
        }

        [Browsable(false)]
        public string UslovID1
        {
            get
            {
                return " VrstaID = " + VrstaID;
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
                return $"(VrstaID) VALUES ({VrstaID})";
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return $"NazivVrste = '{NazivVrste}'";
            }
        }



        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            VrstaKursa vk = new VrstaKursa
            {
                VrstaID = (int)red["VrstaID"],
                NazivVrste = red["NazivVrste"].ToString()
            };
            return vk;
        }

        public OpstiDomenskiObjekat citajRedTabeleID(DataRow red)
        {
            VrstaKursa vk = new VrstaKursa
            {
                VrstaID = (int)red["VrstaID"]
            };
            return vk;
        }

        public OpstiDomenskiObjekat citajRedTabele1(DataRow red)
        {
            VrstaKursa vk = new VrstaKursa
            {
                VrstaID = (int)red["VrstaID"],
                NazivVrste = red["NazivVrste"].ToString()
            };
            return vk;
        }

        /*public override string ToString()
        {
            return NazivVrste;
        }*/
    }
}
