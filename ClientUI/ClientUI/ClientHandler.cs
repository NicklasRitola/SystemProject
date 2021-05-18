using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Shared;

namespace ClientUI
{
    public class ClientHandler : System.Windows.Forms.Form
    {
        protected ClientChannel channel;

        protected void OpenForm(ClientHandler NewForm, ClientHandler CurrentForm)
        {
            CurrentForm.Hide();
            NewForm.Show();
        }

        protected void ShowMessage(String caption, String body)
        {
            MessageBox.Show(caption, body, MessageBoxButtons.OK);
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

        private static string ssn = "";
        public static string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

    }
}
