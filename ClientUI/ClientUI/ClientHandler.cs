using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace ClientUI
{
    public class ClientHandler : System.Windows.Forms.Form
    {
        protected ClientChannel channel;

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
