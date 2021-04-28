using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ServerSide
{
    class Prog
    {
        static void Main(string[] args)
        {
            executeServer();
        }
        
        public static void executeServer()
        {
            // Establish local endpoint

            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

            // Creation TCP/IP socket

            Socket listener = new Socket(ipAddr.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);

                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("Waiting connection ...");

                    Socket clientSocket = listener.Accept();

                    byte[] bytes = new byte[1024];
                    string data = null;

                    while (true)
                    {
                        int numByte = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes,
                            0, numByte);

                        if (data.IndexOf("<EOF>") > -1)
                            break;
                    }

                    Console.WriteLine("Text received -> {0} ", data);
                    byte[] message = Encoding.ASCII.GetBytes("Test Server");

                    clientSocket.Send(message);

                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
