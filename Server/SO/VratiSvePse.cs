using BrokerBP;
using Domen;
using Server.SO;
using System.Linq;

namespace Server
{
    internal class VratiSvePse : OpstaSO
    {
        internal override object izvrsi(object odo)
        {
            return Broker.Instanca.vratiSve((OpstiDomenskiObjekat)odo).OfType<Pas>().ToList<Pas>();
        }
    }
}