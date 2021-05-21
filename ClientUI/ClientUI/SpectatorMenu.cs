using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class SpectatorMenu : ClientHandler
    {
        public SpectatorMenu(ClientChannel channel, int Competition_ID)
        {
            InitializeComponent();
            this.channel = channel;
            if(Competition_ID != 0)
            {
                this.textBoxCompetitionID.Text = Competition_ID.ToString();
            }
        }

        private void buttonViewSchedule_Click(object sender, EventArgs e)
        {
            
            if (this.textBoxCompetitionID.Text == "")
            {
                MessageBox.Show("Competition ID field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(int.TryParse(textBoxCompetitionID.Text, out _)))
            {
                MessageBox.Show("Competition ID must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Schedule scheduleForm = new Schedule(channel, int.Parse(textBoxCompetitionID.Text));
                OpenForm(scheduleForm, this);
            }
        }

        private void buttonViewScoreboard_Click(object sender, EventArgs e)
        {
            if (this.textBoxCompetitionID.Text == "")
            {
                MessageBox.Show("Competition ID field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(int.TryParse(textBoxCompetitionID.Text, out _)))
            {
                MessageBox.Show("Competition ID must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Scoreboard scoreboardForm = new Scoreboard(channel, int.Parse(textBoxCompetitionID.Text));
                OpenForm(scoreboardForm, this);
            }
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 mainMenuForm = new Form1(channel);
            OpenForm(mainMenuForm, this);
        }
    }
}
