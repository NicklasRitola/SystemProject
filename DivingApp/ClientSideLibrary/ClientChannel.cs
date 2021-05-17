﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
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
                Console.WriteLine("ClientChannel connection error: "+ e);
            }
        }

        protected override async Task ReceiverLoop()
        {
            try
            {
                while (!cancel.Token.IsCancellationRequested)
                {
                    JObject message = await messageProtocol.ReceiveAsync(stream).ConfigureAwait(false);
                    await messageDispatcher.DispatchMessage(message);
                }
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Channel closed by server");
                Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Channel error: " + e);
                Close();
            }
        }
    }
}
