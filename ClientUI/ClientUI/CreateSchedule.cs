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
    public partial class CreateSchedule : ClientHandler
    {
        public int counter = 0;
        public CreateSchedule(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void AdminMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator(channel);
            OpenForm(adminForm, this);
        }

        private void buttonChoseComp_Click(object sender, EventArgs e)
        {
            string chosenCompID = textBoxChoseCompID.Text;
        }

        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            CreateScheduleRequest request = new CreateScheduleRequest();
            request.DiveID = int.Parse(textBoxDiveID.Text);
            request.DiverID = int.Parse(textBoxDiverID.Text);
            request.CompetitionID = int.Parse(textBoxChoseCompID.Text);
            request.count = counter;
            counter++;

            await channel.SendAsync(request);
            JObject response = await channel.ReceiveResponse();
            MessageBox.Show(response.Value<string>("message"), "Registration result");
        }
    }
}
