using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class CreateSchedule : SuperForm
    {
        public CreateSchedule()
        {
            InitializeComponent();
        }

        private void AdminMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator();
            OpenForm(adminForm, this);
        }

        private void buttonChoseComp_Click(object sender, EventArgs e)
        {
            string chosenCompID = textBoxChoseCompID.Text;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string chosenDiverID = textBoxDiverID.Text;
            string chosenDiveID = textBoxDiveID.Text;
        }
    }
}
