﻿using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class KreirajPsa : OpstaSO
    {
        internal override object izvrsi(OpstiDomenskiObjekat odo)
        {
            Pas u = new Pas();
            u.PasID = Broker.Instanca.vratiSifru(odo);
            Broker.Instanca.insert(u);
            return u;
        }
    }
}
