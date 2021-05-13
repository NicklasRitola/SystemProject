using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Login : SuperForm
    {

        public Login()
        {
            InitializeComponent();
        }

        public void LoginButton_Click(object sender, EventArgs e)
        {
             //Fixa så den kollar lösen + namn med databas (så att det existerar).


            string loginName = Username.Text;
            string loginPassword = Password.Text;


            if(LoginGlobalString.GlobalString == "Admin")
            {
                Administrator adminForm = new Administrator();
                adminForm.Show();
            }
            if (LoginGlobalString.GlobalString == "Judge")
            {
                Judge judgeForm = new Judge();
                judgeForm.Show();
            }
            if (LoginGlobalString.GlobalString == "Diver")
            {
                Diver diverForm = new Diver();
                diverForm.Show();
            }



            this.Hide();
            
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            OpenForm(form1Form, this);
        }
    }
}
