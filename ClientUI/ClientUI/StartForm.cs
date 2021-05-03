using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void Administrator_Click(object sender, EventArgs e)
        {

        }

        private void Diver_Click(object sender, EventArgs e)
        {

        }

        private void Coach_Click(object sender, EventArgs e)
        {

        }

        private void Spectator_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpectatorForm specForm = new SpectatorForm();
            specForm.Show();
        }
    }
}
