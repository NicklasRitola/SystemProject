
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
            this.RegisterProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxGlobal = new System.Windows.Forms.CheckBox();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.labelName.Size = new System.Drawing.Size(61, 15);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Start Date:";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Write date as \"YYYY-MM-DD TT:TT:TT\"";
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(305, 98);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(274, 23);
            this.textBoxEndDate.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "End Date:";
            // 
            // checkBoxGlobal
            // 
            this.checkBoxGlobal.AutoSize = true;
            this.checkBoxGlobal.Location = new System.Drawing.Point(305, 157);
            this.checkBoxGlobal.Name = "checkBoxGlobal";
            this.checkBoxGlobal.Size = new System.Drawing.Size(60, 19);
            this.checkBoxGlobal.TabIndex = 47;
            this.checkBoxGlobal.Text = "Global";
            this.checkBoxGlobal.UseVisualStyleBackColor = true;
            this.checkBoxGlobal.CheckedChanged += new System.EventHandler(this.checkBoxGlobal_CheckedChanged);
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(395, 156);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(54, 19);
            this.checkBoxLocal.TabIndex = 48;
            this.checkBoxLocal.Text = "Local";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            this.checkBoxLocal.CheckedChanged += new System.EventHandler(this.checkBoxLocal_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Type:";
            // 
            // CreateCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxLocal);
            this.Controls.Add(this.checkBoxGlobal);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelName);
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
        private System.Windows.Forms.Button RegisterProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxGlobal;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.Label label4;
    }
}