﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Sockets;

namespace Server
{
    public class MessageDispatcher
    {
        //Finds the type of the message and sends it to the appropriate handler method

        private DatabaseHandler database = new DatabaseHandler(); 
        private DatabaseHandler password_database = new PasswordDatabaseHandler();

        public void DispatchMessage(NetworkStream stream, JObject message)
        {
            string JSONString = JsonConvert.SerializeObject(message);

            switch (message.Value<string>("messageType")) // Extracts the message type
            {
                case "createcompetitionrequest":
                    CreateCompetitionRequest CreCompReq = JsonConvert.DeserializeObject<CreateCompetitionRequest>(JSONString);
                    DispatchMessage(stream, CreCompReq);
                    break;
                case "createschedulerequest":
                    CreateScheduleRequest CreSchReq = JsonConvert.DeserializeObject<CreateScheduleRequest>(JSONString);
                    DispatchMessage(stream, CreSchReq);
                    break;
                case "nextdiverrequest":
                    NextDiverRequest NexDivReq = JsonConvert.DeserializeObject<NextDiverRequest>(JSONString);
                    DispatchMessage(stream, NexDivReq);
                    break;
                case "registerdiverrequest":
                    RegisterDiverRequest RegDiverReq = JsonConvert.DeserializeObject<RegisterDiverRequest>(JSONString);
                    DispatchMessage(stream, RegDiverReq);
                    break;
                case "registerdiverequest":
                    RegisterDiveRequest RegDiveReq = JsonConvert.DeserializeObject<RegisterDiveRequest>(JSONString);
                    DispatchMessage(stream, RegDiveReq);
                    break;
                case "registerteamrequest":
                    RegisterTeamRequest RegTeamReq = JsonConvert.DeserializeObject<RegisterTeamRequest>(JSONString);
                    DispatchMessage(stream, RegTeamReq);
                    break;
                case "registerjudgerequest":
                    RegisterJudgeRequest RegJudgeReq = JsonConvert.DeserializeObject<RegisterJudgeRequest>(JSONString);
                    DispatchMessage(stream, RegJudgeReq);
                    break;
                case "registeradminrequest":
                    RegisterAdminRequest RegAdminReq = JsonConvert.DeserializeObject<RegisterAdminRequest>(JSONString);
                    DispatchMessage(stream, RegAdminReq);
                    break;
                case "judgepointrequest":
                    JudgePointRequest JudgePointReq = JsonConvert.DeserializeObject<JudgePointRequest>(JSONString);
                    DispatchMessage(stream, JudgePointReq);
                    break;
                case "viewschedulerequest":
                    ViewScheduleRequest ViewSchReq = JsonConvert.DeserializeObject<ViewScheduleRequest>(JSONString);
                    DispatchMessage(stream, ViewSchReq);
                    break;
                case "viewcurrentdiverrequest":
                    ViewCurrentDiverRequest ViewCurrDiverReq = JsonConvert.DeserializeObject<ViewCurrentDiverRequest>(JSONString);
                    DispatchMessage(stream, ViewCurrDiverReq);
                    break;
                case "viewscoretablerequest":
                    ViewScoreTableRequest ViewScoTableReq = JsonConvert.DeserializeObject<ViewScoreTableRequest>(JSONString);
                    DispatchMessage(stream, ViewScoTableReq);
                    break;
            }
        }

        public void DispatchMessage(NetworkStream stream, CreateCompetitionRequest request)
        {
            if (database.CreateCompetitionInDatabase(request))
            {
                //Successfully created
            }
            else
            {
                //Failed to create 
                //Should send back to client that something went wrong 
            }
        }
        public void DispatchMessage(NetworkStream stream, CreateScheduleRequest request)
        {

        }
        public void DispatchMessage(NetworkStream stream, NextDiverRequest request)
        {

        }
        public void DispatchMessage(NetworkStream stream, RegisterDiverRequest request)
        {
            if (database.RegisterDiverInDatabase(request))
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
                //Should send back to client that something went wrong 
            }
        } 
        public void DispatchMessage(NetworkStream stream, RegisterDiveRequest request)
        {
            if (database.RegisterDiveInDatabase(request))
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
                //Should send back to client that something went wrong 
            }
        }        
        public void DispatchMessage(NetworkStream stream, RegisterTeamRequest request)
        {
            if (database.RegisterTeamInDatabase(request))
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
                //Should send back to client that something went wrong 
            }
        }
        public void DispatchMessage(NetworkStream stream, RegisterJudgeRequest request)
        {
            if (database.RegisterJudgeInDatabase(request))
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
            }
            if (password_database.RegisterJudgeInDatabase(request)) //Password
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
                //Should send back to client that something went wrong 
            }
        }
        public void DispatchMessage(NetworkStream stream, RegisterAdminRequest request)
        {

        }
        public void DispatchMessage(NetworkStream stream, JudgePointRequest request)
        {
            if (database.SendJudgePointToDatabase(request))
            {
                //Successfully registered 

                CompetitionMaintainer CM = new CompetitionMaintainer(request.In_Competition);
                CM.DiveScoreCalculater(request.Dive); //Tries to calculate dive score
            }
            else
            {
                //Failed to registered 
                //Should send back to client that something went wrong 
            }
        }
        public void DispatchMessage(NetworkStream stream, ViewScheduleRequest request)
        {

        }
        public void DispatchMessage(NetworkStream stream, ViewCurrentDiverRequest request)
        {

        }
        public void DispatchMessage(NetworkStream stream, ViewScoreTableRequest request)
        {
            
        }
    }
}