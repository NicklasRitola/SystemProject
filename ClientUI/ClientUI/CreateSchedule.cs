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
        //public int counter = 0;
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
            if(textBoxChoseCompID.Text == "")
            {
                MessageBox.Show("Invalid input: \n• Competition ID - Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(int.TryParse(textBoxChoseCompID.Text, out _)))
            {
                MessageBox.Show("Invalid input: \n• Competition ID - Not an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateScheduleRequest request = new CreateScheduleRequest();
                request.CompetitionID = int.Parse(textBoxChoseCompID.Text);

                await channel.SendAsync(request);
                JObject response = await channel.ReceiveResponse();
                MessageBox.Show(response.Value<string>("message"), "Registration result");

                Administrator adminForm = new Administrator(channel);
                OpenForm(adminForm, this);
            }
            
            //request.DiveID = int.Parse(textBoxDiveID.Text);
            //request.DiverID = int.Parse(textBoxDiverID.Text);
            
            //request.count = counter;
            //counter++;
        }
    }
}
