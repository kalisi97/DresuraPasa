using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class SacuvajIzmene : OpstaSO
    {
        internal override object izvrsi(object odo)
        {
            Broker.Instanca.updateJedan((OpstiDomenskiObjekat)odo);
            return true;
        }
    }
}
