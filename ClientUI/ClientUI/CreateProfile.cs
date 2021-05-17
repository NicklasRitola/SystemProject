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
    public partial class CreateProfile : ClientHandler
    {
        public CreateProfile()
        {
            InitializeComponent();
        }

        private void labelDifficulty_Click(object sender, EventArgs e)
        {

        }
        private int checkCounter;
        private string checkGender;
        private void label1_Click(object sender, EventArgs e)
        {

        }
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

            string diverFirst = textBoxFirst.Text;
            string diverSur = textBoxSur.Text;
            string diverAge = textBoxAge.Text;
            string diverTeam = textBoxTeam.Text;
            string chosenUsername = textBoxUsername.Text;
            string chosenPassword = textBoxPassword.Text;

            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Enter a Username");
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Enter a Password");
            }
            if (textBoxConfirm.Text != textBoxPassword.Text)
            {
                MessageBox.Show("Password does not match!");
            }


        }

        private void textBoxDifficulty_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            OpenForm(form1Form, this);

        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
            checkGender = "Male";
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkCounterFunction(sender, e);
            checkGender = "Female";
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
