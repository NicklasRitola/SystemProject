
namespace ClientUI
{
    partial class CreateLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.Gender = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.RegisterProfile = new System.Windows.Forms.Button();
            this.checkBoxJudge = new System.Windows.Forms.CheckBox();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.textboxSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(14, 16);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(104, 47);
            this.buttonMainMenu.TabIndex = 43;
            this.buttonMainMenu.Text = "Admin Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Social Security Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(363, 65);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "123456-0000";
            this.textBoxUsername.Size = new System.Drawing.Size(313, 27);
            this.textBoxUsername.TabIndex = 40;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(434, 189);
            this.checkBoxAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(75, 24);
            this.checkBoxAdmin.TabIndex = 39;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(240, 189);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(40, 20);
            this.Gender.TabIndex = 37;
            this.Gender.Text = "Type";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(362, 104);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(313, 27);
            this.textBoxPassword.TabIndex = 36;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(240, 108);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 20);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Password";
            // 
            // RegisterProfile
            // 
            this.RegisterProfile.Location = new System.Drawing.Point(35, 120);
            this.RegisterProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterProfile.Name = "RegisterProfile";
            this.RegisterProfile.Size = new System.Drawing.Size(155, 72);
            this.RegisterProfile.TabIndex = 30;
            this.RegisterProfile.Text = "Register";
            this.RegisterProfile.UseVisualStyleBackColor = true;
            this.RegisterProfile.Click += new System.EventHandler(this.RegisterProfile_Click);
            // 
            // checkBoxJudge
            // 
            this.checkBoxJudge.AutoSize = true;
            this.checkBoxJudge.Location = new System.Drawing.Point(362, 189);
            this.checkBoxJudge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxJudge.Name = "checkBoxJudge";
            this.checkBoxJudge.Size = new System.Drawing.Size(70, 24);
            this.checkBoxJudge.TabIndex = 44;
            this.checkBoxJudge.Text = "Judge";
            this.checkBoxJudge.UseVisualStyleBackColor = true;
            this.checkBoxJudge.CheckedChanged += new System.EventHandler(this.checkBoxJudge_CheckedChanged);
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Location = new System.Drawing.Point(362, 143);
            this.textBoxConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.PasswordChar = '*';
            this.textBoxConfirm.Size = new System.Drawing.Size(313, 27);
            this.textBoxConfirm.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Name";
            // 
            // textboxFirstName
            // 
            this.textboxFirstName.Location = new System.Drawing.Point(363, 29);
            this.textboxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxFirstName.Name = "textboxFirstName";
            this.textboxFirstName.PlaceholderText = "First name";
            this.textboxFirstName.Size = new System.Drawing.Size(146, 27);
            this.textboxFirstName.TabIndex = 48;
            // 
            // textboxSurname
            // 
            this.textboxSurname.Location = new System.Drawing.Point(515, 30);
            this.textboxSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxSurname.Name = "textboxSurname";
            this.textboxSurname.PlaceholderText = "Surname";
            this.textboxSurname.Size = new System.Drawing.Size(160, 27);
            this.textboxSurname.TabIndex = 49;
            // 
            // CreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 256);
            this.Controls.Add(this.textboxSurname);
            this.Controls.Add(this.textboxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxJudge);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.RegisterProfile);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button RegisterProfile;
        private System.Windows.Forms.CheckBox checkBoxJudge;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxFirstName;
        private System.Windows.Forms.TextBox textboxSurname;
    }
}