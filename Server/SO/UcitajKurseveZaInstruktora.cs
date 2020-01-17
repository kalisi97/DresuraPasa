using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class UcitajKurseveZaInstruktora : OpstaSO
    {
        internal override object izvrsi(object odo)
        {
            Instruktor p = (Instruktor)odo;
            Kurs k = new Kurs
            {
                USLOVI = $" InstruktorID = {p.InstruktorID}"
            };
            List<Kurs> listaK = Broker.Instanca.vratiSveZaOpstiUslov(k).OfType<Kurs>().ToList();
        
          
            foreach(Kurs kurs in listaK)
            {

                kurs.Instruktor = p;
                kurs.InstruktorString = p.ImePrezime;
              
                kurs.Vrsta =(VrstaKursa)Broker.Instanca.vratiJedanZaID(kurs.Vrsta);
               
            }
            
            
            /*
            List<Pas> ucesnici = new List<Pas>();
            foreach (Kurs kurs in listaK)
            {
                Ocena c = new Ocena
                {
                    USLOVI = $" KursID = {kurs.KursID}"
                };
                List<Ocena> listaC = Broker.Instanca.vratiSveZaOpstiUslovID(c).OfType<Ocena>().ToList();
                foreach (Ocena cl in listaC)
                {
                    Pas u = new Pas
                    {
                        PasID = cl.Pas.PasID
                    };

                    ucesnici.Add((Pas)Broker.Instanca.vratiJedanZaID(u));
                }
            }
            */
            return listaK;
        }
    }
}
