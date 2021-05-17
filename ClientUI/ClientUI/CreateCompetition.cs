using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            string compLocation = textBoxLocation.Text;
            string compDate = textBoxDate.Text;
            string compName = textBoxName.Text;
            string compID = textBoxID.Text;
            int NumberOfJudge = int.Parse(textBoxNumberOfJudge.Text);
        
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
