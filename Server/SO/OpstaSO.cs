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
        internal Object izvrsiSO(OpstiDomenskiObjekat odo)
        {
            object rez = null;

            try
            {
                Broker.Instanca.otvoriKonekciju();
                Broker.Instanca.zapocniTransakciju();

                rez = izvrsi(odo);
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

      
        

        internal abstract object izvrsi(OpstiDomenskiObjekat odo);
    }
}
