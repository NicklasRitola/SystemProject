
namespace ClientUI
{
    partial class CreateProfile
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
            this.Gender = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSur = new System.Windows.Forms.Label();
            this.textBoxSur = new System.Windows.Forms.TextBox();
            this.RegisterProfile = new System.Windows.Forms.Button();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMessages = new System.Windows.Forms.Label();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(124, 224);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(60, 20);
            this.Gender.TabIndex = 23;
            this.Gender.Text = "Gender:";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(247, 104);
            this.textBoxFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(313, 27);
            this.textBoxFirst.TabIndex = 22;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(124, 185);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(39, 20);
            this.labelAge.TabIndex = 21;
            this.labelAge.Text = "Age:";
            this.labelAge.Click += new System.EventHandler(this.labelDifficulty_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(247, 181);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(313, 27);
            this.textBoxAge.TabIndex = 20;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxDifficulty_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(124, 108);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 20);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "First name:";
            // 
            // labelSur
            // 
            this.labelSur.AutoSize = true;
            this.labelSur.Location = new System.Drawing.Point(124, 147);
            this.labelSur.Name = "labelSur";
            this.labelSur.Size = new System.Drawing.Size(70, 20);
            this.labelSur.TabIndex = 18;
            this.labelSur.Text = "Surname:";
            // 
            // textBoxSur
            // 
            this.textBoxSur.Location = new System.Drawing.Point(247, 143);
            this.textBoxSur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSur.Name = "textBoxSur";
            this.textBoxSur.Size = new System.Drawing.Size(313, 27);
            this.textBoxSur.TabIndex = 17;
            // 
            // RegisterProfile
            // 
            this.RegisterProfile.Location = new System.Drawing.Point(825, 198);
            this.RegisterProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterProfile.Name = "RegisterProfile";
            this.RegisterProfile.Size = new System.Drawing.Size(155, 72);
            this.RegisterProfile.TabIndex = 15;
            this.RegisterProfile.Text = "Register";
            this.RegisterProfile.UseVisualStyleBackColor = true;
            this.RegisterProfile.Click += new System.EventHandler(this.RegisterProfile_Click);
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(295, 224);
            this.checkBoxMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(64, 24);
            this.checkBoxMale.TabIndex = 24;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(427, 224);
            this.checkBoxFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(79, 24);
            this.checkBoxFemale.TabIndex = 25;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Location = new System.Drawing.Point(247, 65);
            this.textBoxTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(313, 27);
            this.textBoxTeam.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Team ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErrorMessages
            // 
            this.ErrorMessages.AutoSize = true;
            this.ErrorMessages.Location = new System.Drawing.Point(155, 272);
            this.ErrorMessages.Name = "ErrorMessages";
            this.ErrorMessages.Size = new System.Drawing.Size(0, 20);
            this.ErrorMessages.TabIndex = 28;
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(14, 16);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(87, 50);
            this.buttonMainMenu.TabIndex = 29;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Location = new System.Drawing.Point(751, 143);
            this.textBoxConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.PasswordChar = '*';
            this.textBoxConfirm.Size = new System.Drawing.Size(313, 27);
            this.textBoxConfirm.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Social Security Number";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(752, 65);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "123456-0000";
            this.textBoxUsername.Size = new System.Drawing.Size(313, 27);
            this.textBoxUsername.TabIndex = 49;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(751, 104);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(313, 27);
            this.textBoxPassword.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Password";
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 320);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.ErrorMessages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTeam);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSur);
            this.Controls.Add(this.textBoxSur);
            this.Controls.Add(this.RegisterProfile);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSur;
        private System.Windows.Forms.TextBox textBoxSur;
        private System.Windows.Forms.Button RegisterProfile;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.TextBox textBoxTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMessages;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
    }
}