using System;
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
        private ResponseBuilder responseBuilder = new ResponseBuilder();

        public async Task<Response> DispatchMessage(NetworkStream stream, JObject message)
        {
            string JSONString = JsonConvert.SerializeObject(message);
            Response response = null;

            switch (message.Value<string>("messageType")) // Extracts the message type
            {
                case "createcompetitionrequest":
                    CreateCompetitionRequest CreCompReq = JsonConvert.DeserializeObject<CreateCompetitionRequest>(JSONString);
                    response = await DispatchMessage(CreCompReq);
                    break;
                case "createschedulerequest":
                    CreateScheduleRequest CreSchReq = JsonConvert.DeserializeObject<CreateScheduleRequest>(JSONString);
                    //TODO: Implement a response and response builder for schedule creation requests
                    //response = await DispatchMessage(CreSchReq);
                    break;
                case "nextdiverrequest":
                    NextDiverRequest NexDivReq = JsonConvert.DeserializeObject<NextDiverRequest>(JSONString);
                    //TODO: Implement a response and response builder for next diver requests
                    //response = await DispatchMessage(NexDivReq);
                    break;
                case "registerdiverrequest":
                    RegisterDiverRequest RegDiverReq = JsonConvert.DeserializeObject<RegisterDiverRequest>(JSONString);
                    response = await DispatchMessage(RegDiverReq);
                    break;
                case "registerdiverequest":
                    RegisterDiveRequest RegDiveReq = JsonConvert.DeserializeObject<RegisterDiveRequest>(JSONString);
                    response = await DispatchMessage(RegDiveReq);
                    break;
                case "registerteamrequest":
                    RegisterTeamRequest RegTeamReq = JsonConvert.DeserializeObject<RegisterTeamRequest>(JSONString);
                    response = await DispatchMessage(RegTeamReq);
                    break;
                case "registerjudgerequest":
                    RegisterJudgeRequest RegJudgeReq = JsonConvert.DeserializeObject<RegisterJudgeRequest>(JSONString);
                    response = await DispatchMessage(RegJudgeReq);
                    break;
                case "registeradminrequest":
                    RegisterAdminRequest RegAdminReq = JsonConvert.DeserializeObject<RegisterAdminRequest>(JSONString);
                    response = await DispatchMessage(RegAdminReq);
                    break;
                case "judgepointrequest":
                    JudgePointRequest JudgePointReq = JsonConvert.DeserializeObject<JudgePointRequest>(JSONString);
                    response = await DispatchMessage(JudgePointReq);
                    break;
                case "viewschedulerequest":
                    ViewScheduleRequest ViewSchReq = JsonConvert.DeserializeObject<ViewScheduleRequest>(JSONString);
                    //TODO: Implement response for schedule request
                    //response = await DispatchMessage(ViewSchReq);
                    break;
                case "viewcurrentdiverrequest":
                    ViewCurrentDiverRequest ViewCurrDiverReq = JsonConvert.DeserializeObject<ViewCurrentDiverRequest>(JSONString);
                    //TODO: Implement response for current diver
                    //response = await DispatchMessage(ViewCurrDiverReq);
                    break;
                case "viewscoretablerequest":
                    ViewScoreTableRequest ViewScoTableReq = JsonConvert.DeserializeObject<ViewScoreTableRequest>(JSONString);
                    //TODO: Implement response for score table response
                    //response = await DispatchMessage(ViewScoTableReq);
                    break;
            }
            return response;
        }

        public async Task<ResultResponse> DispatchMessage(CreateCompetitionRequest request)
        {
            return await responseBuilder.CreateCompetitionResponse(database.CreateCompetitionInDatabase(request));
        }
        public async Task/*<ResultResponse>*/ DispatchMessage(CreateScheduleRequest request)
        {
            //TODO: return  result response with following call:
            //return await responseBuilder.CreateScheduleResponse(INSERT DATABASE FUNCTION WHICH RETURNS BOOL);
        }
        public async Task DispatchMessage(NextDiverRequest request)
        {

        }
        public async Task<ResultResponse> DispatchMessage(RegisterDiverRequest request)
        {
            return await responseBuilder.RegisterDiverResponse(database.RegisterDiverInDatabase(request));
        } 
        public async Task<ResultResponse> DispatchMessage(RegisterDiveRequest request)
        {
            return await responseBuilder.RegisterDiveResponse(database.RegisterDiveInDatabase(request));
        }        
        public async Task<ResultResponse> DispatchMessage(RegisterTeamRequest request)
        {
            return await responseBuilder.RegisterTeamResponse(database.RegisterTeamInDatabase(request));
        }
        public async Task<ResultResponse> DispatchMessage(RegisterJudgeRequest request)
        {
            bool dataRegistered = false;
            bool passwordRegistered = false;
            if (database.RegisterJudgeInDatabase(request)) //Data
            {
                //Registration succeeded
                dataRegistered = true;
            }
            if (password_database.RegisterJudgeInDatabase(request)) //Password
            {
                //Registration succeeded
                passwordRegistered = true;
            }
            return await responseBuilder.RegisterJudgeResponse(dataRegistered, passwordRegistered);
        }
        public async Task<ResultResponse> DispatchMessage(RegisterAdminRequest request)
        {
            bool dataRegistered = false;
            bool passwordRegistered = false;
            //Fill in with admind database registration as done with RegisterJudge
            //if ()) //Data
            //{
            //    //Registration succeeded
            //    dataRegistered = true;
            //}
            //if () //Password
            //{
            //    //Registration succeeded
            //    passwordRegistered = true;
            //}
            return await responseBuilder.RegisterAdminResponse(dataRegistered, passwordRegistered);
        }
        public async Task<ResultResponse> DispatchMessage(JudgePointRequest request)
        {
            //TODO: Calculate score, and register, store result in "result" boolean
            bool result = false;
            if (database.SendJudgePointToDatabase(request))
            {
                //Successfully registered 

                CompetitionMaintainer CM = new CompetitionMaintainer(request.In_Competition, database);
                CM.DiveScoreCalculater(request.Dive); //Tries to calculate dive score
            }
            else
            {
                //Failed to registered 
                //Should send back to client that something went wrong 
            }
            return await responseBuilder.JudgePointResponse(result);
        }
        public async Task DispatchMessage(ViewScheduleRequest request)
        {

        }
        public async Task DispatchMessage(ViewCurrentDiverRequest request)
        {

        }
        public async Task DispatchMessage(ViewScoreTableRequest request)
        {
            
        }
    }
}