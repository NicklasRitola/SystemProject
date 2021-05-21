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
    public partial class Schedule : ClientHandler
    {
        private int Competition_ID;
        public Schedule(ClientChannel channel, int Competition_ID)
        {
            InitializeComponent();
            this.channel = channel;
            this.Competition_ID = Competition_ID;
            this.label2.Text = "Of Competition " + Competition_ID;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            updateSchedule();
        }

        private async void updateSchedule()
        {
            ScheduleRequest request = new ScheduleRequest(this.Competition_ID);
            await channel.SendAsync(request);

            JObject response = await channel.ReceiveResponse();
            string JSONString = JsonConvert.SerializeObject(response);
            ScheduleResponse responseSchedule = JsonConvert.DeserializeObject<ScheduleResponse>(JSONString);
            if(responseSchedule == null)
            {
                MessageBox.Show("Couldn't load schedule for competition " + this.Competition_ID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                viewSchedule.Rows.Clear();
                foreach (var diver in responseSchedule.Schedule)
                {
                    int index = viewSchedule.Rows.Add();
                    if(index == 0) { viewSchedule.Rows[index].DefaultCellStyle.Font = new Font("Segoe", 9, FontStyle.Bold); } //Makes current diver bold
                    viewSchedule.Rows[index].Selected = false;
                    viewSchedule.Rows[index].Cells[0].Value = diver.Time;
                    viewSchedule.Rows[index].Cells[1].Value = diver.DiverName;
                    viewSchedule.Rows[index].Cells[2].Value = diver.Difficulty;
                    viewSchedule.Rows[index].Cells[3].Value = diver.Group;
                    viewSchedule.Rows[index].Cells[4].Value = diver.Tower;
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
            updateSchedule();
        }
    }
}
