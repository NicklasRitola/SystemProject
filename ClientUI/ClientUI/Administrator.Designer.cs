
namespace ClientUI
{
    partial class Administrator
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
            this.CreateCompetition = new System.Windows.Forms.Button();
            this.nextDive = new System.Windows.Forms.Button();
            this.buttonCreateProfile = new System.Windows.Forms.Button();
            this.buttonCreateTeam = new System.Windows.Forms.Button();
            this.buttonRegisterDive = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(14, 16);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(87, 51);
            this.buttonMainMenu.TabIndex = 7;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // CreateCompetition
            // 
            this.CreateCompetition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCompetition.Location = new System.Drawing.Point(126, 93);
            this.CreateCompetition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateCompetition.Name = "CreateCompetition";
            this.CreateCompetition.Size = new System.Drawing.Size(155, 72);
            this.CreateCompetition.TabIndex = 2;
            this.CreateCompetition.Text = "Create Competition";
            this.CreateCompetition.UseVisualStyleBackColor = true;
            this.CreateCompetition.Click += new System.EventHandler(this.CreateCompetition_Click);
            // 
            // nextDive
            // 
            this.nextDive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextDive.Location = new System.Drawing.Point(288, 93);
            this.nextDive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextDive.Name = "nextDive";
            this.nextDive.Size = new System.Drawing.Size(155, 72);
            this.nextDive.TabIndex = 3;
            this.nextDive.Text = "Manage Competition";
            this.nextDive.UseVisualStyleBackColor = true;
            this.nextDive.Click += new System.EventHandler(this.NextDive_Click);
            // 
            // buttonCreateProfile
            // 
            this.buttonCreateProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateProfile.Location = new System.Drawing.Point(45, 173);
            this.buttonCreateProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateProfile.Name = "buttonCreateProfile";
            this.buttonCreateProfile.Size = new System.Drawing.Size(155, 72);
            this.buttonCreateProfile.TabIndex = 4;
            this.buttonCreateProfile.Text = "Create a profile";
            this.buttonCreateProfile.UseVisualStyleBackColor = true;
            this.buttonCreateProfile.Click += new System.EventHandler(this.buttonCreateProfile_Click);
            // 
            // buttonCreateTeam
            // 
            this.buttonCreateTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateTeam.Location = new System.Drawing.Point(206, 173);
            this.buttonCreateTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateTeam.Name = "buttonCreateTeam";
            this.buttonCreateTeam.Size = new System.Drawing.Size(155, 72);
            this.buttonCreateTeam.TabIndex = 5;
            this.buttonCreateTeam.Text = "Create a team";
            this.buttonCreateTeam.UseVisualStyleBackColor = true;
            this.buttonCreateTeam.Click += new System.EventHandler(this.buttonCreateTeam_Click);
            // 
            // buttonRegisterDive
            // 
            this.buttonRegisterDive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisterDive.Location = new System.Drawing.Point(368, 173);
            this.buttonRegisterDive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRegisterDive.Name = "buttonRegisterDive";
            this.buttonRegisterDive.Size = new System.Drawing.Size(155, 72);
            this.buttonRegisterDive.TabIndex = 6;
            this.buttonRegisterDive.Text = "Register dive";
            this.buttonRegisterDive.UseVisualStyleBackColor = true;
            this.buttonRegisterDive.Click += new System.EventHandler(this.buttonRegisterDive_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(189, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 41);
            this.label3.TabIndex = 32;
            this.label3.Text = "Admin panel";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(559, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRegisterDive);
            this.Controls.Add(this.buttonCreateTeam);
            this.Controls.Add(this.buttonCreateProfile);
            this.Controls.Add(this.CreateCompetition);
            this.Controls.Add(this.nextDive);
            this.Controls.Add(this.buttonMainMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button CreateCompetition;
        private System.Windows.Forms.Button nextDive;
        private System.Windows.Forms.Button buttonCreateProfile;
        private System.Windows.Forms.Button buttonCreateTeam;
        private System.Windows.Forms.Button buttonRegisterDive;
        private System.Windows.Forms.Label label3;
    }
}