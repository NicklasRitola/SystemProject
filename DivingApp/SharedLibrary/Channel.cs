using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared;

namespace Shared
{
    public class Channel
    {
        protected bool disposed = false;
        protected bool closed = false;

        public JsonMessageProtocol messageProtocol = new JsonMessageProtocol();
        public CancellationTokenSource cancel = new CancellationTokenSource();
        public MessageDispatcher messageDispatcher = null;

        public NetworkStream stream;
        public Task receiverTask;
        
        public Channel() { messageDispatcher = null; }

        public Channel(MessageDispatcher messageDispatcher)
        {
            this.messageDispatcher = messageDispatcher;
        }

        public virtual void AttachSocket(Socket socket)
        {
            stream = new NetworkStream(socket, true);
            receiverTask = Task.Run(ReceiverLoop, cancel.Token);
        }

        public void Close()
        {
            if (!closed)
            {
                closed = true;
                cancel.Cancel();
                stream?.Close();
            }
        }

        public async Task SendAsync(Message message)
        {
            await messageProtocol.SendAsync(stream, message).ConfigureAwait(false);
        }

        protected virtual async Task ReceiverLoop()
        {
            try
            {
                while (!cancel.Token.IsCancellationRequested)
                {
                    JObject message = await messageProtocol.ReceiveAsync(stream).ConfigureAwait(false);
                    Response response = await messageDispatcher.DispatchMessage(message);
                    await messageProtocol.SendAsync(stream, response).ConfigureAwait(false);
                }
            }
            catch(System.IO.IOException)
            {
                Console.WriteLine("Channel closed by client");
                Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Channel error: " + e);
                Close();
            }
        }
    }
}