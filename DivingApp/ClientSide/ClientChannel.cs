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
        JsonMessageProtocol messageProtocol = new JsonMessageProtocol();
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

        public void CloseConnection(Socket socket)
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        public void transaction(Request request)
        {
            // Socket socket = socketHandler.connectToServer();

            //SENDING
            //TODO: Implement a sendAsync method that takes a message, calls the Encode method and .Send method
            byte[] requestToSend = messageProtocol.Encode(request);
            int byteSent = socket.Send(requestToSend);

            //TODO: Implement a receiver
            byte[] messageReceived = new byte[1024];
            string data = null;
            int byteRecv = 0;
            byteRecv = socket.Receive(messageReceived, messageReceived.Length, 0);
            data += Encoding.ASCII.GetString(messageReceived, 0, byteRecv);

            Response response = messageProtocol.DecodeResponse(data);


            Console.WriteLine("Response from server:\n" +
                "{0}\n" +
                "{1}", response.responseId, response.message);
        }
    }
}
