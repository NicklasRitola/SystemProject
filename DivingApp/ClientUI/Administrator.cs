using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Administrator : SuperForm
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            OpenForm(form1Form, this);
        }

        private void CreateSchedule_Click(object sender, EventArgs e)
        {
            CreateSchedule scheduleForm = new CreateSchedule();
            OpenForm(scheduleForm, this);

        }

        private void CreateCompetition_Click(object sender, EventArgs e)
        {
            CreateCompetition compForm = new CreateCompetition();
            OpenForm(compForm, this);

        }

        private void NextDive_Click(object sender, EventArgs e)
        {
            CurrentCompetition currentCompForm = new CurrentCompetition();
            OpenForm(currentCompForm, this);

        }

        private void buttonCreateProfile_Click(object sender, EventArgs e)
        {
            CreateLogin createLoginForm = new CreateLogin();
            OpenForm(createLoginForm, this);
        }
    }
}
