using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Judge : SuperForm
    {
        public Judge()
        {
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            OpenForm(form1Form, this);
        }

        private void label_Click(object sender, EventArgs e)
        {
                    }

        private void Judge_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSetScore_Click(object sender, EventArgs e)
        {
            float JudgeScore = float.Parse(textBoxSetScore.Text); // poängen som skrivs in.
            //måste lägga in funktion som skickar iväg poäng till servern

        }
        public void UpdateCurrentDiver(string CurrentDiver,string Currentdifficulty,string CurrentGroup, string CurrentTower) // uppdaterar informationen om hoppet och diver
        {
            labelSetCurrentDiff.Text = Currentdifficulty;
            labelSetCurrentDiver.Text = CurrentDiver;
            labelSetCurrentGroup.Text = CurrentGroup;
            labelSetCurrentTower.Text = CurrentTower;
        }
    }
}
