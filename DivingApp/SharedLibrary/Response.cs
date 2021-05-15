using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Response : Message
    {
        //Example properties
        //public int responseId;
        //public string message;

        public Response()
        {
            messageType = "response";
            //responseId = 1;
            //message = "This is a response";
        }
    }

    public class ScheduleResponse : Response
    {

    }

}