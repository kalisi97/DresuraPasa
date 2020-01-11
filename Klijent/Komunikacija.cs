using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    internal class Komunikacija
    {
        private TcpClient klijent;
        private BinaryFormatter formater;
        private NetworkStream tok;

        private static Komunikacija instanca;
        public static Komunikacija Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new Komunikacija();
                return instanca;
            }
        }

        private Komunikacija()
        {
            formater = new BinaryFormatter();
        }

        public bool poveziSe()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 10000);
                tok = klijent.GetStream();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacija.KRAJ;
            formater.Serialize(tok, transfer);
        }

        internal object prijaviSe(Instruktor instruktor)
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Operacija = Operacija.PRIJAVISE,
                Objekat = instruktor
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal bool zapamtiInstruktora(Instruktor i)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa
                {
                    Objekat = i,
                    Operacija = Operacija.ZAPAMTIINSTRUKTORA
                };
                formater.Serialize(tok, transfer);

                transfer = (TransferKlasa)formater.Deserialize(tok);
                return (bool)transfer.Rezultat;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal object kreirajInstruktora()
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Operacija = Operacija.KREIRAJINSTRUKTORA,
                Objekat = new Instruktor()
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal bool zapamtiOcene(BindingList<Ocena> ocene)
        {
            try
            {
              
                TransferKlasa transfer = new TransferKlasa
                {
                    Objekat = new List<OpstiDomenskiObjekat>(ocene),
                    Operacija = Operacija.ZAPAMTIOCENE
                };
                formater.Serialize(tok, transfer);

                transfer = (TransferKlasa)formater.Deserialize(tok);
                return (bool)transfer.Rezultat;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal object kreirajPsa()
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Operacija = Operacija.KREIRAJPSA,
                Objekat = new Pas()
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal bool zapamtiPsa(Pas u)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa
                {
                    Objekat = u,
                    Operacija = Operacija.ZAPAMTIPSA
                };
                formater.Serialize(tok, transfer);

                transfer = (TransferKlasa)formater.Deserialize(tok);
                return (bool)transfer.Rezultat;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal object kreirajKurs()
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Operacija = Operacija.KREIRAJKURS,
                Objekat = new Kurs()
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal object ucitajInstruktore()
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Objekat = new Instruktor(),
                Operacija = Operacija.UCITAJINSTRUKTORE
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal object ucitajVrsteKursa()
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Objekat = new VrstaKursa(),
                Operacija = Operacija.UCITAJVRSTEKURSA
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal bool zapamtiKurs(Kurs k)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa
                {
                    Objekat = k,
                    Operacija = Operacija.ZAPAMTIKURS
                };
                formater.Serialize(tok, transfer);

                transfer = (TransferKlasa)formater.Deserialize(tok);
                return (bool)transfer.Rezultat;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal object pretraziInstruktore(Instruktor instruktor)
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Operacija = Operacija.PRETRAZIINSTRUKTORE,
                Objekat = instruktor,
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal bool sacuvajIzmene(Instruktor instruktor)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa
                {
                    Operacija = Operacija.SACUVAJIZMENE,
                    Objekat = instruktor
                };
                formater.Serialize(tok, transfer);

                transfer = (TransferKlasa)formater.Deserialize(tok);
                return (bool)transfer.Rezultat;
            }
            catch (Exception)
            {

                return false;
            }
        }

        internal bool obrisiInstruktora(Instruktor instruktor)
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Objekat = instruktor,
                Operacija = Operacija.OBRISIINSTRUKTORA
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return (bool)transfer.Rezultat;
        }

        internal object pretraziPse(Pas pas)
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Operacija = Operacija.PRETRAZIPSE,
                Objekat = pas,
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal bool obrisiPasa(Pas pas)
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Objekat = pas,
                Operacija = Operacija.OBRISIPSA
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return (bool)transfer.Rezultat;
        }

        internal object pretraziKurseve(Kurs kurs)
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Operacija = Operacija.PRETRAZIKURSEVE,
                Objekat = kurs,
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal object vratiSveKurseve()
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Objekat = new Kurs(),
                Operacija = Operacija.VRATISVEKURSEVE
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

    

      

        internal object ucitajKurseveZaInstruktora(Instruktor instruktor)
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Objekat = instruktor,
                Operacija = Operacija.UCITAJKURSEVEZAINSTRUKTORA
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }

        internal object vratiSvePse()
        {
            TransferKlasa transfer = new TransferKlasa
            {
                Objekat = new Pas(),
                Operacija = Operacija.VRATISVEPSE
            };
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return transfer.Rezultat;
        }
    }
}
