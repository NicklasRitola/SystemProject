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
    public partial class CreateProfile : ClientHandler
    {
        public CreateProfile(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void labelDifficulty_Click(object sender, EventArgs e)
        {

        }
        private int checkCounter;
        private string checkGender;
        private void label1_Click(object sender, EventArgs e)
        {

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
        private async void RegisterProfile_Click(object sender, EventArgs e)
        {
            //Check to see that all required field are filled
            List<string> NoEmptyFields = new List<String>();
            if(textBoxTeam.Text == ""){ NoEmptyFields.Add("Team ID - Empty field"); }
            else if (!(int.TryParse(textBoxTeam.Text, out _))) { NoEmptyFields.Add("Team ID - Not an integer"); }
            if(textBoxFirst.Text == ""){ NoEmptyFields.Add("First name - Empty field"); }
            if(textBoxSur.Text == ""){ NoEmptyFields.Add("Surname - Empty field"); }
            if(textBoxAge.Text == ""){ NoEmptyFields.Add("Age - Empty field"); }
            else if (!(int.TryParse(textBoxAge.Text, out _))) { NoEmptyFields.Add("Age - Not an integer"); }
            if (checkBoxMale.Checked == false && checkBoxFemale.Checked == false){ NoEmptyFields.Add("No gender selected"); }
            if(textBoxUsername.Text == ""){ NoEmptyFields.Add("Social security number - Empty field"); }
            if(textBoxPassword.Text == ""){ NoEmptyFields.Add("Password - Empty field"); }
            if(textBoxPassword.Text != "" && textBoxConfirm.Text == "") { NoEmptyFields.Add("Confirm password - Empty field"); }
            if(textBoxPassword.Text != textBoxConfirm.Text && textBoxPassword.Text != "") { NoEmptyFields.Add("Password doesn't match"); }

            // Creations of the diver profile 
            if(NoEmptyFields.Count == 0)
            {
                RegisterDiverRequest request = new RegisterDiverRequest();
                request.FirstName = textBoxFirst.Text;
                request.Surname = textBoxSur.Text;
                request.Age = Int32.Parse(textBoxAge.Text);
                request.Team = Int32.Parse(textBoxTeam.Text);
                request.Gender = checkGender;
                request.SSN = textBoxUsername.Text;
                request.Password = textBoxPassword.Text;

                await channel.SendAsync(request);
                JObject response = await channel.ReceiveResponse();
                ShowMessage(response.Value<string>("message"), "Registration result");
            }
            else
            {
                string output = "";
                for (int i = 0; i < NoEmptyFields.Count; i++)
                {
                    output += ("• " + NoEmptyFields[i] + "\n");
                }
                MessageBox.Show("Invalid input: \n" + output, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NoEmptyFields.Clear();
        }

        private void textBoxDifficulty_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
            checkGender = "Male";
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
            checkGender = "Female";
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
