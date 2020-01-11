using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class KreirajInstruktora : OpstaSO
    {
        internal override object izvrsi(OpstiDomenskiObjekat odo)
        {
            Instruktor p = new Instruktor();
            p.InstruktorID = Broker.Instanca.vratiSifru(odo);
            Broker.Instanca.insert(p);
            return p;
        }
    }
}
