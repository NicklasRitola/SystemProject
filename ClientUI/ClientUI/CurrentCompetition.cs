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
    public partial class CurrentCompetition : ClientHandler
    {
        public CurrentCompetition(ClientChannel channel)
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void AdminMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator(channel);
            OpenForm(adminForm, this);
        }

        private void ButtonSelectComp_Click(object sender, EventArgs e)
        {
            int compID = int.Parse(textBoxCompID.Text); // Input för ID
        }

        private async void buttonNextDive_Click(object sender, EventArgs e)
        {
            labelCurrentDiver.Text = "";
            labelNextDiver.Text = ""; // fyller i detta när vi har funktioner från serversidan
            if (textBoxCompID.Text != "")
            {
                this.textBoxCurrentDiver.Text = "";
                this.textBoxNextDiver.Text = "";

                NextDiverRequest nextDiverRequest = new NextDiverRequest(Int32.Parse(textBoxCompID.Text));
                await channel.SendAsync(nextDiverRequest);
                JObject response = await channel.ReceiveResponse();
                ShowMessage(response.Value<string>("message"), "Diver update request");

                //TODO: Update textbox current and next diver after responds.

            }
            
        }

        private void buttonDeleteCompetition_Click(object sender, EventArgs e)
        {
            if(textBoxCompID.Text == "")
            {
                MessageBox.Show("No competition ID entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(int.TryParse(textBoxCompID.Text, out _)))
            {
                MessageBox.Show("Competition ID must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DeleteCompetition deleteForm = new DeleteCompetition(channel, int.Parse(textBoxCompID.Text));
                deleteForm.Show();

                this.textBoxCurrentDiver.Text = "";
                this.textBoxNextDiver.Text = "";
                this.textBoxCompID.Text = "";
            }
        }
    }
}