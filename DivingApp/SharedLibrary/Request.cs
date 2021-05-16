﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Request : Message
    {
        //Example properties
        //public int requestId;
        //public string message;
        int test;

        public Request()
        {
            messageType = "request";
            test = 1;
            //requestId = 1;
            //message = "This is a request";
        }
    }

    public class LoginRequest : Request
    {
        public string SSN;
        public string Password;

        public LoginRequest()
        {
            messageType = "loginrequest";
        }
    }

    //Admin
    public class CreateCompetitionRequest : Request
    {
        public int ID;
        public string Location;
        public string Start_Date;
        public string End_Date;

        public CreateCompetitionRequest()
        {
            messageType = "createcompetitionrequest";
        }
    }
    public class CreateScheduleRequest : Request
    {
        public List<string> Dive;
        public CreateScheduleRequest()
        {
            messageType = "createschedulerequest";
        }
    }
    public class NextDiverRequest : Request
    {
        public NextDiverRequest()
        {
            messageType = "nextdiverrequest";
        }
    }
    public class RegisterDiverRequest : Request
    {
        public string SSN;
        public string FirstName;
        public string Surname;
        public string Gender;
        public int Age;
        public int Team;
        public RegisterDiverRequest()
        {
            messageType = "registerdiverrequest";
        }
    }
    public class RegisterDiveRequest : Request
    {
        public int Dive_ID;
        public float? Score = null; //Can be empty in database
        public float Difficulty;
        public int Tower;
        public int In_Competition;
        public string Diver;
        public RegisterDiveRequest()
        {
            messageType = "registerdiverequest";
        }
    }
    public class RegisterTeamRequest : Request
    {
        public int Team_ID;
        public string Name;
        public RegisterTeamRequest()
        {
            messageType = "registerteamrequest";
        }
    }
    public class RegisterJudgeRequest : Request
    {
        public string SSN;
        public string FirstName;
        public string Surname;
        public string Gender;
        public int In_Competition;
        public string Password;
        public RegisterJudgeRequest()
        {
            messageType = "registerjudgerequest";
        }
    }
    public class RegisterAdminRequest : Request
    {
        public string SSN;
        public string FirstName;
        public string Surname;
        public string Gender;
        public string Password;
        public RegisterAdminRequest()
        {
            messageType = "registeradminrequest";
        }
    }

    //Judge
    public class JudgePointRequest : Request
    {
        public int Dive;
        public int Point;
        public string Judge;
        public int In_Competition;
        public JudgePointRequest()
        {
            messageType = "judgepointrequest";
        }
    }

    //Spectator
    public class ViewScheduleRequest : Request
    {
        public ViewScheduleRequest()
        {
            messageType = "viewschedulerequest";
        }
    }
    public class ViewCurrentDiverRequest : Request
    {
        public ViewCurrentDiverRequest()
        {
            messageType = "viewcurrentdiverrequest";
        }
    }
    public class ViewScoreTableRequest : Request
    {
        public ViewScoreTableRequest()
        {
            messageType = "viewscoretablerequest";
        }
    }
}