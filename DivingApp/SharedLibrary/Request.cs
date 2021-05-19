﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Request : Message
    {
        public Request()
        {
            messageType = "request";
        }
    }

    public class TestRequest : Request
    {
        public TestRequest()
        {
            messageType = "testrequest";
        }
    }

    public class LoginRequest : Request
    {
        public string SSN;
        public string Password;
        public string LoginType;

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
        public int Type;

        public CreateCompetitionRequest()
        {
            messageType = "createcompetitionrequest";
        }
    }

    public class CreateScheduleRequest : Request
    {
        public int CompetitionID;
        public int count;
        public int DiveID;
        public int DiverID;
        public CreateScheduleRequest()
        {

            messageType = "createschedulerequest";
        }
    }
    public class NextDiverRequest : Request
    {
        public int CompetitionID;
        public NextDiverRequest(int id)
        {
            this.CompetitionID = id;
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
        public string Password;
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
        public string DiveGroup;
        public string Date;
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
        public int DiveID;
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
        public int Competition_ID;
        public ViewScheduleRequest()
        {
            messageType = "viewschedulerequest";
        }
    }
    public class ViewCurrentDiverRequest : Request
    {
        public int CompetitionID;
        public ViewCurrentDiverRequest()
        {
            messageType = "viewcurrentdiverrequest";
        }

        public ViewCurrentDiverRequest(int compId)
        {
            this.CompetitionID = compId;
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