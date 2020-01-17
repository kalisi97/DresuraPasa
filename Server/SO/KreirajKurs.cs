using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class KreirajKurs : OpstaSO
    {
        internal override object izvrsi(object odo)
        {
            Kurs k = new Kurs();
            k.KursID = Broker.Instanca.vratiSifru((OpstiDomenskiObjekat)odo);
            Broker.Instanca.insert(k);
            return k;
        }
    }
}
