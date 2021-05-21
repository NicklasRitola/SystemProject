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
    public class ServerMessageDispatcher : MessageDispatcher
    {
        //Finds the type of the message and sends it to the appropriate handler method

        private readonly DatabaseHandler database = new DatabaseHandler();
        private readonly DatabaseHandler password_database = new PasswordDatabaseHandler();
        private readonly ResponseBuilder responseBuilder = new ResponseBuilder();

        public override async Task<Response> DispatchMessage(JObject message)
        {
            string JSONString = JsonConvert.SerializeObject(message);
            Response response = null;

            switch ((message.Value<string>("messageType")).ToLower()) // Extracts the message type
            {
                case "testrequest":
                    TestRequest testReq = JsonConvert.DeserializeObject<TestRequest>(JSONString);
                    response = await DispatchMessage(testReq);
                    break;
                case "createcompetitionrequest":
                    CreateCompetitionRequest CreCompReq = JsonConvert.DeserializeObject<CreateCompetitionRequest>(JSONString);
                    response = await DispatchMessage(CreCompReq);
                    break;
                case "nextdiverrequest":
                    NextDiverRequest NexDivReq = JsonConvert.DeserializeObject<NextDiverRequest>(JSONString);
                    response = await DispatchMessage(NexDivReq);
                    break;
                case "registerdiverrequest":
                    RegisterDiverRequest RegDiverReq = JsonConvert.DeserializeObject<RegisterDiverRequest>(JSONString);
                    response = await DispatchMessage(RegDiverReq);
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
                case "loginrequest":
                    LoginRequest LoginReq = JsonConvert.DeserializeObject<LoginRequest>(JSONString);
                    response = await DispatchMessage(LoginReq);
                    break;
                case "deletecompetitionrequest":
                    DeleteCompetitionRequest DelCompReq = JsonConvert.DeserializeObject<DeleteCompetitionRequest>(JSONString);
                    response = await DispatchMessage(DelCompReq);
                    break;
                case "schedulerequest":
                    ScheduleRequest SchReq = JsonConvert.DeserializeObject<ScheduleRequest>(JSONString);
                    response = await DispatchMessage(SchReq);
                    break;
                case "scoreboardrequest":
                    ScoreboardRequest ScoReq = JsonConvert.DeserializeObject<ScoreboardRequest>(JSONString);
                    response = await DispatchMessage(ScoReq);
                    break;
            }
            return response;
        }

        public async Task<TestResponse> DispatchMessage(TestRequest request)
        {
            Console.WriteLine("View Schedule request received");
            return await responseBuilder.CreateTestResponse();
        }

        public async Task<ResultResponse> DispatchMessage(CreateCompetitionRequest request)
        {
            Console.WriteLine("View Schedule request received");
            Console.WriteLine("SERVER RECEIVED: " + request.Location);
            return await responseBuilder.CreateCompetitionResponse(database.CreateCompetitionInDatabase(request));
        }

        public async Task<ResultResponse> DispatchMessage(NextDiverRequest request)
        {
            Console.WriteLine("Next Diver request received");
            ResultResponse response = await responseBuilder.NextDiverResponse(database.NextDiverInCompetition(request.CompetitionID));
            return response;
        }

        public async Task<ResultResponse> DispatchMessage(RegisterDiverRequest request)
        {
            Console.WriteLine("Register Diver request received");
            bool dataRegistered = false;
            bool passwordRegistered = false;
            if (database.RegisterDiverInDatabase(request)) // Data
            {
                dataRegistered = true;
            }
            if (dataRegistered && password_database.RegisterDiverInDatabase(request)) // Password
            {
                passwordRegistered = true;
            }
            
            return await responseBuilder.RegisterDiverResponse(dataRegistered, passwordRegistered);
        } 

        public async Task<ResultResponse> DispatchMessage(RegisterDiveRequest request)
        {
            Console.WriteLine("Register Dive request received");
            return await responseBuilder.RegisterDiveResponse(database.RegisterDiveInDatabase(request));
        }        

        public async Task<ResultResponse> DispatchMessage(RegisterTeamRequest request)
        {
            Console.WriteLine("Register Team request received");
            return await responseBuilder.RegisterTeamResponse(database.RegisterTeamInDatabase(request));
        }

        public async Task<ResultResponse> DispatchMessage(RegisterJudgeRequest request)
        {
            Console.WriteLine("Register Judge request received");
            bool dataRegistered = false;
            bool passwordRegistered = false;
            if (database.RegisterJudgeInDatabase(request)) //Data
            {
                //Registration succeeded
                dataRegistered = true;
            }
            if (dataRegistered && password_database.RegisterJudgeInDatabase(request)) //Password
            {
                //Registration succeeded
                passwordRegistered = true;
            }
            return await responseBuilder.RegisterJudgeResponse(dataRegistered, passwordRegistered);
        }

        public async Task<ResultResponse> DispatchMessage(RegisterAdminRequest request)
        {
            Console.WriteLine("Register Admin request received");
            bool dataRegistered = false;
            bool passwordRegistered = false;
            if (database.RegisterAdminInDatabase(request)) //Data
            {
                //Registration succeeded
                dataRegistered = true;
            }
            if (dataRegistered && password_database.RegisterAdminInDatabase(request)) //Password
            {
                //Registration succeeded
                passwordRegistered = true;
            }
            return await responseBuilder.RegisterAdminResponse(dataRegistered, passwordRegistered);
        }

        public async Task<ResultResponse> DispatchMessage(JudgePointRequest request)
        {
            Console.WriteLine("Judge point registration request received");
            bool result = false;
            if (database.SendJudgePointToDatabase(request))
            {
                //Successfully registered 
                CompetitionMaintainer CM = new CompetitionMaintainer(request.CompetitionID, database);
                CM.DiveScoreCalculater(request.DiveID, database.GetDiveDifficulty(request.DiveID)); //Tries to calculate dive score
                result = true;
            }
            return await responseBuilder.JudgePointResponse(result);
        }

        public async Task<LoginResponse> DispatchMessage(LoginRequest request)
        {
            //TODO: Sent to databse and check if login is found
            Console.WriteLine("Login request received");
            LoginResponse response = await responseBuilder.LoginResponse(password_database.LoginChecker(request));
            return response;
        }

        public async Task<ResultResponse> DispatchMessage(DeleteCompetitionRequest request)
        {
            Console.WriteLine("Delete competition request received");
            return await responseBuilder.DeleteCompetitionResponse(database.DeleteCompetitionInDatabase(request.ID));
        }

        //Philip test
        public async Task<ScheduleResponse> DispatchMessage(ScheduleRequest request)
        {
            Console.WriteLine("Schedule request received");
            ScheduleResponse response = database.FetchScheduleFromDatabase(request.Competition_ID);
            return response;
        }
        public async Task<ScoreboardResponse> DispatchMessage(ScoreboardRequest request)
        {
            Console.WriteLine("Scoreboard request received");
            ScoreboardResponse response = database.FetchScoreboardFromDatabase(request.Competition_ID);
            return response;
        }
    }
}