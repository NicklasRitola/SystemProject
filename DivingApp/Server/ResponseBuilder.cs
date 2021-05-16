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
        //Takes a request and a stream, creates a response, sends response back
        public async Task<ResultResponse> CreateCompetitionResponse(NetworkStream stream, bool result)
        {
            ResultResponse response = new ResultResponse("Competition creation request", result);
            return response;
        }
        public async Task<ResultResponse> CreateScheduleResponse(NetworkStream stream, bool result)
        {
            ResultResponse response = new ResultResponse("Schedule creation request", result);
            return response;
        }
        public async Task NextDiverResponse(NetworkStream stream, bool result)
        {
            //TODO: Get next diver, create response to return
        }
        public async Task<ResultResponse> RegisterDiverResponse(NetworkStream stream, bool result)
        {
            ResultResponse response = new ResultResponse("Diver registration", result);
            return response;
        }
        public async Task<ResultResponse> RegisterDiveResponse(NetworkStream stream, bool result)
        {
            ResultResponse response = new ResultResponse("Dive registration", result);
            return response;
        }
        public async Task<ResultResponse> RegisterTeamResponse(NetworkStream stream, bool result)
        {
            ResultResponse response = new ResultResponse("Schedule creation", result);
            return response;
        }
        public async Task<ResultResponse> RegisterJudgeResponse(NetworkStream stream, bool result)
        {
            ResultResponse response = new ResultResponse("Judge registration", result);
            return response;
        }
        public async Task<ResultResponse> RegisterAdminResponse(NetworkStream stream, bool result)
        {
            ResultResponse response = new ResultResponse("Admin registration", result);
            return response;
        }
        public async Task ViewScheduleResponse(NetworkStream stream, bool result)
        {
            //TODO: Create a schedule response message to return
        }
        public async Task ViewCurrentDiverResponse(NetworkStream stream, bool result)
        {
            //TODO: Create a current diver response message to return
        }
        public async Task ViewScoreTableResponse(NetworkStream stream, bool result)
        {
            //TODO: Create a score table response to return
        }
    }
}
