using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal abstract class OpstaSOUnosOcena
    {
        internal bool izvrsiSO(List<OpstiDomenskiObjekat> odo)
        {
            object rez = null;
            bool uspesno = false;
            try
            {
                Broker.Instanca.otvoriKonekciju();
                Broker.Instanca.zapocniTransakciju();

                rez = izvrsi(odo);
                if (rez != null) uspesno = true;
                Broker.Instanca.potvrdiTransakciju();
            }
            catch (Exception)
            {
                uspesno = false;
                Broker.Instanca.ponistiTransakciju();
            }
            finally
            {
                Broker.Instanca.zatvoriKonekciju();
            }

            return uspesno;
        }




        internal abstract object izvrsi(List<OpstiDomenskiObjekat> odo);
    }
}