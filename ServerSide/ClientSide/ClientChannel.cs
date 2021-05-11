using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace ClientSide
{
    class ClientChannel
    {
        IPHostEntry ipHost = null;
        IPAddress ipAddr = null;
        IPEndPoint localEndPoint = null;
        Socket socket = null;

        public Socket connectToServer()
        {
            try
            {
                ipHost = Dns.GetHostEntry(Dns.GetHostName());
                ipAddr = ipHost.AddressList[0];
                localEndPoint = new IPEndPoint(ipAddr, 11111);
                socket = new Socket(ipAddr.AddressFamily,
                        SocketType.Stream, ProtocolType.Tcp);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                socket.Connect(localEndPoint);

                Console.WriteLine("Socket connected to -> {0}",
                    socket.RemoteEndPoint.ToString());
            }

            catch (ArgumentNullException ane)
            {

                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }

            catch (SocketException se)
            {

                Console.WriteLine("SocketException : {0}", se.ToString());
            }

            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }

            return socket;
        }
    }
}
