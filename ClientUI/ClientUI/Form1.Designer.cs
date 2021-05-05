
namespace ClientUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Administrator = new System.Windows.Forms.Button();
            this.Diver = new System.Windows.Forms.Button();
            this.Coach = new System.Windows.Forms.Button();
            this.Spectator = new System.Windows.Forms.Button();
            this.Judge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.Location = new System.Drawing.Point(283, 475);
            this.Administrator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(101, 53);
            this.Administrator.TabIndex = 1;
            this.Administrator.Text = "Administrator";
            this.Administrator.UseVisualStyleBackColor = true;
            this.Administrator.Click += new System.EventHandler(this.Administrator_Click);
            // 
            // Diver
            // 
            this.Diver.Location = new System.Drawing.Point(513, 475);
            this.Diver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Diver.Name = "Diver";
            this.Diver.Size = new System.Drawing.Size(101, 53);
            this.Diver.TabIndex = 2;
            this.Diver.Text = "Diver";
            this.Diver.UseVisualStyleBackColor = true;
            this.Diver.Click += new System.EventHandler(this.Diver_Click);
            // 
            // Coach
            // 
            this.Coach.Location = new System.Drawing.Point(734, 475);
            this.Coach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Coach.Name = "Coach";
            this.Coach.Size = new System.Drawing.Size(101, 53);
            this.Coach.TabIndex = 3;
            this.Coach.Text = "Coach";
            this.Coach.UseVisualStyleBackColor = true;
            this.Coach.Click += new System.EventHandler(this.Coach_Click);
            // 
            // Spectator
            // 
            this.Spectator.Location = new System.Drawing.Point(71, 475);
            this.Spectator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Spectator.Name = "Spectator";
            this.Spectator.Size = new System.Drawing.Size(101, 53);
            this.Spectator.TabIndex = 5;
            this.Spectator.Text = "Spectator";
            this.Spectator.UseVisualStyleBackColor = true;
            this.Spectator.Click += new System.EventHandler(this.Spectator_Click);
            // 
            // Judge
            // 
            this.Judge.Location = new System.Drawing.Point(446, 300);
            this.Judge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Judge.Name = "Judge";
            this.Judge.Size = new System.Drawing.Size(101, 53);
            this.Judge.TabIndex = 6;
            this.Judge.Text = "Judge";
            this.Judge.UseVisualStyleBackColor = true;
            this.Judge.Click += new System.EventHandler(this.Judge_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Judge);
            this.Controls.Add(this.Spectator);
            this.Controls.Add(this.Coach);
            this.Controls.Add(this.Diver);
            this.Controls.Add(this.Administrator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartForm";
            this.Text = "Swimming competition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Administrator;
        private System.Windows.Forms.Button Diver;
        private System.Windows.Forms.Button Coach;
        private System.Windows.Forms.Button Spectator;
        private System.Windows.Forms.Button Judge;
    }
}

