using System;
using System.Collections.Generic;
using System.Text;

namespace ClientUI
{
    public class SuperForm : System.Windows.Forms.Form
    {
        public SuperForm()
        {

        }

        public void OpenForm(SuperForm NewForm, SuperForm CurrentForm)
        {
            NewForm.Height = CurrentForm.Height;
            NewForm.Width = CurrentForm.Width;
            NewForm.Location = CurrentForm.Location;
            CurrentForm.Hide();
            NewForm.Show();
        }

        public void HideButton()
        {

        }
    }
}
