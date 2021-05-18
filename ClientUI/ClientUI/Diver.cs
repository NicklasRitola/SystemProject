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
    public partial class Diver : ClientHandler
    {
        public Diver(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Diver_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void RegisterDive_Click(object sender, EventArgs e)
        {
            RegisterDiveRequest request = new RegisterDiveRequest();
            request.Dive_ID = int.Parse(textBoxID.Text);
            request.Difficulty = int.Parse(textBoxDifficulty.Text);
            request.In_Competition = int.Parse(textBoxComp.Text);
            request.Tower = int.Parse(textBoxTower.Text);
            request.DiveGroup = textBoxDiveGrp.Text;
            request.Diver = LoginGlobalString.SSN;
            request.Score = null;

            await channel.SendAsync(request);
            JObject response = await channel.ReceiveResponse();
            MessageBox.Show(response.Value<string>("message"), "Registration result", MessageBoxButtons.OK);

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }
    }
}
