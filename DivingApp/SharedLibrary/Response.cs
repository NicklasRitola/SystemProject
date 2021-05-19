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
    public class CompetitionDive : Response
    {
        public int DiveId;
        public float Difficulty;
        public string Group;
        public int Tower;
        public string DiverName;

        //TODO: Remove SSN from here and database request
        public string DiverSSN;

        //TODO: Remove time from here and database request?
        public string Time;
        public float? Score = null;

        public bool Current;

        //Dyk i databasen: int ID, float SCORE, float DIFFICULTY, string GROUP, int TOWER,
        //int COMPETITION_ID, string DIVER_ID, string TIME
        public CompetitionDive()
        {
            messageType = "CompetitionDiveItem";
        }

        public CompetitionDive(int diveID, float difficulty, string group, int tower, string diverID, string time)
        {
            messageType = "CompetitionDiveItem";
            this.DiveId = diveID;
            this.Difficulty = difficulty;
            this.Group = group;
            this.Tower = tower;
            this.DiverName = diverID;
            this.Time = time;
            this.Current = false;
        }
    }
    public class CompetitionScheduleResponse : Response
    {
        public List<CompetitionDive> CompetitionDives;

        public CompetitionScheduleResponse()
        {
            CompetitionDives = null;
            messageType = "ScheduleResponse";
        }

        public CompetitionScheduleResponse(int currentDiveId ,List<CompetitionDive> dives)
        {
            CompetitionDives = dives;
            //CompetitionDives.Sort
            foreach(var dive in CompetitionDives)
            {
                if (dive.DiveId == currentDiveId)
                    dive.Current = true;
            }
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

    public class LoginResponse : Response
    {
        public bool Success;

        public LoginResponse()
        {
            messageType = "loginresponse";
        }
    }

    public class CurrentDiverResponse : Response
    {
        public int CurrentID;
        public float Difficulty;
        public string DiveGroup;
        public int Tower;

        CurrentDiverResponse(int id, float difficulty, string group, int tower)
        {
            this.CurrentID = id;
            this.Difficulty = difficulty;
            this.DiveGroup = group;
            this.Tower = tower;
        }
    }
}