using BrokerBP;
using Domen;
using Server.SO;
using System.Linq;

namespace Server
{
    internal class VratiSvePse : OpstaSO
    {
        internal override object izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.Instanca.vratiSve(odo).OfType<Pas>().ToList<Pas>();
        }
    }
}