using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Shared;

namespace ClientUI
{
    public partial class CreateCompetition : ClientHandler
    {
        public CreateCompetition(ClientChannel channel) 
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.channel = channel;
        }

        private void AdminMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator(channel);
            OpenForm(adminForm, this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTeam_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void textBoxFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAge_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelSur_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSur_TextChanged(object sender, EventArgs e)
        {

        }
        private int checkCounter;
        private int checkType;
        private void checkCounterFunction(object sender, EventArgs e)
        {// Increase or decrease the check counter
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
            if (textBoxLocation.Text == "") { NoEmptyFields.Add("Location - Empty field"); }
            if (textBoxDate.Text == "") { NoEmptyFields.Add("Start date - Empty field"); }
            if (textBoxEndDate.Text == "") { NoEmptyFields.Add("End date - Empty field"); }
            if (textBoxID.Text == "") { NoEmptyFields.Add("ID - Empty field"); }
            else if (!(int.TryParse(textBoxID.Text, out _))) { NoEmptyFields.Add("ID - Not an integer"); }
            if (checkBoxGlobal.Checked == false && checkBoxLocal.Checked == false) { NoEmptyFields.Add("No competition type selected"); }

            if(NoEmptyFields.Count == 0)
            {
                CreateCompetitionRequest request = new CreateCompetitionRequest();
                request.Location = textBoxLocation.Text;
                request.Start_Date = textBoxDate.Text;
                request.End_Date = textBoxEndDate.Text;
                request.ID = Int32.Parse(textBoxID.Text);
                request.Type = checkType;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxGlobal_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
            checkType = 2;
        }

        private void checkBoxLocal_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
            checkType = 1;
        }
    }
}
