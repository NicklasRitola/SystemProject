
namespace ClientUI
{
    partial class Diver
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
            this.RegisterDive = new System.Windows.Forms.Button();
            this.textBoxTower = new System.Windows.Forms.TextBox();
            this.textBoxDiveGrp = new System.Windows.Forms.TextBox();
            this.labelDive = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.textBoxDifficulty = new System.Windows.Forms.TextBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.textBoxComp = new System.Windows.Forms.TextBox();
            this.labelTower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterDive
            // 
            this.RegisterDive.Location = new System.Drawing.Point(37, 94);
            this.RegisterDive.Name = "RegisterDive";
            this.RegisterDive.Size = new System.Drawing.Size(136, 54);
            this.RegisterDive.TabIndex = 6;
            this.RegisterDive.Text = "Register Dive";
            this.RegisterDive.UseVisualStyleBackColor = true;
            this.RegisterDive.Click += new System.EventHandler(this.RegisterDive_Click);
            // 
            // textBoxTower
            // 
            this.textBoxTower.Location = new System.Drawing.Point(316, 152);
            this.textBoxTower.Name = "textBoxTower";
            this.textBoxTower.Size = new System.Drawing.Size(274, 23);
            this.textBoxTower.TabIndex = 7;
            // 
            // textBoxDiveGrp
            // 
            this.textBoxDiveGrp.Location = new System.Drawing.Point(316, 94);
            this.textBoxDiveGrp.Name = "textBoxDiveGrp";
            this.textBoxDiveGrp.Size = new System.Drawing.Size(274, 23);
            this.textBoxDiveGrp.TabIndex = 8;
            // 
            // labelDive
            // 
            this.labelDive.AutoSize = true;
            this.labelDive.Location = new System.Drawing.Point(208, 97);
            this.labelDive.Name = "labelDive";
            this.labelDive.Size = new System.Drawing.Size(66, 15);
            this.labelDive.TabIndex = 9;
            this.labelDive.Text = "Dive Group";
            this.labelDive.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(208, 68);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(74, 15);
            this.labelComp.TabIndex = 10;
            this.labelComp.Text = "Competition";
            // 
            // textBoxDifficulty
            // 
            this.textBoxDifficulty.Location = new System.Drawing.Point(316, 123);
            this.textBoxDifficulty.Name = "textBoxDifficulty";
            this.textBoxDifficulty.Size = new System.Drawing.Size(274, 23);
            this.textBoxDifficulty.TabIndex = 11;
            this.textBoxDifficulty.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(208, 126);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(55, 15);
            this.labelDifficulty.TabIndex = 12;
            this.labelDifficulty.Text = "Difficulty";
            // 
            // textBoxComp
            // 
            this.textBoxComp.Location = new System.Drawing.Point(316, 65);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(274, 23);
            this.textBoxComp.TabIndex = 13;
            // 
            // labelTower
            // 
            this.labelTower.AutoSize = true;
            this.labelTower.Location = new System.Drawing.Point(208, 155);
            this.labelTower.Name = "labelTower";
            this.labelTower.Size = new System.Drawing.Size(38, 15);
            this.labelTower.TabIndex = 14;
            this.labelTower.Text = "Tower";
            // 
            // Diver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 229);
            this.Controls.Add(this.labelTower);
            this.Controls.Add(this.textBoxComp);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.textBoxDifficulty);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelDive);
            this.Controls.Add(this.textBoxDiveGrp);
            this.Controls.Add(this.textBoxTower);
            this.Controls.Add(this.RegisterDive);
            this.Name = "Diver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diver";
            this.Load += new System.EventHandler(this.Diver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterDive;
        private System.Windows.Forms.TextBox textBoxTower;
        private System.Windows.Forms.TextBox textBoxDiveGrp;
        private System.Windows.Forms.Label labelDive;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.TextBox textBoxDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.TextBox textBoxComp;
        private System.Windows.Forms.Label labelTower;
    }
}