﻿using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class UcitajInstruktore : OpstaSO
    {
        internal override object izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.Instanca.vratiSve(odo).OfType<Instruktor>().ToList<Instruktor>();
        }
    }
}
