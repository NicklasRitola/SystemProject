using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide
{
    public class SocketHandler
    {
        private ClientHandler clientHandler = null;
        private static IPHostEntry ipHost = null;
        private static IPAddress ipAddr = null;
        private static IPEndPoint localEndPoint = null;
        private Socket listener = null;
        private JsonMessageProtocol messageCoder = null;

        public async Task<Socket> startListener()
        {
            // Establish local endpoint
            // Creation TCP/IP socket

            clientHandler = new ClientHandler();
            ipHost = await Dns.GetHostEntryAsync(Dns.GetHostName());
            ipAddr = ipHost.AddressList[0];
            localEndPoint = new IPEndPoint(ipAddr, 11111);
            listener = new Socket(ipAddr.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
            messageCoder = new JsonMessageProtocol();



            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return listener;
        }
    }
}
