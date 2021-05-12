
namespace ClientUI
{
    partial class CreateSchedule
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
            this.buttonChoseComp = new System.Windows.Forms.Button();
            this.textBoxChoseCompID = new System.Windows.Forms.TextBox();
            this.textBoxDiverID = new System.Windows.Forms.TextBox();
            this.textBoxDiveID = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // buttonChoseComp
            // 
            this.buttonChoseComp.Location = new System.Drawing.Point(129, 12);
            this.buttonChoseComp.Name = "buttonChoseComp";
            this.buttonChoseComp.Size = new System.Drawing.Size(88, 46);
            this.buttonChoseComp.TabIndex = 33;
            this.buttonChoseComp.Text = "Chose Competiton";
            this.buttonChoseComp.UseVisualStyleBackColor = true;
            this.buttonChoseComp.Click += new System.EventHandler(this.buttonChoseComp_Click);
            // 
            // textBoxChoseCompID
            // 
            this.textBoxChoseCompID.Location = new System.Drawing.Point(317, 24);
            this.textBoxChoseCompID.Name = "textBoxChoseCompID";
            this.textBoxChoseCompID.Size = new System.Drawing.Size(100, 23);
            this.textBoxChoseCompID.TabIndex = 34;
            // 
            // textBoxDiverID
            // 
            this.textBoxDiverID.Location = new System.Drawing.Point(317, 104);
            this.textBoxDiverID.Name = "textBoxDiverID";
            this.textBoxDiverID.Size = new System.Drawing.Size(100, 23);
            this.textBoxDiverID.TabIndex = 35;
            // 
            // textBoxDiveID
            // 
            this.textBoxDiveID.Location = new System.Drawing.Point(317, 133);
            this.textBoxDiveID.Name = "textBoxDiveID";
            this.textBoxDiveID.Size = new System.Drawing.Size(100, 23);
            this.textBoxDiveID.TabIndex = 36;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(129, 104);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(88, 46);
            this.buttonInsert.TabIndex = 37;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Chose ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Diver ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dive ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Insert ID in the wished order of the competition";
            // 
            // CreateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 181);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxDiveID);
            this.Controls.Add(this.textBoxDiverID);
            this.Controls.Add(this.textBoxChoseCompID);
            this.Controls.Add(this.buttonChoseComp);
            this.Controls.Add(this.AdminMenu);
            this.Name = "CreateSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminMenu;
        private System.Windows.Forms.Button buttonChoseComp;
        private System.Windows.Forms.TextBox textBoxChoseCompID;
        private System.Windows.Forms.TextBox textBoxDiverID;
        private System.Windows.Forms.TextBox textBoxDiveID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}