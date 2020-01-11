using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class TransferKlasa
    {
        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }
        public object Rezultat { get; set; }
    }
    public enum Operacija
    {
        KRAJ = 1,
        PRIJAVISE = 2,
        KREIRAJPSA = 3,
        ZAPAMTIINSTRUKTORA = 4,
        PRETRAZIINSTRUKTORE = 5,
        UCITAJINSTRUKTORE = 6,
        UCITAJVRSTEKURSA = 7,
        ZAPAMTIKURS = 8,
        KREIRAJINSTRUKTORA = 9,
        KREIRAJKURS = 10,
        ZAPAMTIPSA = 11,
        SACUVAJIZMENE = 12,
        PRETRAZIKURSEVE = 13,
        OBRISIINSTRUKTORA = 14,
        OBRISIPSA = 15,
        PRETRAZIPSE = 16,
        VRATISVEKURSEVE = 17,
        UCITAJKURSEVEZAINSTRUKTORA = 20,
        VRATISVEPSE = 21,
        ZAPAMTIOCENE = 22
    }
}

