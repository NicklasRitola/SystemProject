using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Request : Message
    {
        //Example properties
        public int requestId;
        public string message;

        public Request()
        {
            requestId = 1;
            message = "This is a request";
        }
    }
}
