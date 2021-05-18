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
        public Spectator(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }

        private async void Refresh_Click(object sender, EventArgs e)
        {
            ViewScheduleRequest request = new ViewScheduleRequest();
            request.ID = int.Parse(textBoxEnterID.Text);

            await channel.SendAsync(request);
            JObject response = await channel.ReceiveResponse();
            MessageBox.Show(response.Value<string>("message"), "Registration result", MessageBoxButtons.OK);
            string JSONString = JsonConvert.SerializeObject(response);
            ScheduleResponse responseSchedule = JsonConvert.DeserializeObject<ScheduleResponse>(JSONString);

            foreach(var diver in responseSchedule.ScheduleItems)
            {
                int index = viewSchedule.Rows.Add();
                viewSchedule.Rows[index].Cells[0].Value = diver.Current;
                viewSchedule.Rows[index].Cells[1].Value = diver.Person;
                viewSchedule.Rows[index].Cells[2].Value = diver.Diff;
                viewSchedule.Rows[index].Cells[3].Value = diver.DiveGroup;
                viewSchedule.Rows[index].Cells[4].Value = diver.jumpID;
                viewSchedule.Rows[index].Cells[5].Value = diver.Tower;
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
