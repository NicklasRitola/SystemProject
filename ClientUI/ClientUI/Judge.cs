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
    public partial class Judge : ClientHandler
    {
        public Judge(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }

        private void label_Click(object sender, EventArgs e)
        {
                    }

        private void Judge_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void ButtonSetScore_Click(object sender, EventArgs e)
        {
            JudgePointRequest request = new JudgePointRequest(currentID, float.Parse(textBoxSetScore.Text),LoginGlobalString.SSN, int.Parse(textBoxComp.Text));
            await channel.SendAsync(request);

            JObject response = await channel.ReceiveResponse();
            MessageBox.Show(response.Value<string>("message"), "Registration result", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public int currentID;


        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            ViewCurrentDiverRequest request = new ViewCurrentDiverRequest(int.Parse(textBoxComp.Text));
            await channel.SendAsync(request);

            JObject response = await channel.ReceiveResponse();
            if (response.Value<string>("messageType").ToLower() == "currentdiverresponse")
            {
                string JSONString = JsonConvert.SerializeObject(response);
                CurrentDiverResponse CurrentResponse = JsonConvert.DeserializeObject<CurrentDiverResponse>(JSONString);

                labelSetCurrentDiver.Text = CurrentResponse.CurrentID.ToString();
                currentID = CurrentResponse.CurrentID;
                labelSetCurrentDiff.Text = CurrentResponse.Difficulty.ToString();

                labelSetCurrentGroup.Text = CurrentResponse.DiveGroup;

                labelSetCurrentTower.Text = CurrentResponse.Tower.ToString();
            }
            else
            {
                ShowMessage("Update current diver result", response.Value<string>("message"));
            }
        }
    }
}
