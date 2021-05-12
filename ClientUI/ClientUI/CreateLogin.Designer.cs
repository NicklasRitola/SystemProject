
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
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(91, 35);
            this.buttonMainMenu.TabIndex = 43;
            this.buttonMainMenu.Text = "Admin Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(318, 49);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(274, 23);
            this.textBoxUsername.TabIndex = 40;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(380, 142);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(62, 19);
            this.checkBoxAdmin.TabIndex = 39;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(210, 142);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(31, 15);
            this.Gender.TabIndex = 37;
            this.Gender.Text = "Type";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(317, 78);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(274, 23);
            this.textBoxPassword.TabIndex = 36;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(210, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 15);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Password";
            // 
            // RegisterProfile
            // 
            this.RegisterProfile.Location = new System.Drawing.Point(31, 90);
            this.RegisterProfile.Name = "RegisterProfile";
            this.RegisterProfile.Size = new System.Drawing.Size(136, 54);
            this.RegisterProfile.TabIndex = 30;
            this.RegisterProfile.Text = "Register";
            this.RegisterProfile.UseVisualStyleBackColor = true;
            this.RegisterProfile.Click += new System.EventHandler(this.RegisterProfile_Click);
            // 
            // checkBoxJudge
            // 
            this.checkBoxJudge.AutoSize = true;
            this.checkBoxJudge.Location = new System.Drawing.Point(317, 142);
            this.checkBoxJudge.Name = "checkBoxJudge";
            this.checkBoxJudge.Size = new System.Drawing.Size(57, 19);
            this.checkBoxJudge.TabIndex = 44;
            this.checkBoxJudge.Text = "Judge";
            this.checkBoxJudge.UseVisualStyleBackColor = true;
            this.checkBoxJudge.CheckedChanged += new System.EventHandler(this.checkBoxJudge_CheckedChanged);
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Location = new System.Drawing.Point(317, 107);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(274, 23);
            this.textBoxConfirm.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Confirm Password";
            // 
            // CreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 192);
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
            this.Name = "CreateLogin";
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
    }
}