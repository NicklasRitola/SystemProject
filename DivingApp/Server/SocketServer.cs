using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class SocketServer
    {
        private ClientHandler clientHandler = new ClientHandler();
        private MessageDispatcher messageDispatcher = new MessageDispatcher();
        //Server class will not need a message protocol object as that will be handled in the messagedispatcher class
        //JsonMessageProtocol messageProtocol = new JsonMessageProtocol();

        public void executeServer()
        {
            SocketHandler socketHandler = new SocketHandler();
            Socket listener = socketHandler.startListener();
            _ = Task.Run(() => ListenAsync(listener));
        }

        private async Task ListenAsync(Socket listener)
        {
            do
            {
                //TODO: Detects new connection and starts a new Task that handles that connection

                Console.WriteLine("Waiting connection ...");
                var clientSocket = await Task.Factory.FromAsync(
                    new Func<AsyncCallback, object, IAsyncResult>(listener.BeginAccept),
                    new Func<IAsyncResult, Socket>(listener.EndAccept),
                    null).ConfigureAwait(false);

                var channel = new Channel(messageDispatcher);
                channel.AttachSocket(clientSocket);
                //while (true) { }

                //Socket clientSocket = listener.Accept();
                //byte[] bytes = new byte[1024];
                //string data = null;
                //int noBytes = 0;
                //noBytes = clientSocket.Receive(bytes, bytes.Length, 0);
                //data += Encoding.ASCII.GetString(bytes,
                //    0, noBytes);

                //Request request = messageProtocol.DecodeRequest(data);

                //Console.WriteLine("Text received:\n" +
                //    "Id: {0}\n" +
                //    "Message: {1}", request.requestId, request.message);

                //Response response = new Response();

                //byte[] encodedResponse = messageProtocol.Encode(response);

                //clientSocket.Send(encodedResponse);

                //clientSocket.Shutdown(SocketShutdown.Both);
                //clientSocket.Dispose();
            } while (true);
        }
    }
}
