﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Diver : Form
    {
        public Diver()
        {
            InitializeComponent();
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
    }
}
