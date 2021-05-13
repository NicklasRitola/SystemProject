using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class CreateLogin : SuperForm
    {
        public CreateLogin()
        {
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator();
            OpenForm(adminForm, this);
        }
        private int checkCounter;
        private string loginType;


        private void RegisterProfile_Click(object sender, EventArgs e)
        {


            string chosenUsername = textBoxUsername.Text;
            string chosenPassword = textBoxPassword.Text;
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

        private void checkBoxJudge_CheckedChanged(object sender, EventArgs e)
        {

            checkCounterFunction(sender, e);

            loginType = "Judge";
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

            checkCounterFunction(sender, e);
            loginType = "Admin";
        }
    }
}
