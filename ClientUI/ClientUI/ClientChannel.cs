using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Shared;

namespace ClientUI
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

        public override void AttachSocket(Socket socket)
        {
            stream = new NetworkStream(socket, true);
            //receiverTask = Task.Run(ReceiverLoop, cancel.Token);
        }

        public async Task<Response> ReceiveResponse()
        {
            Response response = null;
            try
            {
                JObject message = await messageProtocol.ReceiveAsync(stream).ConfigureAwait(false);
                response = await messageDispatcher.DispatchMessage(message);
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

        //protected async Task ReceiverLoop()
        //{
        //    Response response = null;
        //    try
        //    {
        //        while (!cancel.Token.IsCancellationRequested)
        //        {
        //            JObject message = await messageProtocol.ReceiveAsync(stream).ConfigureAwait(false);
        //            response =  await messageDispatcher.DispatchMessage(message);
        //        }
        //    }
        //    catch (System.IO.IOException)
        //    {
        //        //TODO: Send error to UI
        //        Close();
        //    }
        //    catch (Exception e)
        //    {
        //        //TODO: Send error to UI
        //        Close();
        //    }
        //}
    }
}
