﻿using System;
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
    }
}
