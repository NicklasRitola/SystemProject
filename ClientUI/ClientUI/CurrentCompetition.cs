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
                NextDiverRequest nextDiverRequest = new NextDiverRequest(Int32.Parse(textBoxCompID.Text));
                await channel.SendAsync(nextDiverRequest);
                JObject response = await channel.ReceiveResponse();
                ShowMessage(response.Value<string>("message"), "Diver update request");
            }
        }
    }
}