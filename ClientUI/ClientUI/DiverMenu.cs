using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class DiverMenu : ClientHandler
    {
        public DiverMenu(ClientChannel channel)
        {
            InitializeComponent();
            this.channel = channel;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonRegisterDive_Click(object sender, EventArgs e)
        {
            Diver diverForm = new Diver(channel, "diver");
            OpenForm(diverForm, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpectatorMenu specMenuForm = new SpectatorMenu(channel, 0);
            OpenForm(specMenuForm, this);
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 mainMenuForm = new Form1(channel);
            OpenForm(mainMenuForm, this);
        }
    }
}
