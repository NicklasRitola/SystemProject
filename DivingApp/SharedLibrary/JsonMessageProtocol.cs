using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


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
        public Request DecodeRequest(string dataString)
        {
            string JSONString = Encoding.ASCII.GetString(Convert.FromBase64String(dataString));
            Request receivedMessage = JsonConvert.DeserializeObject<Request>(JSONString);
            return receivedMessage;
        }

        //Decodes a byte-array representation of a response into a response object.
        public Response DecodeResponse(string dataString)
        {
            string JSONString = Encoding.ASCII.GetString(Convert.FromBase64String(dataString));
            Response receivedResponse = JsonConvert.DeserializeObject<Response>(JSONString);
            return receivedResponse;
        }
    }
}
