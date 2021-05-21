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
    public partial class CurrentCompetition : ClientHandler
    {
        public CurrentCompetition(ClientChannel channel)
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

        private void ButtonSelectComp_Click(object sender, EventArgs e)
        {
            int compID = int.Parse(textBoxCompID.Text); // Input för ID
        }

        private async void buttonNextDive_Click(object sender, EventArgs e)
        {
            if (textBoxCompID.Text == "")
            {
                MessageBox.Show("No competition ID entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(int.TryParse(textBoxCompID.Text, out _)))
            {
                MessageBox.Show("Competition ID must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.textBoxCurrentDiver.Text = "";
                this.textBoxNextDiver.Text = "";

                NextDiverRequest nextDiverRequest = new NextDiverRequest(int.Parse(textBoxCompID.Text));
                await channel.SendAsync(nextDiverRequest);
                JObject response = await channel.ReceiveResponse();
                ShowMessage(response.Value<string>("message"), "Next diver request");

                updateCurrentAndNextDiver(int.Parse(textBoxCompID.Text));

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

        private void textBoxCurrentDiver_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                updateCurrentAndNextDiver(int.Parse(textBoxCompID.Text));
            }
            
        }

        private async void updateCurrentAndNextDiver(int Competition_ID)
        {
            ScheduleRequest request = new ScheduleRequest(Competition_ID);
            await channel.SendAsync(request);

            JObject response = await channel.ReceiveResponse();
            string JSONString = JsonConvert.SerializeObject(response);
            ScheduleResponse responseSchedule = JsonConvert.DeserializeObject<ScheduleResponse>(JSONString);
            if (responseSchedule == null)
            {
                MessageBox.Show("Couldn't load current diver and next diver \nfor competition " + Competition_ID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(responseSchedule.Schedule.Count >= 2)
                {
                    textBoxCurrentDiver.Text = responseSchedule.Schedule[0].DiverName;
                    textBoxNextDiver.Text = responseSchedule.Schedule[1].DiverName;
                }
                else if(responseSchedule.Schedule.Count == 1)
                {
                    textBoxCurrentDiver.Text = responseSchedule.Schedule[0].DiverName;
                    textBoxNextDiver.Text = "X";
                }
                else
                {
                    textBoxCurrentDiver.Text = "X";
                    textBoxNextDiver.Text = "X";
                    MessageBox.Show("No current diver and next diver found \nfor competition " + Competition_ID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}