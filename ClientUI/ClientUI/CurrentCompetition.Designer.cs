
namespace ClientUI
{
    partial class CurrentCompetition
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
            this.AdminMenu = new System.Windows.Forms.Button();
            this.ButtonSelectComp = new System.Windows.Forms.Button();
            this.buttonNextDive = new System.Windows.Forms.Button();
            this.textBoxCompID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCurrentDiver = new System.Windows.Forms.Label();
            this.labelNextDiver = new System.Windows.Forms.Label();
            this.textBoxCurrentDiver = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AdminMenu
            // 
            this.AdminMenu.Location = new System.Drawing.Point(14, 16);
            this.AdminMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(98, 47);
            this.AdminMenu.TabIndex = 32;
            this.AdminMenu.Text = "Admin Menu";
            this.AdminMenu.UseVisualStyleBackColor = true;
            this.AdminMenu.Click += new System.EventHandler(this.AdminMenu_Click);
            // 
            // ButtonSelectComp
            // 
            this.ButtonSelectComp.Location = new System.Drawing.Point(123, 84);
            this.ButtonSelectComp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSelectComp.Name = "ButtonSelectComp";
            this.ButtonSelectComp.Size = new System.Drawing.Size(155, 72);
            this.ButtonSelectComp.TabIndex = 38;
            this.ButtonSelectComp.Text = "Select Competition";
            this.ButtonSelectComp.UseVisualStyleBackColor = true;
            this.ButtonSelectComp.Click += new System.EventHandler(this.ButtonSelectComp_Click);
            // 
            // buttonNextDive
            // 
            this.buttonNextDive.Location = new System.Drawing.Point(123, 196);
            this.buttonNextDive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNextDive.Name = "buttonNextDive";
            this.buttonNextDive.Size = new System.Drawing.Size(155, 72);
            this.buttonNextDive.TabIndex = 37;
            this.buttonNextDive.Text = "Next Diver";
            this.buttonNextDive.UseVisualStyleBackColor = true;
            this.buttonNextDive.Click += new System.EventHandler(this.buttonNextDive_Click);
            // 
            // textBoxCompID
            // 
            this.textBoxCompID.Location = new System.Drawing.Point(455, 108);
            this.textBoxCompID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCompID.Name = "textBoxCompID";
            this.textBoxCompID.Size = new System.Drawing.Size(114, 27);
            this.textBoxCompID.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(340, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Competition ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Current Diver:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Next Diver:";
            // 
            // labelCurrentDiver
            // 
            this.labelCurrentDiver.AutoSize = true;
            this.labelCurrentDiver.Location = new System.Drawing.Point(446, 199);
            this.labelCurrentDiver.Name = "labelCurrentDiver";
            this.labelCurrentDiver.Size = new System.Drawing.Size(0, 20);
            this.labelCurrentDiver.TabIndex = 43;
            // 
            // labelNextDiver
            // 
            this.labelNextDiver.AutoSize = true;
            this.labelNextDiver.Location = new System.Drawing.Point(446, 251);
            this.labelNextDiver.Name = "labelNextDiver";
            this.labelNextDiver.Size = new System.Drawing.Size(0, 20);
            this.labelNextDiver.TabIndex = 44;
            // 
            // textBoxCurrentDiver
            // 
            this.textBoxCurrentDiver.Enabled = false;
            this.textBoxCurrentDiver.Location = new System.Drawing.Point(455, 196);
            this.textBoxCurrentDiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCurrentDiver.Name = "textBoxCurrentDiver";
            this.textBoxCurrentDiver.ReadOnly = true;
            this.textBoxCurrentDiver.Size = new System.Drawing.Size(114, 27);
            this.textBoxCurrentDiver.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(455, 251);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(114, 27);
            this.textBox1.TabIndex = 46;
            // 
            // CurrentCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 332);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxCurrentDiver);
            this.Controls.Add(this.labelNextDiver);
            this.Controls.Add(this.labelCurrentDiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCompID);
            this.Controls.Add(this.ButtonSelectComp);
            this.Controls.Add(this.buttonNextDive);
            this.Controls.Add(this.AdminMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CurrentCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrentCompetition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminMenu;
        private System.Windows.Forms.Button ButtonSelectComp;
        private System.Windows.Forms.Button buttonNextDive;
        private System.Windows.Forms.TextBox textBoxCompID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCurrentDiver;
        private System.Windows.Forms.Label labelNextDiver;
        private System.Windows.Forms.TextBox textBoxCurrentDiver;
        private System.Windows.Forms.TextBox textBox1;
    }
}