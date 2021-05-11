using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class CreateProfile : SuperForm
    {
        public CreateProfile()
        {
            InitializeComponent();
        }

        private void labelDifficulty_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterProfile_Click(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked = true && checkBoxFemale.Checked == true )
            {

                MessageBox.Show("Select one gender","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if(checkBoxMale.Checked = true && checkBoxFemale.Checked == false)
            {
                string diverGender = "Male";
            }
            if (checkBoxMale.Checked = false && checkBoxFemale.Checked == true)
            {
                string diverGender = "Female";
            }
            string diverFirst = textBoxFirst.Text;
            string diverSur = textBoxSur.Text;
            string diverAge = textBoxAge.Text;
            string diverTeam = textBoxTeam.Text;


        }

        private void textBoxDifficulty_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            OpenForm(form1Form, this);

        }
    }
}
