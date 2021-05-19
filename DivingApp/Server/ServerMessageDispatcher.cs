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
        private List<int> AdminsDiveOrder = new List<int>();

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
                case "createschedulerequest":
                    CreateScheduleRequest CreSchReq = JsonConvert.DeserializeObject<CreateScheduleRequest>(JSONString);
                    //TODO: Implement a response and response builder for schedule creation requests
                    response = await DispatchMessage(CreSchReq);
                    break;
                case "nextdiverrequest":
                    NextDiverRequest NexDivReq = JsonConvert.DeserializeObject<NextDiverRequest>(JSONString);
                    List<CompetitionDive> schedule = database.GetCompetitionDives(NexDivReq.CompetitionID);
                    if (AdminsDiveOrder.Count == 0 && schedule != null)
                    {
                        foreach (var dive in schedule)
                        {
                            AdminsDiveOrder.Add(dive.DiveId);
                        }
                    }
                    else
                    {
                        AdminsDiveOrder.RemoveAt(0);
                    }
                    response = await DispatchMessage(NexDivReq);
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
                    response = await DispatchMessage(ViewSchReq);
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
                case "loginrequest":
                    LoginRequest LoginReq = JsonConvert.DeserializeObject<LoginRequest>(JSONString);
                    response = await DispatchMessage(LoginReq);
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

        public async Task<ResultResponse> DispatchMessage(CreateScheduleRequest request)
        {
            Console.WriteLine("Create Schedule request received");
            List<CompetitionDive> schedule = database.GetCompetitionDives(request.CompetitionID);
            foreach(var dive in schedule)
            {
                AdminsDiveOrder.Add(dive.DiveId);
            }
            ResultResponse response = await responseBuilder.CreateScheduleResponse(database.CreateScheduleInDatabase(request));
            return response;
        }

        public async Task<ResultResponse> DispatchMessage(NextDiverRequest request)
        {
            Console.WriteLine("Next Diver request received");
            ResultResponse response = await responseBuilder.NextDiverResponse(true);
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
                CompetitionMaintainer CM = new CompetitionMaintainer(request.In_Competition, database);
                CM.DiveScoreCalculater(request.DiveID, database.GetDiveDifficulty(request.DiveID)); //Tries to calculate dive score
            }
            return await responseBuilder.JudgePointResponse(result);
        }

        public async Task<CompetitionScheduleResponse> DispatchMessage(ViewScheduleRequest request)
        {
            Console.WriteLine("View Schedule request received");
            CompetitionScheduleResponse response = new CompetitionScheduleResponse(/*AdminsDiveOrder[0]*/0, database.GetCompetitionDives(request.Competition_ID));
            return response;
        }

        public async Task DispatchMessage(ViewCurrentDiverRequest request)
        {
            Console.WriteLine("View Current Diver request received");
            //Response response = new CurrentDiverResponse(database.GetDiveInformation(request));
        }

        public async Task DispatchMessage(ViewScoreTableRequest request)
        {
            Console.WriteLine("View Score Table request received");
        }

        public async Task<LoginResponse> DispatchMessage(LoginRequest request)
        {
            //TODO: Sent to databse and check if login is found
            Console.WriteLine("Login request received");
            LoginResponse response = await responseBuilder.LoginResponse(password_database.LoginChecker(request));
            return response;
        }
    }
}