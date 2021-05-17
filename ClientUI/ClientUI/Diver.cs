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
    public partial class Diver : ClientHandler
    {
        public Diver(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Diver_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterDive_Click(object sender, EventArgs e)
        {
            string diverCopmetition = textBoxComp.Text;
            string diverGroup = textBoxDiveGrp.Text;
            string diverDifficulty = textBoxDifficulty.Text;
            string diverTower = textBoxTower.Text;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }
    }
}
