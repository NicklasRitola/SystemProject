using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared;

namespace Server
{
    public class Channel// : IDisposable
    {
        protected bool disposed = false;
        protected bool closed = false;

        readonly JsonMessageProtocol messageProtocol = new JsonMessageProtocol();
        readonly CancellationTokenSource cancel = new CancellationTokenSource();
        readonly MessageDispatcher messageDispatcher = new MessageDispatcher();

        //Func<Message, Task> callback;
        NetworkStream stream;
        Task receiverTask;
        
        public void AttachSocket(Socket socket)
        {
            stream = new NetworkStream(socket, true);
            receiverTask = Task.Run(ReceiverLoop, cancel.Token);
        }

        //public void OnMessage(Func<Message, Task> callbackHandler)
            //=> callback = callbackHandler;

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
                    Response response = await messageDispatcher.DispatchMessage(stream, message);
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

        //~Channel() => Dispose(false);
        //public void Dispose() => Dispose(true);
        //protected void Dispose(bool isDisposing)
        //{
        //    if (!disposed)
        //    {
        //        Console.WriteLine("A channel was disposed");
        //        disposed = true;

        //        Close();
        //        //TODO: Clean up socket, stream, etc.
        //        stream?.Dispose();

        //        if (isDisposing)
        //            GC.SuppressFinalize(this);
        //    }
        //}
    }
}