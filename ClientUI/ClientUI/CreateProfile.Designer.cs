
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
            this.SuspendLayout();
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(210, 168);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 15);
            this.Gender.TabIndex = 23;
            this.Gender.Text = "Gender";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(318, 78);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(274, 23);
            this.textBoxFirst.TabIndex = 22;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(210, 139);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 21;
            this.labelAge.Text = "Age";
            this.labelAge.Click += new System.EventHandler(this.labelDifficulty_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(318, 136);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(274, 23);
            this.textBoxAge.TabIndex = 20;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxDifficulty_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(210, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 15);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "First name";
            // 
            // labelSur
            // 
            this.labelSur.AutoSize = true;
            this.labelSur.Location = new System.Drawing.Point(210, 110);
            this.labelSur.Name = "labelSur";
            this.labelSur.Size = new System.Drawing.Size(54, 15);
            this.labelSur.TabIndex = 18;
            this.labelSur.Text = "Surname";
            // 
            // textBoxSur
            // 
            this.textBoxSur.Location = new System.Drawing.Point(318, 107);
            this.textBoxSur.Name = "textBoxSur";
            this.textBoxSur.Size = new System.Drawing.Size(274, 23);
            this.textBoxSur.TabIndex = 17;
            // 
            // RegisterProfile
            // 
            this.RegisterProfile.Location = new System.Drawing.Point(31, 90);
            this.RegisterProfile.Name = "RegisterProfile";
            this.RegisterProfile.Size = new System.Drawing.Size(136, 54);
            this.RegisterProfile.TabIndex = 15;
            this.RegisterProfile.Text = "Register";
            this.RegisterProfile.UseVisualStyleBackColor = true;
            this.RegisterProfile.Click += new System.EventHandler(this.RegisterProfile_Click);
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(360, 168);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(52, 19);
            this.checkBoxMale.TabIndex = 24;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(475, 168);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(64, 19);
            this.checkBoxFemale.TabIndex = 25;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Location = new System.Drawing.Point(318, 49);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(274, 23);
            this.textBoxTeam.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Team";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErrorMessages
            // 
            this.ErrorMessages.AutoSize = true;
            this.ErrorMessages.Location = new System.Drawing.Point(237, 204);
            this.ErrorMessages.Name = "ErrorMessages";
            this.ErrorMessages.Size = new System.Drawing.Size(0, 15);
            this.ErrorMessages.TabIndex = 28;
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(76, 35);
            this.buttonMainMenu.TabIndex = 29;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 240);
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
    }
}