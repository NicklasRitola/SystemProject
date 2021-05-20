
namespace ClientUI
{
    partial class Spectator
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
            this.Refresh = new System.Windows.Forms.Button();
            this.viewSchedule = new System.Windows.Forms.DataGridView();
            this.textBoxEnterID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Divegroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(76, 35);
            this.buttonMainMenu.TabIndex = 2;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(720, 399);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(68, 39);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // viewSchedule
            // 
            this.viewSchedule.AllowUserToAddRows = false;
            this.viewSchedule.AllowUserToDeleteRows = false;
            this.viewSchedule.AllowUserToResizeColumns = false;
            this.viewSchedule.AllowUserToResizeRows = false;
            this.viewSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.viewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Current,
            this.Person,
            this.Difficulty,
            this.Divegroup,
            this.Tower,
            this.Score});
            this.viewSchedule.Location = new System.Drawing.Point(71, 68);
            this.viewSchedule.Name = "viewSchedule";
            this.viewSchedule.ReadOnly = true;
            this.viewSchedule.RowHeadersWidth = 51;
            this.viewSchedule.RowTemplate.Height = 25;
            this.viewSchedule.Size = new System.Drawing.Size(643, 287);
            this.viewSchedule.TabIndex = 32;
            this.viewSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxEnterID
            // 
            this.textBoxEnterID.Location = new System.Drawing.Point(614, 408);
            this.textBoxEnterID.Name = "textBoxEnterID";
            this.textBoxEnterID.Size = new System.Drawing.Size(100, 23);
            this.textBoxEnterID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Enter Competition ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(317, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 45);
            this.label3.TabIndex = 35;
            this.label3.Text = "Schedule";
            // 
            // Current
            // 
            this.Current.HeaderText = "Current";
            this.Current.MinimumWidth = 6;
            this.Current.Name = "Current";
            this.Current.ReadOnly = true;
            this.Current.Width = 125;
            // 
            // Person
            // 
            this.Person.HeaderText = "Person";
            this.Person.MinimumWidth = 6;
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            this.Person.Width = 125;
            // 
            // Difficulty
            // 
            this.Difficulty.HeaderText = "Difficulty";
            this.Difficulty.MinimumWidth = 6;
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            this.Difficulty.Width = 125;
            // 
            // Divegroup
            // 
            this.Divegroup.HeaderText = "Divegroup";
            this.Divegroup.MinimumWidth = 6;
            this.Divegroup.Name = "Divegroup";
            this.Divegroup.ReadOnly = true;
            this.Divegroup.Width = 125;
            // 
            // Tower
            // 
            this.Tower.HeaderText = "Tower";
            this.Tower.MinimumWidth = 6;
            this.Tower.Name = "Tower";
            this.Tower.ReadOnly = true;
            this.Tower.Width = 125;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Spectator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnterID);
            this.Controls.Add(this.viewSchedule);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.buttonMainMenu);
            this.Name = "Spectator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spectator";
            ((System.ComponentModel.ISupportInitialize)(this.viewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainMenu;
        private new System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView viewSchedule;
        private System.Windows.Forms.TextBox textBoxEnterID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Divegroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tower;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}