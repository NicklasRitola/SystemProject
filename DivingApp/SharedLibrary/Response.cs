﻿using System;
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

    public class ResultResponse : Response //A response that tells the client if the request succeded/failed
    {
        string message;
        public ResultResponse(string type, bool result)
        {
            messageType = "resultresponse";
            if (result)
                message = type + " succeeded!";
            else
                message = type + " failed.";
        }
    }

    public class ScheduleResponse : Response
    {

        public ScheduleResponse()
        {
            messageType = "ScheduleResponse";
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
            messageType = "DiverInfoResponse";
        }
    }

    public class LoginResponse : Request
    {
        public bool Success;

        public LoginResponse()
        {
            messageType = "LoginResponse";
        }
    }

}