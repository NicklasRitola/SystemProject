using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared;

namespace ClientSide
{
    public class ClientMessageDispatcher : MessageDispatcher
    {
        public override async Task<Response> DispatchMessage(JObject message)
        {
            string JSONString = JsonConvert.SerializeObject(message);
            Response response = null;
            //TODO: Do stuff
            switch(message.Value<string>("messageType"))
            {
                case "":
                    break;
            }
            return response;
        }
    }
}
