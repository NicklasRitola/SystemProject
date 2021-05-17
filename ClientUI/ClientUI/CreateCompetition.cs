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
    public partial class CreateCompetition : SuperForm
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

        private void RegisterProfile_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxNumberOfJudge.Text)==3 || int.Parse(textBoxNumberOfJudge.Text) == 7) 
            {
                CreateCompetitionRequest request = new CreateCompetitionRequest();
                request.Location = textBoxLocation.Text;
                request.Start_Date = textBoxDate.Text; //
                //request.Name = textBoxName.Text;
                request.ID = Int32.Parse(textBoxID.Text);
                if ()
                {
                    request.Type = 1; //Local comp
                }
                else
                {
                    request.Type = 2; //Global comp
                }

        
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
