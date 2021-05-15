using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Server
{
    public class MessageDispatcher
    {
        //Finds the type of the message and sends it to the appropriate handler method

        private DatabaseHandler database = new DatabaseHandler(); 
        private DatabaseHandler password_database = new PasswordDatabaseHandler();

        public void DispatchMessage(JObject message)
        {
            string JSONString = JsonConvert.SerializeObject(message);

            switch (message.Value<string>("messageType"))
            {
                case "createcompetitionrequest":
                    CreateCompetitionRequest CreCompReq = JsonConvert.DeserializeObject<CreateCompetitionRequest>(JSONString);
                    DispatchMessage(CreCompReq);
                    break;
                case "createschedulerequest":
                    CreateScheduleRequest CreSchReq = JsonConvert.DeserializeObject<CreateScheduleRequest>(JSONString);
                    DispatchMessage(CreSchReq);
                    break;
                case "nextdiverrequest":
                    NextDiverRequest NexDivReq = JsonConvert.DeserializeObject<NextDiverRequest>(JSONString);
                    DispatchMessage(NexDivReq);
                    break;
                case "registerdiverrequest":
                    RegisterDiverRequest RegDiverReq = JsonConvert.DeserializeObject<RegisterDiverRequest>(JSONString);
                    DispatchMessage(RegDiverReq);
                    break;
                case "registerdiverequest":
                    RegisterDiveRequest RegDiveReq = JsonConvert.DeserializeObject<RegisterDiveRequest>(JSONString);
                    DispatchMessage(RegDiveReq);
                    break;
                case "registerteamrequest":
                    RegisterTeamRequest RegTeamReq = JsonConvert.DeserializeObject<RegisterTeamRequest>(JSONString);
                    DispatchMessage(RegTeamReq);
                    break;
                case "registerjudgerequest":
                    RegisterJudgeRequest RegJudgeReq = JsonConvert.DeserializeObject<RegisterJudgeRequest>(JSONString);
                    DispatchMessage(RegJudgeReq);
                    break;
                case "registeradminrequest":
                    RegisterAdminRequest RegAdminReq = JsonConvert.DeserializeObject<RegisterAdminRequest>(JSONString);
                    DispatchMessage(RegAdminReq);
                    break;
                case "judgepointrequest":
                    JudgePointRequest JudgePointReq = JsonConvert.DeserializeObject<JudgePointRequest>(JSONString);
                    DispatchMessage(JudgePointReq);
                    break;
                case "viewschedulerequest":
                    ViewScheduleRequest ViewSchReq = JsonConvert.DeserializeObject<ViewScheduleRequest>(JSONString);
                    DispatchMessage(ViewSchReq);
                    break;
                case "viewcurrentdiverrequest":
                    ViewCurrentDiverRequest ViewCurrDiverReq = JsonConvert.DeserializeObject<ViewCurrentDiverRequest>(JSONString);
                    DispatchMessage(ViewCurrDiverReq);
                    break;
                case "viewscoretablerequest":
                    ViewScoreTableRequest ViewScoTableReq = JsonConvert.DeserializeObject<ViewScoreTableRequest>(JSONString);
                    DispatchMessage(ViewScoTableReq);
                    break;
            }
        }

        public void DispatchMessage(CreateCompetitionRequest request)
        {
            if (database.CreateCompetitionInDatabase(request))
            {
                //Successfully created
            }
            else
            {
                //Failed to create 
            }
        }
        public void DispatchMessage(CreateScheduleRequest request)
        {

        }
        public void DispatchMessage(NextDiverRequest request)
        {

        }
        public void DispatchMessage(RegisterDiverRequest request)
        {
            if (database.RegisterDiverInDatabase(request))
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
            }
        } 
        public void DispatchMessage(RegisterDiveRequest request)
        {
            if (database.RegisterDiveInDatabase(request))
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
            }
        }        
        public void DispatchMessage(RegisterTeamRequest request)
        {
            if (database.RegisterTeamInDatabase(request))
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
            }
        }
        public void DispatchMessage(RegisterJudgeRequest request)
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
            }
        }
        public void DispatchMessage(RegisterAdminRequest request)
        {

        }
        public void DispatchMessage(JudgePointRequest request)
        {
            if (database.SendJudgePointToDatabase(request))
            {
                //Successfully registered 
            }
            else
            {
                //Failed to registered 
            }
        }
        public void DispatchMessage(ViewScheduleRequest request)
        {

        }
        public void DispatchMessage(ViewCurrentDiverRequest request)
        {

        }
        public void DispatchMessage(ViewScoreTableRequest request)
        {
            
        }
        
        /*public void DispatchMessage<T>(T request)
        {
            //Finds the type of the message and sends it to the appropriate handler method
            
        }*/
    }
}