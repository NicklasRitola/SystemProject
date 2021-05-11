using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Login : Form
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
            if (LoginGlobalString.GlobalString == "Coach")
            {
                Coach coachForm = new Coach();
                coachForm.Show();
            }


            this.Hide();
            
        }
    }
}
