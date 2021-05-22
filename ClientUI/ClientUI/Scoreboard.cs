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
    public partial class Scoreboard : ClientHandler
    {
        private int Competition_ID;
        public Scoreboard(ClientChannel channel, int Competition_ID)
        {
            InitializeComponent();
            this.channel = channel;
            this.Competition_ID = Competition_ID;
            this.label2.Text = "Of Competition " + Competition_ID;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            viewSchedule.Columns[0].Width = 180;
            viewSchedule.Columns[1].Width = 80;
            updateScoreboard();
        }

        private async void updateScoreboard()
        {
            ScoreboardRequest request = new ScoreboardRequest(this.Competition_ID);
            await channel.SendAsync(request);

            JObject response = await channel.ReceiveResponse();
            string JSONString = JsonConvert.SerializeObject(response);
            ScoreboardResponse responseScoreboard = JsonConvert.DeserializeObject<ScoreboardResponse>(JSONString);
            if (responseScoreboard == null)
            {
                MessageBox.Show("Couldn't load scoreboard for competition " + this.Competition_ID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                viewSchedule.Rows.Clear();
                foreach (var diver in responseScoreboard.Scoreboard)
                {
                    int index = viewSchedule.Rows.Add();
                    viewSchedule.Rows[index].Selected = false;
                    viewSchedule.Rows[index].Cells[0].Value = diver.DiverName;
                    viewSchedule.Rows[index].Cells[1].Value = diver.Score;
                }
            }
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            SpectatorMenu specMenuForm = new SpectatorMenu(channel, Competition_ID);
            OpenForm(specMenuForm, this);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            updateScoreboard();
        }
    }
}
