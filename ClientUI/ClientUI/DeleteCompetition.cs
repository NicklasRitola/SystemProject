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
    public partial class DeleteCompetition : ClientHandler
    {
        private int CompetitionID;
        public DeleteCompetition(ClientChannel channel, int CompetitionID)
        {
            InitializeComponent();
            this.channel = channel;
            this.CompetitionID = CompetitionID;
            this.label1.Text = "Are you sure you want to delete competition " + CompetitionID + "?";
        }

        private void DeleteCompetition_Load(object sender, EventArgs e)
        {

        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonDeleteCompetition_Click(object sender, EventArgs e)
        {
            DeleteCompetitionRequest deleteReq = new DeleteCompetitionRequest();
            deleteReq.ID = CompetitionID;

            await channel.SendAsync(deleteReq);
            JObject response = await channel.ReceiveResponse();
            ShowMessage(response.Value<string>("message"), "Registration result");

            this.Close();
        }
    }
}
