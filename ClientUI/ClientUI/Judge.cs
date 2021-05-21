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
        public int Current_Dive_ID;
        public Judge(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            List<string> NoEmptyFields = new List<String>();
            if (textBoxComp.Text == "")
            {
                NoEmptyFields.Add("Competition ID field is empty");
            }
            else if (!(int.TryParse(textBoxComp.Text, out _)))
            {
                NoEmptyFields.Add("Competition ID must be an integer");
            }
            if(textBoxSetScore.Text == "")
            {
                NoEmptyFields.Add("Score field is empty");
            }
            else if(!(float.TryParse(textBoxSetScore.Text, out _)))
            {
                NoEmptyFields.Add("Score must be an float");
            }
            
            if(NoEmptyFields.Count == 0)
            {
                JudgePointRequest request = new JudgePointRequest(Current_Dive_ID, float.Parse(textBoxSetScore.Text), LoginGlobalString.SSN, int.Parse(textBoxComp.Text));
                await channel.SendAsync(request);

                JObject response = await channel.ReceiveResponse();
                MessageBox.Show(response.Value<string>("message"), "Registration result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateTextBoxes();
            }
            else
            {
                string output = "";
                for (int i = 0; i < NoEmptyFields.Count; i++)
                {
                    output += ("• " + NoEmptyFields[i] + "\n");
                }
                MessageBox.Show("Invalid input: \n" + output, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NoEmptyFields.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (textBoxComp.Text == "")
            {
                MessageBox.Show("Competition ID field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(int.TryParse(textBoxComp.Text, out _)))
            {
                MessageBox.Show("Competition ID must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateTextBoxes();
            }
        }

        private async void UpdateTextBoxes()
        {
            ScheduleRequest request = new ScheduleRequest(int.Parse(textBoxComp.Text));
            await channel.SendAsync(request);

            JObject response = await channel.ReceiveResponse();
            string JSONString = JsonConvert.SerializeObject(response);
            ScheduleResponse responseSchedule = JsonConvert.DeserializeObject<ScheduleResponse>(JSONString);
            if (responseSchedule == null)
            {
                MessageBox.Show("Couldn't load schedule for competition " + int.Parse(textBoxComp.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.textBoxCurrentDiver.Text = responseSchedule.Schedule[0].DiverName;
                this.textBoxDifficulty.Text = responseSchedule.Schedule[0].Difficulty.ToString();
                this.textBoxDiveGroup.Text = responseSchedule.Schedule[0].Group;
                this.textBoxTower.Text = responseSchedule.Schedule[0].Tower.ToString();
                this.Current_Dive_ID = responseSchedule.Schedule[0].DiveId;
            }

        }
    }
}
