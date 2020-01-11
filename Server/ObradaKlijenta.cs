using Domen;
using Server.SO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class ObradaKlijenta
    {
        private NetworkStream tok;
        private BinaryFormatter formater;

        public ObradaKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            Thread nit = new Thread(obradi);
            nit.IsBackground = true;
            nit.Start();
        }

        private void obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacija.KRAJ)
                {
                    TransferKlasa transfer = (TransferKlasa)formater.Deserialize(tok);

                    switch (transfer.Operacija)
                    {
                        case Operacija.KRAJ:
                            operacija = 1;
                            Server.klijenti.Remove(tok);
                            break;
                        case Operacija.PRIJAVISE:
                            PrijaviSe p = new PrijaviSe();
                            transfer.Rezultat = p.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.ZAPAMTIINSTRUKTORA:
                            ZapamtiInstruktora zp = new ZapamtiInstruktora();
                            transfer.Rezultat = zp.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.KREIRAJINSTRUKTORA:
                            KreirajInstruktora kp = new KreirajInstruktora();
                            transfer.Rezultat = kp.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.KREIRAJPSA:
                            KreirajPsa ku = new KreirajPsa();
                            transfer.Rezultat = ku.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.ZAPAMTIPSA:
                            ZapamtiPsa zu = new ZapamtiPsa();
                            transfer.Rezultat = zu.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.KREIRAJKURS:
                            KreirajKurs kk = new KreirajKurs();
                            transfer.Rezultat = kk.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.UCITAJINSTRUKTORE:
                            UcitajInstruktore up = new UcitajInstruktore();
                            transfer.Rezultat = up.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.UCITAJVRSTEKURSA:
                            UcitajVrsteKursa uvk = new UcitajVrsteKursa();
                            transfer.Rezultat = uvk.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.ZAPAMTIKURS:
                            ZapamtiKurs zk = new ZapamtiKurs();
                         
                            transfer.Rezultat = zk.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRETRAZIINSTRUKTORE:
                            PretraziInstruktore pp = new PretraziInstruktore();
                            transfer.Rezultat = pp.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.SACUVAJIZMENE:
                            SacuvajIzmene si = new SacuvajIzmene();
                            transfer.Rezultat = si.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.OBRISIINSTRUKTORA:
                            ObrisiInstruktora op = new ObrisiInstruktora();
                            transfer.Rezultat = op.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRETRAZIPSE:
                            PretraziPse pu = new PretraziPse();
                            transfer.Rezultat = pu.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.OBRISIPSA:
                            ObrisiPsa ou = new ObrisiPsa();
                            transfer.Rezultat = ou.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRETRAZIKURSEVE:
                            PretraziKurseve pk = new PretraziKurseve();
                            transfer.Rezultat = pk.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATISVEKURSEVE:
                            VratiSveKurseve vsk = new VratiSveKurseve();
                            transfer.Rezultat = vsk.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATISVEPSE:
                            VratiSvePse vsp = new VratiSvePse();
                            transfer.Rezultat = vsp.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacija.ZAPAMTIOCENE:
                            ZapamtiOcene zc = new ZapamtiOcene();
                          
                            transfer.Rezultat = zc.izvrsiSO(transfer.Objekat as List<OpstiDomenskiObjekat>);
                            formater.Serialize(tok, transfer);
                            break;
                    
                        case Operacija.UCITAJKURSEVEZAINSTRUKTORA:
                            UcitajKurseveZaInstruktora uuzp = new UcitajKurseveZaInstruktora();
                            transfer.Rezultat = uuzp.izvrsiSO(transfer.Objekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    Server.klijenti.Remove(tok);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
