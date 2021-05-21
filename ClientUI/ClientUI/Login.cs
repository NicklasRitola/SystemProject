using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared;

namespace ClientUI
{
    public partial class Login : ClientHandler
    {

        public Login(ClientChannel channel)
        {
            InitializeComponent();
            this.channel = channel;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public async void LoginButton_Click(object sender, EventArgs e)
        {
            List<string> NoEmptyFields = new List<String>();
            bool resp = false;
            if (Username.Text == "")
            {
                NoEmptyFields.Add("Username");
            }
            if (Username.Text == "")
            {
                NoEmptyFields.Add("Password");
            }

            if(NoEmptyFields.Count == 0)
            {
                LoginRequest login = new LoginRequest();
                login.SSN = Username.Text;
                login.Password = Password.Text;
                login.LoginType = LoginGlobalString.GlobalString;

                await channel.SendAsync(login);
                JObject response = await channel.ReceiveResponse();
                resp = response.Value<bool>("Success"); 
            }
            else
            {
                string output = "";
                for (int i = 0; i < NoEmptyFields.Count; i++)
                {
                    output += ("- " + NoEmptyFields[i] + "\n");
                }
                MessageBox.Show("Invalid input: \n" + output, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(resp && NoEmptyFields.Count == 0)
            {
                if (LoginGlobalString.GlobalString == "Admin")
                {
                    Administrator adminForm = new Administrator(channel);
                    adminForm.Show();
                }
                if (LoginGlobalString.GlobalString == "Judge")
                {
                    LoginGlobalString.SSN = Username.Text;
                    Judge judgeForm = new Judge(channel);
                    judgeForm.Show();
                }
                if (LoginGlobalString.GlobalString == "Diver")
                {
                    LoginGlobalString.SSN = Username.Text;
                    DiverMenu diverMenuForm = new DiverMenu(channel);
                    diverMenuForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NoEmptyFields.Clear();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            this.Hide();
            form1Form.Show();
        }
    }
}
