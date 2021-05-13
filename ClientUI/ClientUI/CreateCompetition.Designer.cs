
namespace ClientUI
{
    partial class CreateCompetition
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSur = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.RegisterProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminMenu
            // 
            this.AdminMenu.Location = new System.Drawing.Point(12, 12);
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(86, 35);
            this.AdminMenu.TabIndex = 31;
            this.AdminMenu.Text = "Admin Menu";
            this.AdminMenu.UseVisualStyleBackColor = true;
            this.AdminMenu.Click += new System.EventHandler(this.AdminMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Location:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(305, 40);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(274, 23);
            this.textBoxLocation.TabIndex = 42;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxTeam_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(305, 69);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(274, 23);
            this.textBoxDate.TabIndex = 38;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxFirst_TextChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(197, 130);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(21, 15);
            this.labelAge.TabIndex = 37;
            this.labelAge.Text = "ID:";
            this.labelAge.Click += new System.EventHandler(this.labelAge_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(305, 127);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(274, 23);
            this.textBoxID.TabIndex = 36;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(197, 72);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 15);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Date:";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelSur
            // 
            this.labelSur.AutoSize = true;
            this.labelSur.Location = new System.Drawing.Point(197, 101);
            this.labelSur.Name = "labelSur";
            this.labelSur.Size = new System.Drawing.Size(42, 15);
            this.labelSur.TabIndex = 34;
            this.labelSur.Text = "Name:";
            this.labelSur.Click += new System.EventHandler(this.labelSur_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(305, 98);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(274, 23);
            this.textBoxName.TabIndex = 33;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxSur_TextChanged);
            // 
            // RegisterProfile
            // 
            this.RegisterProfile.Location = new System.Drawing.Point(18, 81);
            this.RegisterProfile.Name = "RegisterProfile";
            this.RegisterProfile.Size = new System.Drawing.Size(136, 54);
            this.RegisterProfile.TabIndex = 32;
            this.RegisterProfile.Text = "Register";
            this.RegisterProfile.UseVisualStyleBackColor = true;
            this.RegisterProfile.Click += new System.EventHandler(this.RegisterProfile_Click);
            // 
            // CreateCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSur);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.RegisterProfile);
            this.Controls.Add(this.AdminMenu);
            this.Name = "CreateCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateCompetition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSur;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button RegisterProfile;
    }
}