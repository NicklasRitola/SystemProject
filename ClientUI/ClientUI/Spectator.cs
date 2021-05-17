using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Spectator : ClientHandler
    {
        public Spectator(ClientChannel channel) 
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1(channel);
            OpenForm(form1Form, this);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            int index = viewSchedule.Rows.Add();
            viewSchedule.Rows[index].Cells[0].Value = "Adrian Steneryd";
            viewSchedule.Rows[index].Cells[1].Value = 1.1;
            viewSchedule.Rows[index].Cells[2].Value = 2;
            viewSchedule.Rows[index].Cells[3].Value = "Superflip";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
