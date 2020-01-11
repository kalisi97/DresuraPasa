using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    internal class Server
    {
        private Socket soket;
        internal static List<NetworkStream> klijenti = new List<NetworkStream>();

        internal bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Bind(new IPEndPoint(IPAddress.Any, 10000));

                Thread nit = new Thread(osluskuj);
                nit.IsBackground = true;
                nit.Start();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška pri pokretanju servera!");
                return false;
            }
        }

        internal bool zaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void osluskuj()
        {
            try
            {
                while (true)
                {
                    soket.Listen(5);
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    new ObradaKlijenta(tok);
                    klijenti.Add(tok);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
