using Shared;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ResponseBuilder
    {
        //Takes a request and a stream, creates a response, returns response
        public async Task<TestResponse> CreateTestResponse()
        {
            //Returns an instance of the TestResponse class. Used for channel testing
            return new TestResponse();
        }

        public async Task<ResultResponse> CreateCompetitionResponse(bool result)
        {
            //Returns a tailored result response
            ResultResponse response = new ResultResponse("Competition creation request", result);
            return response;
        }

        public async Task<ResultResponse> CreateScheduleResponse(bool result)
        {
            //Returns a tailored result response
            ResultResponse response = new ResultResponse("Schedule creation request", result);
            return response;
        }

        public async Task NextDiverResponse(bool result)
        {
            //TODO: Get next diver, create response to return
        }

        public async Task<ResultResponse> RegisterDiverResponse(bool data, bool pass)
        {
            ResultResponse response = new ResultResponse("Diver data registration", "Password registration", data, pass);
            return response;
        }

        public async Task<ResultResponse> RegisterDiveResponse(bool result)
        {
            ResultResponse response = new ResultResponse("Dive registration", result);
            return response;
        }

        public async Task<ResultResponse> RegisterTeamResponse(bool result)
        {
            ResultResponse response = new ResultResponse("Schedule creation", result);
            return response;
        }

        public async Task<ResultResponse> RegisterJudgeResponse(bool data, bool pass)
        {
            ResultResponse response = new ResultResponse("Judge data registration", "Password registration", data, pass);
            return response;
        }

        public async Task<ResultResponse> RegisterAdminResponse(bool data, bool pass)
        {
            ResultResponse response = new ResultResponse("Admin data registration", "Password registration", data, pass);
            return response;
        }

        public async Task<ResultResponse> JudgePointResponse(bool result)
        {
            ResultResponse response = new ResultResponse("Point registration", result);
            return response;
        }

        public async Task ViewScheduleResponse(bool result)
        {
            //TODO: Create a schedule response message to return
        }

        public async Task ViewCurrentDiverResponse(bool result)
        {
            //TODO: Create a current diver response message to return
        }

        public async Task ViewScoreTableResponse(bool result)
        {
            //TODO: Create a score table response to return
        }

        public async Task<LoginResponse> LoginResponse(bool result)
        {
            LoginResponse response = new LoginResponse();
            response.Success = result;
            return response;
        }
    }
}
