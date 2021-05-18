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
        private ServerMessageDispatcher messageDispatcher = new ServerMessageDispatcher();

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
                //Detects new connection and starts a new Task that handles that connection

                Console.WriteLine("Waiting connection ...");
                var clientSocket = await Task.Factory.FromAsync(
                    new Func<AsyncCallback, object, IAsyncResult>(listener.BeginAccept),
                    new Func<IAsyncResult, Socket>(listener.EndAccept),
                    null).ConfigureAwait(false);
                Console.WriteLine("Connection received");
                var channel = new Channel(messageDispatcher);
                channel.AttachSocket(clientSocket);
            } while (true);
        }
    }
}
