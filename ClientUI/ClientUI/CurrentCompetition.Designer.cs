
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
            this.textBoxNextDiver = new System.Windows.Forms.TextBox();
            this.buttonDeleteCompetition = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminMenu
            // 
            this.AdminMenu.Location = new System.Drawing.Point(14, 16);
            this.AdminMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(98, 47);
            this.AdminMenu.TabIndex = 3;
            this.AdminMenu.Text = "Admin Menu";
            this.AdminMenu.UseVisualStyleBackColor = true;
            this.AdminMenu.Click += new System.EventHandler(this.AdminMenu_Click);
            // 
            // ButtonSelectComp
            // 
            this.ButtonSelectComp.Enabled = false;
            this.ButtonSelectComp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSelectComp.Location = new System.Drawing.Point(-115, 458);
            this.ButtonSelectComp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSelectComp.Name = "ButtonSelectComp";
            this.ButtonSelectComp.Size = new System.Drawing.Size(155, 72);
            this.ButtonSelectComp.TabIndex = 1;
            this.ButtonSelectComp.Text = "Select Competition";
            this.ButtonSelectComp.UseVisualStyleBackColor = true;
            this.ButtonSelectComp.Click += new System.EventHandler(this.ButtonSelectComp_Click);
            // 
            // buttonNextDive
            // 
            this.buttonNextDive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNextDive.Location = new System.Drawing.Point(150, 118);
            this.buttonNextDive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNextDive.Name = "buttonNextDive";
            this.buttonNextDive.Size = new System.Drawing.Size(155, 72);
            this.buttonNextDive.TabIndex = 2;
            this.buttonNextDive.Text = "Next Diver";
            this.buttonNextDive.UseVisualStyleBackColor = true;
            this.buttonNextDive.Click += new System.EventHandler(this.buttonNextDive_Click);
            // 
            // textBoxCompID
            // 
            this.textBoxCompID.Location = new System.Drawing.Point(351, 40);
            this.textBoxCompID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCompID.Name = "textBoxCompID";
            this.textBoxCompID.Size = new System.Drawing.Size(153, 27);
            this.textBoxCompID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Competition ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(334, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Current Diver:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(351, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Next Diver:";
            // 
            // labelCurrentDiver
            // 
            this.labelCurrentDiver.AutoSize = true;
            this.labelCurrentDiver.Location = new System.Drawing.Point(426, 118);
            this.labelCurrentDiver.Name = "labelCurrentDiver";
            this.labelCurrentDiver.Size = new System.Drawing.Size(0, 20);
            this.labelCurrentDiver.TabIndex = 43;
            // 
            // labelNextDiver
            // 
            this.labelNextDiver.AutoSize = true;
            this.labelNextDiver.Location = new System.Drawing.Point(426, 170);
            this.labelNextDiver.Name = "labelNextDiver";
            this.labelNextDiver.Size = new System.Drawing.Size(0, 20);
            this.labelNextDiver.TabIndex = 44;
            // 
            // textBoxCurrentDiver
            // 
            this.textBoxCurrentDiver.Location = new System.Drawing.Point(446, 112);
            this.textBoxCurrentDiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCurrentDiver.Name = "textBoxCurrentDiver";
            this.textBoxCurrentDiver.ReadOnly = true;
            this.textBoxCurrentDiver.Size = new System.Drawing.Size(153, 27);
            this.textBoxCurrentDiver.TabIndex = 45;
            // 
            // textBoxNextDiver
            // 
            this.textBoxNextDiver.Location = new System.Drawing.Point(446, 170);
            this.textBoxNextDiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNextDiver.Name = "textBoxNextDiver";
            this.textBoxNextDiver.ReadOnly = true;
            this.textBoxNextDiver.Size = new System.Drawing.Size(153, 27);
            this.textBoxNextDiver.TabIndex = 46;
            // 
            // buttonDeleteCompetition
            // 
            this.buttonDeleteCompetition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteCompetition.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteCompetition.Location = new System.Drawing.Point(295, 252);
            this.buttonDeleteCompetition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteCompetition.Name = "buttonDeleteCompetition";
            this.buttonDeleteCompetition.Size = new System.Drawing.Size(155, 72);
            this.buttonDeleteCompetition.TabIndex = 47;
            this.buttonDeleteCompetition.Text = "Delete Competition";
            this.buttonDeleteCompetition.UseVisualStyleBackColor = true;
            this.buttonDeleteCompetition.Click += new System.EventHandler(this.buttonDeleteCompetition_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(125, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 150);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // CurrentCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(712, 351);
            this.Controls.Add(this.textBoxCompID);
            this.Controls.Add(this.textBoxNextDiver);
            this.Controls.Add(this.textBoxCurrentDiver);
            this.Controls.Add(this.buttonDeleteCompetition);
            this.Controls.Add(this.labelNextDiver);
            this.Controls.Add(this.labelCurrentDiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSelectComp);
            this.Controls.Add(this.buttonNextDive);
            this.Controls.Add(this.AdminMenu);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CurrentCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competition Maintainer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxNextDiver;
        private System.Windows.Forms.Button buttonDeleteCompetition;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}