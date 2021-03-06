using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Shared;

namespace ClientUI
{
    public partial class Administrator : ClientHandler
    {
        public Administrator(ClientChannel channel) 
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.channel = channel;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }

        private void CreateCompetition_Click(object sender, EventArgs e)
        {
            CreateCompetition compForm = new CreateCompetition(channel);
            OpenForm(compForm, this);

        }

        private void NextDive_Click(object sender, EventArgs e)
        {
            CurrentCompetition currentCompForm = new CurrentCompetition(channel);
            OpenForm(currentCompForm, this);
        }

        private void buttonCreateProfile_Click(object sender, EventArgs e)
        {
            CreateLogin createLoginForm = new CreateLogin(channel);
            OpenForm(createLoginForm, this);
        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            CreateTeam createTeamForm = new CreateTeam(channel);
            OpenForm(createTeamForm, this);
        }

        private void buttonRegisterDive_Click(object sender, EventArgs e)
        {
            Diver diverForm = new Diver(channel, "admin");
            OpenForm(diverForm, this);
        }
    }
}
