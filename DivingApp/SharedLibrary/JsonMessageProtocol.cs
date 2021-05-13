using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shared
{
    public class JsonMessageProtocol
    {
        //Encodes a message type object and returns the byte-array representation that can be sent over the socket.
        public byte[] Encode(Message message)
        {
            string JSONString = JsonConvert.SerializeObject(message);
            string encodedMessage = Convert.ToBase64String(Encoding.ASCII.GetBytes(JSONString));
            return Encoding.ASCII.GetBytes(encodedMessage);
        }

        //Decodes a byte-array representation of a request into a request object.
        public Message Decode(string dataString)
        {
            string JSONString = Encoding.ASCII.GetString(Convert.FromBase64String(dataString));
            Message receivedMessage = JsonConvert.DeserializeObject<Request>(JSONString);
            return receivedMessage;
        }

        public async Task SendAsync(NetworkStream stream, Message message)
        {
            byte[] bytes = Encode(message);
            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        public async Task<Message> ReceiveAsync(NetworkStream stream)
        {
            byte[] bytes = new byte[1024];
            int bytesRead = 0;
            bytesRead = await stream.ReadAsync(bytes, 0, 1024).ConfigureAwait(false);
            if(bytesRead == 0)
            {
                throw new Exception("Connection has closed");
            }
            string data = Encoding.UTF8.GetString(bytes, 0, bytesRead);
            Message message = Decode(data);
            return message;
        }

        //Decodes a byte-array representation of a response into a response object.
        //public Response DecodeResponse(string dataString)
        //{
        //    string JSONString = Encoding.ASCII.GetString(Convert.FromBase64String(dataString));
        //    Response receivedResponse = JsonConvert.DeserializeObject<Response>(JSONString);
        //    return receivedResponse;
        //}
    }
}
