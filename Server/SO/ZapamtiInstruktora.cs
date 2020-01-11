using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class ZapamtiInstruktora:OpstaSO
    {
        internal override object izvrsi(OpstiDomenskiObjekat odo)
        {
            Broker.Instanca.updateJedan(odo);
            return true;
        }
    }
}
