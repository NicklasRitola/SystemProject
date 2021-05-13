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
    public class SocketServer
    {
        public ClientHandler clientHandler = new ClientHandler();
        public short Port = 11111;

        public void executeServer()
        {

            SocketHandler socketHandler = new SocketHandler();
            Socket listener = socketHandler.startListener();
            JsonMessageProtocol messageProtocol = new JsonMessageProtocol();

            while (true)
            {
                //TODO: Detects new connection and starts a new Task that handles that connection

                Console.WriteLine("Waiting connection ...");

                Socket clientSocket = listener.Accept();

                byte[] bytes = new byte[1024];
                string data = null;

                int noBytes = 0;
                noBytes = clientSocket.Receive(bytes, bytes.Length, 0);
                data += Encoding.ASCII.GetString(bytes,
                    0, noBytes);

                Request request = messageProtocol.DecodeRequest(data);

                Console.WriteLine("Text received:\n" +
                    "Id: {0}\n" +
                    "Message: {1}", request.requestId, request.message);

                Response response = new Response();

                byte[] encodedResponse = messageProtocol.Encode(response);

                clientSocket.Send(encodedResponse);

                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Dispose();
            }
        }
    }
}
