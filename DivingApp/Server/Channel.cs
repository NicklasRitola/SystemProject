using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared;

namespace Server
{
    public class Channel
    {
        JsonMessageProtocol messageProtocol = new JsonMessageProtocol();
        CancellationTokenSource cancel = new CancellationTokenSource();
        MessageDispatcher messageDispatcher = new MessageDispatcher();

        Func<Message, Task> callback;
        NetworkStream stream;
        Task receiverTask;

        public void AttachSocket(Socket socket)
        {
            stream = new NetworkStream(socket, true);
            receiverTask = Task.Run(ReceiverLoop, cancel.Token);
        }

        public void OnMessage(Func<Message, Task> callbackHandler)
            => callback = callbackHandler;

        public void Close()
        {
            cancel.Cancel();
            stream?.Close();
        }

        public async Task SendAsync(Message message)
        {
            await messageProtocol.SendAsync(stream, message).ConfigureAwait(false);
        }

        protected virtual async Task ReceiverLoop()
        {
            while(!cancel.Token.IsCancellationRequested)
            {
                Message request = await messageProtocol.ReceiveAsync(stream).ConfigureAwait(false);
                //TODO: Send request to message dispatcher
                messageDispatcher.DispatchMessage(request);
            }
        }
    }
}