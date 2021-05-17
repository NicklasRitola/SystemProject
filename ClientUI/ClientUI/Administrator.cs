using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClientSide;

namespace ClientUI
{
    public partial class Administrator : ClientHandler
    {
        public Administrator(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }

        private void CreateSchedule_Click(object sender, EventArgs e)
        {
            CreateSchedule scheduleForm = new CreateSchedule(channel);
            OpenForm(scheduleForm, this);

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
    }
}
