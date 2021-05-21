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
        public Task<TestResponse> CreateTestResponse()
        {
            //Returns an instance of the TestResponse class. Used for channel testing
            return Task.FromResult(new TestResponse());
        }

        public Task<ResultResponse> CreateCompetitionResponse(bool result)
        {
            //Returns a tailored result response
            ResultResponse response = new ResultResponse("Competition creation request", result);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> CreateScheduleResponse(bool result)
        {
            //Returns a tailored result response
            ResultResponse response = new ResultResponse("Schedule creation request", result);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> NextDiverResponse(bool result)
        {
            ResultResponse response = new ResultResponse("Next diver request", result);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> RegisterDiverResponse(bool data, bool pass)
        {
            ResultResponse response = new ResultResponse("Diver data registration", "Password registration", data, pass);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> RegisterDiveResponse(bool result)
        {
            ResultResponse response = new ResultResponse("Dive registration", result);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> RegisterTeamResponse(bool result)
        {
            ResultResponse response = new ResultResponse("Schedule creation", result);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> RegisterJudgeResponse(bool data, bool pass)
        {
            ResultResponse response = new ResultResponse("Judge data registration", "Password registration", data, pass);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> RegisterAdminResponse(bool data, bool pass)
        {
            ResultResponse response = new ResultResponse("Admin data registration", "Password registration", data, pass);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> JudgePointResponse(bool result)
        {
            ResultResponse response = new ResultResponse("Point registration", result);
            return Task.FromResult(response);
        }

        public Task<ResultResponse> DeleteCompetitionResponse(bool result)
        {
            ResultResponse response = new ResultResponse("Delete competition", result);
            return Task.FromResult(response);
        }

        public Task<LoginResponse> LoginResponse(bool result)
        {
            LoginResponse response = new LoginResponse();
            response.Success = result;
            return Task.FromResult(response);
        }
    }
}
