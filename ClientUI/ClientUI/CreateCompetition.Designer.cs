
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
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxGlobal = new System.Windows.Forms.CheckBox();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminMenu
            // 
            this.AdminMenu.Location = new System.Drawing.Point(14, 16);
            this.AdminMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(98, 49);
            this.AdminMenu.TabIndex = 7;
            this.AdminMenu.Text = "Admin Menu";
            this.AdminMenu.UseVisualStyleBackColor = true;
            this.AdminMenu.Click += new System.EventHandler(this.AdminMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Location:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(349, 53);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(313, 27);
            this.textBoxLocation.TabIndex = 0;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxTeam_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(349, 92);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.PlaceholderText = "YYYY-MM-DD HH:MM:SS";
            this.textBoxDate.Size = new System.Drawing.Size(313, 27);
            this.textBoxDate.TabIndex = 1;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxFirst_TextChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(225, 173);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(27, 20);
            this.labelAge.TabIndex = 37;
            this.labelAge.Text = "ID:";
            this.labelAge.Click += new System.EventHandler(this.labelAge_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(349, 169);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(313, 27);
            this.textBoxID.TabIndex = 3;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(225, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 20);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Start Date:";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // RegisterProfile
            // 
            this.RegisterProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterProfile.Location = new System.Drawing.Point(21, 108);
            this.RegisterProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterProfile.Name = "RegisterProfile";
            this.RegisterProfile.Size = new System.Drawing.Size(155, 72);
            this.RegisterProfile.TabIndex = 6;
            this.RegisterProfile.Text = "Register";
            this.RegisterProfile.UseVisualStyleBackColor = true;
            this.RegisterProfile.Click += new System.EventHandler(this.RegisterProfile_Click);
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(349, 131);
            this.textBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.PlaceholderText = "YYYY-MM-DD HH:MM:SS";
            this.textBoxEndDate.Size = new System.Drawing.Size(313, 27);
            this.textBoxEndDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "End Date:";
            // 
            // checkBoxGlobal
            // 
            this.checkBoxGlobal.AutoSize = true;
            this.checkBoxGlobal.Location = new System.Drawing.Point(349, 209);
            this.checkBoxGlobal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxGlobal.Name = "checkBoxGlobal";
            this.checkBoxGlobal.Size = new System.Drawing.Size(75, 24);
            this.checkBoxGlobal.TabIndex = 4;
            this.checkBoxGlobal.Text = "Global";
            this.checkBoxGlobal.UseVisualStyleBackColor = true;
            this.checkBoxGlobal.CheckedChanged += new System.EventHandler(this.checkBoxGlobal_CheckedChanged);
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(451, 208);
            this.checkBoxLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(66, 24);
            this.checkBoxLocal.TabIndex = 5;
            this.checkBoxLocal.Text = "Local";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            this.checkBoxLocal.CheckedChanged += new System.EventHandler(this.checkBoxLocal_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Type:";
            // 
            // CreateCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(721, 301);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxLocal);
            this.Controls.Add(this.checkBoxGlobal);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.RegisterProfile);
            this.Controls.Add(this.AdminMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxGlobal;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.Label label4;
    }
}