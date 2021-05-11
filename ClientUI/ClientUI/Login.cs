using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void LoginButton_Click(object sender, EventArgs e)
        {
             //Fixa så den kollar lösen + namn med databas (så att det existerar).
            Administrator adminForm = new Administrator();
            
            adminForm.Show();
            
            this.Hide();
            
        }
    }
}
