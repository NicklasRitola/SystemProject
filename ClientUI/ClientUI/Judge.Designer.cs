
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
            this.textBoxCurrentDiver = new System.Windows.Forms.TextBox();
            this.textBoxDifficulty = new System.Windows.Forms.TextBox();
            this.textBoxDiveGroup = new System.Windows.Forms.TextBox();
            this.textBoxTower = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(14, 16);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(87, 47);
            this.buttonMainMenu.TabIndex = 30;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // ButtonSetScore
            // 
            this.ButtonSetScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSetScore.Location = new System.Drawing.Point(35, 120);
            this.ButtonSetScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSetScore.Name = "ButtonSetScore";
            this.ButtonSetScore.Size = new System.Drawing.Size(155, 72);
            this.ButtonSetScore.TabIndex = 31;
            this.ButtonSetScore.Text = "Set Score";
            this.ButtonSetScore.UseVisualStyleBackColor = true;
            this.ButtonSetScore.Click += new System.EventHandler(this.ButtonSetScore_Click);
            // 
            // textBoxSetScore
            // 
            this.textBoxSetScore.Location = new System.Drawing.Point(214, 146);
            this.textBoxSetScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSetScore.Name = "textBoxSetScore";
            this.textBoxSetScore.PlaceholderText = "Enter a score";
            this.textBoxSetScore.Size = new System.Drawing.Size(114, 27);
            this.textBoxSetScore.TabIndex = 32;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(362, 99);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(99, 20);
            this.Label.TabIndex = 33;
            this.Label.Text = "Current Diver:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Difficulty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Dive Group:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tower:";
            // 
            // labelSetCurrentTower
            // 
            this.labelSetCurrentTower.AutoSize = true;
            this.labelSetCurrentTower.Location = new System.Drawing.Point(461, 196);
            this.labelSetCurrentTower.Name = "labelSetCurrentTower";
            this.labelSetCurrentTower.Size = new System.Drawing.Size(0, 20);
            this.labelSetCurrentTower.TabIndex = 40;
            // 
            // labelSetCurrentGroup
            // 
            this.labelSetCurrentGroup.AutoSize = true;
            this.labelSetCurrentGroup.Location = new System.Drawing.Point(461, 164);
            this.labelSetCurrentGroup.Name = "labelSetCurrentGroup";
            this.labelSetCurrentGroup.Size = new System.Drawing.Size(0, 20);
            this.labelSetCurrentGroup.TabIndex = 39;
            // 
            // labelSetCurrentDiff
            // 
            this.labelSetCurrentDiff.AutoSize = true;
            this.labelSetCurrentDiff.Location = new System.Drawing.Point(461, 131);
            this.labelSetCurrentDiff.Name = "labelSetCurrentDiff";
            this.labelSetCurrentDiff.Size = new System.Drawing.Size(0, 20);
            this.labelSetCurrentDiff.TabIndex = 38;
            // 
            // labelSetCurrentDiver
            // 
            this.labelSetCurrentDiver.AutoSize = true;
            this.labelSetCurrentDiver.Location = new System.Drawing.Point(461, 99);
            this.labelSetCurrentDiver.Name = "labelSetCurrentDiver";
            this.labelSetCurrentDiver.Size = new System.Drawing.Size(0, 20);
            this.labelSetCurrentDiver.TabIndex = 37;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(15, 282);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(86, 31);
            this.buttonRefresh.TabIndex = 41;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxComp
            // 
            this.textBoxComp.Location = new System.Drawing.Point(109, 284);
            this.textBoxComp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.PlaceholderText = "Enter Competition ID";
            this.textBoxComp.Size = new System.Drawing.Size(162, 27);
            this.textBoxComp.TabIndex = 42;
            // 
            // textBoxCurrentDiver
            // 
            this.textBoxCurrentDiver.Location = new System.Drawing.Point(467, 96);
            this.textBoxCurrentDiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCurrentDiver.Name = "textBoxCurrentDiver";
            this.textBoxCurrentDiver.ReadOnly = true;
            this.textBoxCurrentDiver.Size = new System.Drawing.Size(137, 27);
            this.textBoxCurrentDiver.TabIndex = 43;
            // 
            // textBoxDifficulty
            // 
            this.textBoxDifficulty.Location = new System.Drawing.Point(467, 131);
            this.textBoxDifficulty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDifficulty.Name = "textBoxDifficulty";
            this.textBoxDifficulty.ReadOnly = true;
            this.textBoxDifficulty.Size = new System.Drawing.Size(137, 27);
            this.textBoxDifficulty.TabIndex = 44;
            // 
            // textBoxDiveGroup
            // 
            this.textBoxDiveGroup.Location = new System.Drawing.Point(467, 166);
            this.textBoxDiveGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDiveGroup.Name = "textBoxDiveGroup";
            this.textBoxDiveGroup.ReadOnly = true;
            this.textBoxDiveGroup.Size = new System.Drawing.Size(137, 27);
            this.textBoxDiveGroup.TabIndex = 45;
            // 
            // textBoxTower
            // 
            this.textBoxTower.Location = new System.Drawing.Point(467, 201);
            this.textBoxTower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTower.Name = "textBoxTower";
            this.textBoxTower.ReadOnly = true;
            this.textBoxTower.Size = new System.Drawing.Size(137, 27);
            this.textBoxTower.TabIndex = 46;
            // 
            // Judge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(652, 331);
            this.Controls.Add(this.textBoxTower);
            this.Controls.Add(this.textBoxDiveGroup);
            this.Controls.Add(this.textBoxDifficulty);
            this.Controls.Add(this.textBoxCurrentDiver);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox textBoxCurrentDiver;
        private System.Windows.Forms.TextBox textBoxDifficulty;
        private System.Windows.Forms.TextBox textBoxDiveGroup;
        private System.Windows.Forms.TextBox textBoxTower;
    }
}