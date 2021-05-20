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
        }

        private void buttonRegisterDive_Click(object sender, EventArgs e)
        {
            Diver diverForm = new Diver(channel, "diver");
            OpenForm(diverForm, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spectator specForm = new Spectator(channel);
            OpenForm(specForm, this);
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Diver diverForm = new Diver(channel, "admin");
            OpenForm(diverForm, this);
        }
    }
}
