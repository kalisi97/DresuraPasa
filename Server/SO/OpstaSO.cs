using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal abstract class OpstaSO
    {
        internal Object izvrsiSO(object odo)
        {
            object rez = null;

            try
            {
                Broker.Instanca.otvoriKonekciju();
                Broker.Instanca.zapocniTransakciju();
                if (odo is OpstiDomenskiObjekat)
                {
                    rez = izvrsi((OpstiDomenskiObjekat)odo);
                }
                else
                {
                    rez = izvrsi((List<OpstiDomenskiObjekat>)odo);
                }
                Broker.Instanca.potvrdiTransakciju();
            }
            catch (Exception)
            {
                Broker.Instanca.ponistiTransakciju();
            }
            finally
            {
                Broker.Instanca.zatvoriKonekciju();
            }

            return rez;
        }

      
        

        internal abstract object izvrsi(object odo);
    }
}
