using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class SpectatorForm : Form
    {
        public SpectatorForm()
        {
            InitializeComponent();
        }

        private void SpectatorForm_Load(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }
    }
}
