using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Response : Message
    {
        string messageType = "Response";
        //Example properties
        //public int responseId;
        //public string message;

        public Response()
        {
            //responseId = 1;
            //message = "This is a response";
        }
    }
}