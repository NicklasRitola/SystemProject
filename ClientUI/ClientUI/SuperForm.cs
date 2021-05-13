using System;
using System.Collections.Generic;
using System.Text;
using Shared;
using ClientSide;

namespace ClientUI
{
    class LoginGlobalString
    {
        private static string LoginString = "";
        public static string GlobalString
        {
            get { return LoginString; }
            set { LoginString = value; }
        }
    }
    public class SuperForm : System.Windows.Forms.Form
    {
        public SuperForm()
        {

        }


        public void OpenForm(SuperForm NewForm, SuperForm CurrentForm)
        {
            CurrentForm.Hide();
            
            NewForm.Show();
        }
        
        public void HideButton()
        {

        }
    }
}
