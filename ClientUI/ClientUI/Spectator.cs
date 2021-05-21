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
    public partial class Spectator : ClientHandler
    {
        private int Competition_ID;
        public Spectator(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
            //this.Competition_ID = Competition_ID;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }

        private async void Refresh_Click(object sender, EventArgs e)
        {
            ViewScheduleRequest request = new ViewScheduleRequest();
            request.Competition_ID = int.Parse(textBoxEnterID.Text);
            await channel.SendAsync(request);

            JObject response = await channel.ReceiveResponse();
            string JSONString = JsonConvert.SerializeObject(response);
            CompetitionScheduleResponse responseSchedule = JsonConvert.DeserializeObject<CompetitionScheduleResponse>(JSONString);

            foreach(var diver in responseSchedule.CompetitionDives)
            {
                int index = viewSchedule.Rows.Add();
                viewSchedule.Rows[index].Cells[0].Value = diver.Current;
                viewSchedule.Rows[index].Cells[1].Value = diver.DiverName;
                viewSchedule.Rows[index].Cells[2].Value = diver.Difficulty;
                viewSchedule.Rows[index].Cells[3].Value = diver.Group;
                viewSchedule.Rows[index].Cells[4].Value = diver.Tower;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
