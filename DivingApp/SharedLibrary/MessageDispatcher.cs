using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public abstract class MessageDispatcher
    {
        public abstract Task<Response> DispatchMessage(JObject message);
    }
}
