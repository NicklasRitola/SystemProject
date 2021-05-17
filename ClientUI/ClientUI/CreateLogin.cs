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
        private string loginType;

        private void ShowMessage(String caption, String body)
        {
            MessageBox.Show(caption, body, MessageBoxButtons.OK);
        }

        private async void RegisterProfile_Click(object sender, EventArgs e)
        {
            RegisterJudgeRequest judge = new RegisterJudgeRequest();
            judge.SSN = textBoxUsername.Text;
            judge.Password = textBoxPassword.Text;
            judge.FirstName = textboxFirstName.Text;
            judge.Surname = textboxSurname.Text;

            await channel.SendAsync(judge);
            JObject response = await channel.ReceiveResponse();
            ShowMessage(response.Value<string>("message"), "Registration result");
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

            loginType = "Judge";
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

            checkCounterFunction(sender, e);
            loginType = "Admin";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
