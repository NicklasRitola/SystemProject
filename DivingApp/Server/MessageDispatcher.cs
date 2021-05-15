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
            switch(message.Value<string>("messageType"))
            {
                case "createcompetitionrequest":
                    string JSONString = JsonConvert.SerializeObject(message);
                    CreateCompetitionRequest req = JsonConvert.DeserializeObject<CreateCompetitionRequest>(JSONString);
                    DispatchMessage(req);
                    break;
                case "testmessage":
                    Console.WriteLine("Test message received");
                    break;
            }
        }

        public void DispatchMessage(CreateCompetitionRequest request)
        {
            Console.WriteLine("Create competition request");
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