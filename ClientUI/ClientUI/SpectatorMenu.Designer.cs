
namespace ClientUI
{
    partial class SpectatorMenu
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
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonViewScoreboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCompetitionID = new System.Windows.Forms.TextBox();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonViewSchedule.Location = new System.Drawing.Point(219, 187);
            this.buttonViewSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(155, 72);
            this.buttonViewSchedule.TabIndex = 1;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            this.buttonViewSchedule.Click += new System.EventHandler(this.buttonViewSchedule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(143, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 41);
            this.label3.TabIndex = 33;
            this.label3.Text = "Spectator";
            // 
            // buttonViewScoreboard
            // 
            this.buttonViewScoreboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonViewScoreboard.Location = new System.Drawing.Point(42, 187);
            this.buttonViewScoreboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewScoreboard.Name = "buttonViewScoreboard";
            this.buttonViewScoreboard.Size = new System.Drawing.Size(155, 72);
            this.buttonViewScoreboard.TabIndex = 0;
            this.buttonViewScoreboard.Text = "View Scoreboard";
            this.buttonViewScoreboard.UseVisualStyleBackColor = true;
            this.buttonViewScoreboard.Click += new System.EventHandler(this.buttonViewScoreboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Competition:";
            // 
            // textBoxCompetitionID
            // 
            this.textBoxCompetitionID.Location = new System.Drawing.Point(211, 128);
            this.textBoxCompetitionID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCompetitionID.Name = "textBoxCompetitionID";
            this.textBoxCompetitionID.PlaceholderText = "ID";
            this.textBoxCompetitionID.Size = new System.Drawing.Size(129, 27);
            this.textBoxCompetitionID.TabIndex = 2;
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 13);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(87, 47);
            this.buttonMainMenu.TabIndex = 39;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // SpectatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(424, 342);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCompetitionID);
            this.Controls.Add(this.buttonViewScoreboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonViewSchedule);
            this.Name = "SpectatorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpectatorMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonViewScoreboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCompetitionID;
        private System.Windows.Forms.Button buttonMainMenu;
    }
}