using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public byte[] Encode<T>(T message)
        {
            string JSONString = JsonConvert.SerializeObject(message);
            string encodedMessage = Convert.ToBase64String(Encoding.ASCII.GetBytes(JSONString));
            return Encoding.ASCII.GetBytes(encodedMessage);
        }

        //Decodes a byte-array representation of a request into a request object.
        public JObject Decode(string dataString)
        {
            string JSONString = Encoding.ASCII.GetString(Convert.FromBase64String(dataString));
            JObject receivedObject = JsonConvert.DeserializeObject<JObject>(JSONString);
            return receivedObject;
        }

        public async Task SendAsync(NetworkStream stream, Message message)
        {
            byte[] bytes = Encode(message);
            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        public async Task<JObject> ReceiveAsync(NetworkStream stream)
        {
            int numOfBytes = 2048;
            byte[] bytes = new byte[numOfBytes];
            int bytesRead = 0;
            bytesRead = await stream.ReadAsync(bytes, 0, numOfBytes).ConfigureAwait(false);
            if(bytesRead == 0)
            {
                throw new Exception("Connection has closed");
            }
            string data = Encoding.UTF8.GetString(bytes, 0, bytesRead);
            JObject message = Decode(data);
            return message;
        }
    }
}
