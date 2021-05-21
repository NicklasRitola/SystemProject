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
        private string fromForm;
        public Diver(ClientChannel channel, string fromForm) 
        {
            InitializeComponent();
            this.channel = channel;
            this.fromForm = fromForm;
            if(fromForm == "admin")
            {
                this.buttonMainMenu.Text = "Admin Menu";
            }
            else if (fromForm == "diver")
            {
                this.buttonMainMenu.Text = "Diver Menu";
                this.textBoxDiverID.Text = LoginGlobalString.SSN;
            }
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
            List<string> NoEmptyFields = new List<String>();
            if (textBoxID.Text == "") { NoEmptyFields.Add("Dive ID - Empty field"); }
            else if (!(int.TryParse(textBoxID.Text, out _))) { NoEmptyFields.Add("Dive ID - Not an integer"); }
            if (textBoxComp.Text == "") { NoEmptyFields.Add("Competition ID - Empty field"); }
            else if (!(int.TryParse(textBoxComp.Text, out _))) { NoEmptyFields.Add("Competition ID - Not an integer"); }
            if (textBoxDiveGrp.Text == "") { NoEmptyFields.Add("Dive Group - Empty field"); }
            if (textBoxDifficulty.Text == "") { NoEmptyFields.Add("Difficulty - Empty field"); }
            else if (!(float.TryParse(textBoxDifficulty.Text, out _))) { NoEmptyFields.Add("Difficulty - Not a float"); }
            if (textBoxTower.Text == "") { NoEmptyFields.Add("Tower - Empty field"); }
            else if (!(float.TryParse(textBoxTower.Text, out _))) { NoEmptyFields.Add("Tower - Not an integer"); }
            if (textBoxDate.Text == "") { NoEmptyFields.Add("Date - Empty field"); }
            if (fromForm == "admin" && textBoxDiverID.Text == "") { NoEmptyFields.Add("Diver ID - Empty field"); }

            if (NoEmptyFields.Count == 0)
            {
                RegisterDiveRequest request = new RegisterDiveRequest();
                request.Dive_ID = int.Parse(textBoxID.Text);
                request.Difficulty = float.Parse(textBoxDifficulty.Text);
                request.In_Competition = int.Parse(textBoxComp.Text);
                request.Tower = int.Parse(textBoxTower.Text);
                request.DiveGroup = textBoxDiveGrp.Text;
                request.Diver = textBoxDiverID.Text;

                request.Score = null;
                request.Date = textBoxDate.Text;

                await channel.SendAsync(request);
                JObject response = await channel.ReceiveResponse();
                MessageBox.Show(response.Value<string>("message"), "Registration result", MessageBoxButtons.OK);
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

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            if(fromForm == "admin")
            {
                Administrator adminMenuForm = new Administrator(channel);
                OpenForm(adminMenuForm, this);
            }
            else
            {
                DiverMenu diverMenuForm = new DiverMenu(channel);
                OpenForm(diverMenuForm, this);
            }
            
        }
    }
}
