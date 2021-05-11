using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace Shared
{
    class JsonMessageProtocol
    {
        //Encodes a message type object and returns the byte-array representation that can be sent over the socket.
        public byte[] Encode<T>(T message)
        {
            string JSONString = JsonConvert.SerializeObject(message);
            string encodedMessage = Convert.ToBase64String(Encoding.ASCII.GetBytes(JSONString));
            return Encoding.ASCII.GetBytes(encodedMessage);
        }

        //Decodes a byte-array representation of a message into a message object.
        public Message Decode(string dataString)
        {
            string JSONString = Encoding.ASCII.GetString(Convert.FromBase64String(dataString));
            Message receivedMessage = JsonConvert.DeserializeObject<Message>(JSONString);
            return receivedMessage;
        }
    }
}
