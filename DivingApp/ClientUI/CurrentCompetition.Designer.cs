
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
            this.SuspendLayout();
            // 
            // AdminMenu
            // 
            this.AdminMenu.Location = new System.Drawing.Point(12, 12);
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(86, 35);
            this.AdminMenu.TabIndex = 32;
            this.AdminMenu.Text = "Admin Menu";
            this.AdminMenu.UseVisualStyleBackColor = true;
            this.AdminMenu.Click += new System.EventHandler(this.AdminMenu_Click);
            // 
            // ButtonSelectComp
            // 
            this.ButtonSelectComp.Location = new System.Drawing.Point(131, 63);
            this.ButtonSelectComp.Name = "ButtonSelectComp";
            this.ButtonSelectComp.Size = new System.Drawing.Size(136, 54);
            this.ButtonSelectComp.TabIndex = 38;
            this.ButtonSelectComp.Text = "Select Competition";
            this.ButtonSelectComp.UseVisualStyleBackColor = true;
            this.ButtonSelectComp.Click += new System.EventHandler(this.ButtonSelectComp_Click);
            // 
            // buttonNextDive
            // 
            this.buttonNextDive.Location = new System.Drawing.Point(131, 147);
            this.buttonNextDive.Name = "buttonNextDive";
            this.buttonNextDive.Size = new System.Drawing.Size(136, 54);
            this.buttonNextDive.TabIndex = 37;
            this.buttonNextDive.Text = "Next Diver";
            this.buttonNextDive.UseVisualStyleBackColor = true;
            this.buttonNextDive.Click += new System.EventHandler(this.buttonNextDive_Click);
            // 
            // textBoxCompID
            // 
            this.textBoxCompID.Location = new System.Drawing.Point(377, 79);
            this.textBoxCompID.Name = "textBoxCompID";
            this.textBoxCompID.Size = new System.Drawing.Size(100, 23);
            this.textBoxCompID.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Competition ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Current Diver:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Next Diver:";
            // 
            // labelCurrentDiver
            // 
            this.labelCurrentDiver.AutoSize = true;
            this.labelCurrentDiver.Location = new System.Drawing.Point(369, 147);
            this.labelCurrentDiver.Name = "labelCurrentDiver";
            this.labelCurrentDiver.Size = new System.Drawing.Size(0, 15);
            this.labelCurrentDiver.TabIndex = 43;
            // 
            // labelNextDiver
            // 
            this.labelNextDiver.AutoSize = true;
            this.labelNextDiver.Location = new System.Drawing.Point(369, 186);
            this.labelNextDiver.Name = "labelNextDiver";
            this.labelNextDiver.Size = new System.Drawing.Size(0, 15);
            this.labelNextDiver.TabIndex = 44;
            // 
            // CurrentCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 249);
            this.Controls.Add(this.labelNextDiver);
            this.Controls.Add(this.labelCurrentDiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCompID);
            this.Controls.Add(this.ButtonSelectComp);
            this.Controls.Add(this.buttonNextDive);
            this.Controls.Add(this.AdminMenu);
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
    }
}