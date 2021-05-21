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


    public partial class Form1 : ClientHandler
    {
        public Form1(ClientChannel channel)
        {
            InitializeComponent();
            buttonRegisterDiver.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.channel = channel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        


        private void Administrator_Click(object sender, EventArgs e)
        {
            LoginGlobalString.GlobalString = "Admin";

            Login loginForm = new Login(channel);
            OpenForm(loginForm, this);

        }


        private void Diver_Click(object sender, EventArgs e)
        {
            LoginGlobalString.GlobalString = "Diver";

            Login loginForm = new Login(channel);
            OpenForm(loginForm, this);

        }


        private void Spectator_Click(object sender, EventArgs e)
        {
            //Spectator specForm = new Spectator(channel);
            //OpenForm(specForm, this);

            SpectatorMenu specMenuForm = new SpectatorMenu(channel, 0);
            OpenForm(specMenuForm, this);
        }

        private void Judge_Click(object sender, EventArgs e)
        {
            LoginGlobalString.GlobalString = "Judge";
            Login loginForm = new Login(channel);
            OpenForm(loginForm, this);
        }

        private void CreateDiver_Click(object sender, EventArgs e)
        {

            CreateProfile createForm = new CreateProfile(channel);
            OpenForm(createForm, this);

        }

        private void buttonRegisterDiver_Click(object sender, EventArgs e)
        {
            CreateProfile createForm = new CreateProfile(channel);
            OpenForm(createForm, this);

        }
    }
}
