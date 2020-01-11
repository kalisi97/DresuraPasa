using BrokerBP;
using Domen;
using Server.SO;
using System;
using System.Collections.Generic;

namespace Server
{
    internal class ZapamtiOcene:OpstaSOUnosOcena
    {
        internal override object izvrsi(List<OpstiDomenskiObjekat> odo)
        {
            Broker.Instanca.insertVise(odo);
            return true;
        }

    }
}