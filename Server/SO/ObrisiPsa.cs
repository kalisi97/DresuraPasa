using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class ObrisiPsa : OpstaSO
    {
        internal override object izvrsi(OpstiDomenskiObjekat odo)
        {
            try
            {
                Pas u = (Pas)odo;
                u.USLOVI = $" PasID = {u.PasID}";
                Broker.Instanca.deleteJedan(u);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
