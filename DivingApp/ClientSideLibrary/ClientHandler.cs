using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace ClientSide
{
    public class ClientHandler : System.Windows.Forms.Form
    {
        public void OpenForm(ClientHandler NewForm, ClientHandler CurrentForm)
        {
            CurrentForm.Hide();
            NewForm.Show();
        }

        public void ClientCreateCompetition(CreateCompetitionRequest request)

        private ClientChannel channel;

        public ClientHandler(ClientChannel channel)
        {
            this.channel = channel;
        }
        public void CreateCompetition()
        {

        }

        public void ClientRegisterJudge(RegisterJudgeRequest request)
        {
            //Send message to server
        }
    }

    public class LoginGlobalString
    {
        private static string LoginString = "";
        public static string GlobalString
        {
            get { return LoginString; }
            set { LoginString = value; }
        }
    }
}
