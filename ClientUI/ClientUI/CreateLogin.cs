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
    public partial class CreateLogin : ClientHandler
    {
        public CreateLogin(ClientChannel channel)
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator(channel);
            OpenForm(adminForm, this);
        }
        private int checkCounter;

        private async void RegisterProfile_Click(object sender, EventArgs e)
        {
            //Check to see that all field are filled
            List<string> NoEmptyFields = new List<String>();
            if (textboxFirstName.Text == "")
            {
                NoEmptyFields.Add("First name - Empty field");
            }
            if (textboxSurname.Text == "")
            {
                NoEmptyFields.Add("Surname - Empty field");
            }
            if (textBoxUsername.Text == "")
            {
                NoEmptyFields.Add("Social security number - Empty field");
            }
            if(textBoxPassword.Text == "")
            {
                NoEmptyFields.Add("Password - Empty field");
            }
            if (textBoxConfirm.Text == "" && textBoxUsername.Text != "")
            {
                NoEmptyFields.Add("Confirm password - Empty field");
            }
            if (textBoxConfirm.Text != textBoxPassword.Text && textBoxPassword.Text != "")
            {
                NoEmptyFields.Add("Password doesn't match");
            }
            if (checkBoxAdmin.Checked == false && checkBoxJudge.Checked == false)
            {
                NoEmptyFields.Add("Type of profile needs to be selected");
            }

            // Creations of the profiles 
            if (NoEmptyFields.Count == 0)
            {
                if (checkBoxAdmin.Checked)
                {
                    RegisterAdminRequest admin = new RegisterAdminRequest();
                    admin.SSN = textBoxUsername.Text;
                    admin.Password = textBoxPassword.Text;
                    admin.FirstName = textboxFirstName.Text;
                    admin.Surname = textboxSurname.Text;

                    await channel.SendAsync(admin);
                    JObject response = await channel.ReceiveResponse();
                    ShowMessage(response.Value<string>("message"), "Registration result");

                    Administrator adminForm = new Administrator(channel);
                    OpenForm(adminForm, this);
                }
                else if (checkBoxJudge.Checked)
                {
                    RegisterJudgeRequest judge = new RegisterJudgeRequest();
                    judge.SSN = textBoxUsername.Text;
                    judge.Password = textBoxPassword.Text;
                    judge.FirstName = textboxFirstName.Text;
                    judge.Surname = textboxSurname.Text;

                    await channel.SendAsync(judge);
                    JObject response = await channel.ReceiveResponse();
                    ShowMessage(response.Value<string>("message"), "Registration result");

                    Administrator adminForm = new Administrator(channel);
                    OpenForm(adminForm, this);
                }
            }
            else
            {
                string output = "";
                for(int i = 0; i < NoEmptyFields.Count; i++)
                {
                    output += ("• " + NoEmptyFields[i] + "\n");
                }
                MessageBox.Show("Invalid input: \n" + output, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NoEmptyFields.Clear();
        }
        private void checkCounterFunction(object sender, EventArgs e)
        {
            // Increase or decrease the check counter
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                checkCounter++;
            else
                checkCounter--;
            // prevent checking
            if (checkCounter == 2)
            {
                MessageBox.Show("Chose one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Checked = false;
            }
        }

        private void checkBoxJudge_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
