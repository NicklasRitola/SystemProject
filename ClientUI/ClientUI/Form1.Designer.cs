
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
            this.Spectator = new System.Windows.Forms.Button();
            this.Judge = new System.Windows.Forms.Button();
            this.CreateDiver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.Location = new System.Drawing.Point(384, 243);
            this.Administrator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(155, 72);
            this.Administrator.TabIndex = 1;
            this.Administrator.Text = "Administrator";
            this.Administrator.UseVisualStyleBackColor = true;
            this.Administrator.Click += new System.EventHandler(this.Administrator_Click);
            // 
            // Diver
            // 
            this.Diver.Location = new System.Drawing.Point(545, 243);
            this.Diver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Diver.Name = "Diver";
            this.Diver.Size = new System.Drawing.Size(155, 72);
            this.Diver.TabIndex = 2;
            this.Diver.Text = "Diver";
            this.Diver.UseVisualStyleBackColor = true;
            this.Diver.Click += new System.EventHandler(this.Diver_Click);
            // 
            // Spectator
            // 
            this.Spectator.Location = new System.Drawing.Point(62, 243);
            this.Spectator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Spectator.Name = "Spectator";
            this.Spectator.Size = new System.Drawing.Size(155, 72);
            this.Spectator.TabIndex = 5;
            this.Spectator.Text = "Spectator";
            this.Spectator.UseVisualStyleBackColor = true;
            this.Spectator.Click += new System.EventHandler(this.Spectator_Click);
            // 
            // Judge
            // 
            this.Judge.Location = new System.Drawing.Point(223, 243);
            this.Judge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Judge.Name = "Judge";
            this.Judge.Size = new System.Drawing.Size(155, 72);
            this.Judge.TabIndex = 6;
            this.Judge.Text = "Judge";
            this.Judge.UseVisualStyleBackColor = true;
            this.Judge.Click += new System.EventHandler(this.Judge_Click);
            // 
            // CreateDiver
            // 
            this.CreateDiver.Location = new System.Drawing.Point(707, 243);
            this.CreateDiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateDiver.Name = "CreateDiver";
            this.CreateDiver.Size = new System.Drawing.Size(155, 72);
            this.CreateDiver.TabIndex = 7;
            this.CreateDiver.Text = "Create a diver profile";
            this.CreateDiver.UseVisualStyleBackColor = true;
            this.CreateDiver.Click += new System.EventHandler(this.CreateDiver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.CreateDiver);
            this.Controls.Add(this.Judge);
            this.Controls.Add(this.Spectator);
            this.Controls.Add(this.Diver);
            this.Controls.Add(this.Administrator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming competition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Administrator;
        private System.Windows.Forms.Button Diver;
        private System.Windows.Forms.Button Spectator;
        private System.Windows.Forms.Button Judge;
        private System.Windows.Forms.Button CreateDiver;
    }
}

