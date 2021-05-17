using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared;

namespace ClientSide
{
    public class ClientMessageDispatcher : MessageDispatcher
    {
        public override async Task<Response> DispatchMessage(JObject message)
        {
            string JSONString = JsonConvert.SerializeObject(message);
            //Response response = null;
            //TODO: Do stuff
            switch((message.Value<string>("messageType")).ToLower())
            {
                //Response
                case "testresponse":
                    TestResponse testResponse = JsonConvert.DeserializeObject<TestResponse>(JSONString);
                    await DispatchMessage(testResponse);
                    break;
                case "resultresponse":
                    ResultResponse ResResp = JsonConvert.DeserializeObject<ResultResponse>(JSONString);
                    await DispatchMessage(ResResp);
                    break;
                case "scheduleresponse":
                    ScheduleResponse SchResp = JsonConvert.DeserializeObject<ScheduleResponse>(JSONString);
                    await DispatchMessage(SchResp);
                    break;
                case "diverinforesponse":
                    ScoreTableResponse ScoreTableResp = JsonConvert.DeserializeObject<ScoreTableResponse>(JSONString);
                    await DispatchMessage(ScoreTableResp);
                    break;
                case "scoretableresponse":
                    DiverInfoResponse DiverInfoResp = JsonConvert.DeserializeObject<DiverInfoResponse>(JSONString);
                    await DispatchMessage(DiverInfoResp);
                    break;
                case "loginresponse":
                    LoginResponse LoginResp = JsonConvert.DeserializeObject<LoginResponse>(JSONString);
                    await DispatchMessage(LoginResp);
                    break;
            }
            return null;
        }

        // Response messages from server
        public async Task DispatchMessage(TestResponse response)
        {
            Console.WriteLine("Received testresponse from server!");
        }
        public async Task DispatchMessage(ResultResponse response)
        {

        }
        public async Task DispatchMessage(ScheduleResponse response)
        {

        }
        public async Task DispatchMessage(DiverInfoResponse response)
        {

        }
        public async Task DispatchMessage(ScoreTableResponse response)
        {

        }
        public async Task DispatchMessage(LoginResponse response)
        {

        }
    }
}
