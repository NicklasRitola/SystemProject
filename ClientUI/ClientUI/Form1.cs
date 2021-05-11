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


    public partial class Form1 : SuperForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        


        private void Administrator_Click(object sender, EventArgs e)
        {
            LoginGlobalString.GlobalString = "Admin";

            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();


        }


        private void Diver_Click(object sender, EventArgs e)
        {
            LoginGlobalString.GlobalString = "Diver";
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
            /*
             
            this.Hide();
            Diver diveForm = new Diver();
            diveForm.Show();*/


        }

        private void Coach_Click(object sender, EventArgs e)
        {
            LoginGlobalString.GlobalString = "Coach";
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void Spectator_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            SpectatorForm specForm = new SpectatorForm();
            specForm.Show();*/

            Form1 startForm = new Form1();
            OpenForm(startForm, this);
        }

        private void Judge_Click(object sender, EventArgs e)
        {
            LoginGlobalString.GlobalString = "Judge";
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void CreateDiver_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateProfile createForm = new CreateProfile();
            createForm.Show();

        }
    }
}
