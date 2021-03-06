using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class CurrentCompetition : SuperForm
    {
        public CurrentCompetition()
        {
            InitializeComponent();
        }

        private void AdminMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator();
            OpenForm(adminForm, this);
        }

        private void ButtonSelectComp_Click(object sender, EventArgs e)
        {
            int compID = int.Parse(textBoxCompID.Text); // Input för ID
        }

        private void buttonNextDive_Click(object sender, EventArgs e)
        {
            labelCurrentDiver.Text = "";
            labelNextDiver.Text = ""; // fyller i detta när vi har funktioner från serversidan
        }
    }
}
