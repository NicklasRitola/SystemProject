
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
            this.CreateSchedule = new System.Windows.Forms.Button();
            this.nextDive = new System.Windows.Forms.Button();
            this.buttonCreateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(76, 35);
            this.buttonMainMenu.TabIndex = 30;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // CreateCompetition
            // 
            this.CreateCompetition.Location = new System.Drawing.Point(157, 65);
            this.CreateCompetition.Name = "CreateCompetition";
            this.CreateCompetition.Size = new System.Drawing.Size(136, 54);
            this.CreateCompetition.TabIndex = 35;
            this.CreateCompetition.Text = "Create Competition";
            this.CreateCompetition.UseVisualStyleBackColor = true;
            this.CreateCompetition.Click += new System.EventHandler(this.CreateCompetition_Click);
            // 
            // CreateSchedule
            // 
            this.CreateSchedule.Location = new System.Drawing.Point(16, 65);
            this.CreateSchedule.Name = "CreateSchedule";
            this.CreateSchedule.Size = new System.Drawing.Size(136, 54);
            this.CreateSchedule.TabIndex = 34;
            this.CreateSchedule.Text = "Create Schedule";
            this.CreateSchedule.UseVisualStyleBackColor = true;
            this.CreateSchedule.Click += new System.EventHandler(this.CreateSchedule_Click);
            // 
            // nextDive
            // 
            this.nextDive.Location = new System.Drawing.Point(298, 65);
            this.nextDive.Name = "nextDive";
            this.nextDive.Size = new System.Drawing.Size(136, 54);
            this.nextDive.TabIndex = 31;
            this.nextDive.Text = "Start a Competition";
            this.nextDive.UseVisualStyleBackColor = true;
            this.nextDive.Click += new System.EventHandler(this.NextDive_Click);
            // 
            // buttonCreateProfile
            // 
            this.buttonCreateProfile.Location = new System.Drawing.Point(440, 65);
            this.buttonCreateProfile.Name = "buttonCreateProfile";
            this.buttonCreateProfile.Size = new System.Drawing.Size(136, 54);
            this.buttonCreateProfile.TabIndex = 36;
            this.buttonCreateProfile.Text = "Create a profile";
            this.buttonCreateProfile.UseVisualStyleBackColor = true;
            this.buttonCreateProfile.Click += new System.EventHandler(this.buttonCreateProfile_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 172);
            this.Controls.Add(this.buttonCreateProfile);
            this.Controls.Add(this.CreateCompetition);
            this.Controls.Add(this.CreateSchedule);
            this.Controls.Add(this.nextDive);
            this.Controls.Add(this.buttonMainMenu);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button CreateCompetition;
        private System.Windows.Forms.Button CreateSchedule;
        private System.Windows.Forms.Button nextDive;
        private System.Windows.Forms.Button buttonCreateProfile;
    }
}