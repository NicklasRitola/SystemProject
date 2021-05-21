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
    public partial class CreateTeam : ClientHandler
    {
        public CreateTeam(ClientChannel channel)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.channel = channel;
        }

        private async void RegisterProfile_Click(object sender, EventArgs e)
        {
            List<string> NoEmptyFields = new List<String>();
            if (textBoxTeamID.Text == "") { NoEmptyFields.Add("Team ID - Empty field"); }
            else if (!(int.TryParse(textBoxTeamID.Text, out _))) { NoEmptyFields.Add("Team ID - Not an integer"); }
            if (textBoxName.Text == "") { NoEmptyFields.Add("Name - Empty field"); }

            if(NoEmptyFields.Count == 0)
            {
                RegisterTeamRequest team = new RegisterTeamRequest();
                team.Team_ID = Int32.Parse(textBoxTeamID.Text);
                team.Name = textBoxName.Text;

                await channel.SendAsync(team);
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

        private void AdminMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator(channel);
            OpenForm(adminForm, this);
        }
    }
}
