using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Response : Message
    {
        public Response()
        {
            messageType = "response";
        }
    }

    public class TestResponse : Response
    {
        public TestResponse()
        {
            messageType = "testresponse";
        }
    }

    public class ResultResponse : Response //A response that tells the client if the request succeded/failed
    {
        public string message = "";
        public ResultResponse()
        {

        }
        public ResultResponse(string type, bool result)
        {
            messageType = "resultresponse";
            if (result)
                message = type + " succeeded!";
            else
                message = type + " failed.";
        }

        public ResultResponse(string type1, string type2, bool result1, bool result2)
        {
            message = type1;
            if (result1)
                message += " succeeded!\n";
            else
                message += " failed.\n";
            message += type2;
            if (result2)
                message += " succeeded!";
            else
                message += " failed.";
        }
    }
    public class ScheduleResponseItem : Response
    {
        public string Person { get; set; }
        public string Current { get; set; }
        public int Diff { get; set; }
        public int DiveGroup { get; set; }
        public int jumpID { get; set; }
        public int Tower { get; set; }


        public ScheduleResponseItem()
        {
            messageType = "ScheduleResponseItem";
        }
    }
    public class ScheduleResponse : Response
    {
        public List<ScheduleResponseItem> ScheduleItems;


        public ScheduleResponse()
        {
            ScheduleItems = new List<ScheduleResponseItem>();
            messageType = "ScheduleResponse";
        }
        public void AddItem(ScheduleResponseItem Item)
        {
            ScheduleItems.Add(Item);
        }
    }

    public class DiverInfoResponse : Response
    {
        public string SSN;
        public string FirstName;
        public string Surname;
        public string Gender;
        public int Age;
        public int Team;
        public int Team_ID;
        public int Diver_ID;

        public DiverInfoResponse()
        {
            messageType = "diverinforesponse";
        }
    }

    public class ScoreTableResponse : Response
    {

        public ScoreTableResponse()
        {
            messageType = "scoretableresponse";
        }
    }

    public class LoginResponse : Request
    {
        public bool Success;

        public LoginResponse()
        {
            messageType = "loginresponse";
        }
    }

}