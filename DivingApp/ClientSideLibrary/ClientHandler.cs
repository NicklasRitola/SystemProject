using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace ClientSide
{
    public class ClientHandler : System.Windows.Forms.Form
    {
        protected ClientChannel channel;
        /*public ClientHandler(ClientChannel channel)
        {
            this.channel = channel;
        }*/
        public ClientHandler()
        {
            //this.channel = null;
        }

        public void OpenForm(ClientHandler NewForm, ClientHandler CurrentForm)
        {
            CurrentForm.Hide();
            NewForm.Show();
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
