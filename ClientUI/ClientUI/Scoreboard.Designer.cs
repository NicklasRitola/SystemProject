
namespace ClientUI
{
    partial class Scoreboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewSchedule = new System.Windows.Forms.DataGridView();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(148, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "Of Competition X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(136, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 54);
            this.label3.TabIndex = 48;
            this.label3.Text = "Scoreboard";
            // 
            // viewSchedule
            // 
            this.viewSchedule.AllowUserToAddRows = false;
            this.viewSchedule.AllowUserToDeleteRows = false;
            this.viewSchedule.AllowUserToResizeColumns = false;
            this.viewSchedule.AllowUserToResizeRows = false;
            this.viewSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.viewSchedule.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.viewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.Score});
            this.viewSchedule.Location = new System.Drawing.Point(71, 119);
            this.viewSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewSchedule.MultiSelect = false;
            this.viewSchedule.Name = "viewSchedule";
            this.viewSchedule.ReadOnly = true;
            this.viewSchedule.RowHeadersWidth = 51;
            this.viewSchedule.RowTemplate.Height = 25;
            this.viewSchedule.Size = new System.Drawing.Size(358, 383);
            this.viewSchedule.TabIndex = 46;
            // 
            // Person
            // 
            this.Person.HeaderText = "Person";
            this.Person.MinimumWidth = 6;
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            this.Person.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Person.Width = 180;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 125;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(331, 528);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(98, 52);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh Scoreboard";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 13);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(93, 52);
            this.buttonMainMenu.TabIndex = 1;
            this.buttonMainMenu.Text = "Spectator panel";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(503, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewSchedule);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.buttonMainMenu);
            this.Name = "Scoreboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            ((System.ComponentModel.ISupportInitialize)(this.viewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView viewSchedule;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}