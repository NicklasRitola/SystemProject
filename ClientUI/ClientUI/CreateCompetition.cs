using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Shared;
using ClientSide;

namespace ClientUI
{
    public partial class CreateCompetition : ClientHandler
    {
        public CreateCompetition()
        {
            InitializeComponent();
        }

        private void AdminMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator();
            OpenForm(adminForm, this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTeam_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void textBoxFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAge_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelSur_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSur_TextChanged(object sender, EventArgs e)
        {

        }
        private int checkCounter;
        private int checkType;
        private void checkCounterFunction(object sender, EventArgs e)
        {// Increase or decrease the check counter
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                checkCounter++;
            else
                checkCounter--;
            // prevent checking
            if (checkCounter == 2)
            {
                MessageBox.Show("Chose one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Checked = false;
            }
        }

        private void RegisterProfile_Click(object sender, EventArgs e)
        {

            CreateCompetitionRequest request = new CreateCompetitionRequest();
            request.Location = textBoxLocation.Text;
            request.Start_Date = textBoxDate.Text;
            request.End_Date = textBoxEndDate.Text;
            //request.Name = textBoxName.Text;
            request.ID = Int32.Parse(textBoxID.Text);

            request.Type = checkType; //Local comp       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxGlobal_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
            checkType = 2;
        }

        private void checkBoxLocal_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
            checkType = 1;
        }
    }
}
