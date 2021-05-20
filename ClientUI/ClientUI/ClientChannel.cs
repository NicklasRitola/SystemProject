using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared;

namespace ClientUI
{
    public class ClientChannel : Channel
    {
        //A version of the Channel class that is adapted to function for the Client

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

        public override void AttachSocket(Socket socket)
        {
            //Attach the socket to the channel
            stream = new NetworkStream(socket, true);
        }

        public async Task<JObject> ReceiveResponse()
        {
            //Receives a single message from the channel
            JObject response = null;
            try
            {
                response = await messageProtocol.ReceiveAsync(stream).ConfigureAwait(false);
            }
            catch (System.IO.IOException)
            {
                //TODO: Send error to UI
                Close();
            }
            catch (Exception e)
            {
                //TODO: Send error to UI
                Close();
            }
            return response;
        }
    }
}
