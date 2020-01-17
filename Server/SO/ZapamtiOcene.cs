using BrokerBP;
using Domen;
using Server.SO;
using System;
using System.Collections.Generic;

namespace Server
{
    internal class ZapamtiOcene:OpstaSO
    {
      

        internal override object izvrsi(object odo)
        {
            Broker.Instanca.insertVise((List<OpstiDomenskiObjekat>)odo);
            return true;
        }
    }
}