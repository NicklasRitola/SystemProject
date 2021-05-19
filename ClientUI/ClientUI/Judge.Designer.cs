
namespace ClientUI
{
    partial class Judge
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
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.ButtonSetScore = new System.Windows.Forms.Button();
            this.textBoxSetScore = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSetCurrentTower = new System.Windows.Forms.Label();
            this.labelSetCurrentGroup = new System.Windows.Forms.Label();
            this.labelSetCurrentDiff = new System.Windows.Forms.Label();
            this.labelSetCurrentDiver = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxComp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(76, 35);
            this.buttonMainMenu.TabIndex = 30;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // ButtonSetScore
            // 
            this.ButtonSetScore.Location = new System.Drawing.Point(31, 90);
            this.ButtonSetScore.Name = "ButtonSetScore";
            this.ButtonSetScore.Size = new System.Drawing.Size(136, 54);
            this.ButtonSetScore.TabIndex = 31;
            this.ButtonSetScore.Text = "Set Score";
            this.ButtonSetScore.UseVisualStyleBackColor = true;
            this.ButtonSetScore.Click += new System.EventHandler(this.ButtonSetScore_Click);
            // 
            // textBoxSetScore
            // 
            this.textBoxSetScore.Location = new System.Drawing.Point(199, 107);
            this.textBoxSetScore.Name = "textBoxSetScore";
            this.textBoxSetScore.Size = new System.Drawing.Size(100, 23);
            this.textBoxSetScore.TabIndex = 32;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(317, 74);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(80, 15);
            this.Label.TabIndex = 33;
            this.Label.Text = "Current Diver:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Difficulty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Dive Group:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tower:";
            // 
            // labelSetCurrentTower
            // 
            this.labelSetCurrentTower.AutoSize = true;
            this.labelSetCurrentTower.Location = new System.Drawing.Point(403, 147);
            this.labelSetCurrentTower.Name = "labelSetCurrentTower";
            this.labelSetCurrentTower.Size = new System.Drawing.Size(0, 15);
            this.labelSetCurrentTower.TabIndex = 40;
            // 
            // labelSetCurrentGroup
            // 
            this.labelSetCurrentGroup.AutoSize = true;
            this.labelSetCurrentGroup.Location = new System.Drawing.Point(403, 123);
            this.labelSetCurrentGroup.Name = "labelSetCurrentGroup";
            this.labelSetCurrentGroup.Size = new System.Drawing.Size(0, 15);
            this.labelSetCurrentGroup.TabIndex = 39;
            // 
            // labelSetCurrentDiff
            // 
            this.labelSetCurrentDiff.AutoSize = true;
            this.labelSetCurrentDiff.Location = new System.Drawing.Point(403, 98);
            this.labelSetCurrentDiff.Name = "labelSetCurrentDiff";
            this.labelSetCurrentDiff.Size = new System.Drawing.Size(0, 15);
            this.labelSetCurrentDiff.TabIndex = 38;
            // 
            // labelSetCurrentDiver
            // 
            this.labelSetCurrentDiver.AutoSize = true;
            this.labelSetCurrentDiver.Location = new System.Drawing.Point(403, 74);
            this.labelSetCurrentDiver.Name = "labelSetCurrentDiver";
            this.labelSetCurrentDiver.Size = new System.Drawing.Size(0, 15);
            this.labelSetCurrentDiver.TabIndex = 37;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(13, 213);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 41;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxComp
            // 
            this.textBoxComp.Location = new System.Drawing.Point(95, 213);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(100, 23);
            this.textBoxComp.TabIndex = 42;
            // 
            // Judge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 248);
            this.Controls.Add(this.textBoxComp);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelSetCurrentTower);
            this.Controls.Add(this.labelSetCurrentGroup);
            this.Controls.Add(this.labelSetCurrentDiff);
            this.Controls.Add(this.labelSetCurrentDiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.textBoxSetScore);
            this.Controls.Add(this.ButtonSetScore);
            this.Controls.Add(this.buttonMainMenu);
            this.Name = "Judge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Judge";
            this.Load += new System.EventHandler(this.Judge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button ButtonSetScore;
        private System.Windows.Forms.TextBox textBoxSetScore;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSetCurrentTower;
        private System.Windows.Forms.Label labelSetCurrentGroup;
        private System.Windows.Forms.Label labelSetCurrentDiff;
        private System.Windows.Forms.Label labelSetCurrentDiver;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxComp;
    }
}