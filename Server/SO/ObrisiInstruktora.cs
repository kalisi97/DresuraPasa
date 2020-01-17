using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class ObrisiInstruktora : OpstaSO
    {
        internal override object izvrsi(object odo)
        {
            try
            {
                Instruktor p = (Instruktor)odo;
                p.USLOVI = $" InstruktorID = {p.InstruktorID}";
                Broker.Instanca.deleteJedan(p);
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
