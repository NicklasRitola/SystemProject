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
    public class ClientChannel : Channel
    {
        public ClientChannel(MessageDispatcher messageDispatcher) : base(messageDispatcher) { }

        public async Task ConnectAsync(IPEndPoint endPoint)
        {
            try
            {
                Socket socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                await socket.ConnectAsync(endPoint).ConfigureAwait(false);
                AttachSocket(socket);
            }
            catch(Exception e)
            {
                //TODO: Send error message
            }
        }
    }
}
