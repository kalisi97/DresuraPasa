using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class PrijaviSe : OpstaSO
    {
        internal override object izvrsi(object odo)
        {
            return Broker.Instanca.vratiJedanZaID((OpstiDomenskiObjekat)odo) as Instruktor;
        }
    }
}
