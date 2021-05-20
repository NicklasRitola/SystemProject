
namespace ClientUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Administrator = new System.Windows.Forms.Button();
            this.Diver = new System.Windows.Forms.Button();
            this.Spectator = new System.Windows.Forms.Button();
            this.Judge = new System.Windows.Forms.Button();
            this.CreateDiver = new System.Windows.Forms.Button();
            this.buttonRegisterDiver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRegisterDiver)).BeginInit();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Administrator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Administrator.Location = new System.Drawing.Point(314, 252);
            this.Administrator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(155, 72);
            this.Administrator.TabIndex = 3;
            this.Administrator.Text = "Administrator";
            this.Administrator.UseVisualStyleBackColor = true;
            this.Administrator.Click += new System.EventHandler(this.Administrator_Click);
            // 
            // Diver
            // 
            this.Diver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Diver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Diver.Location = new System.Drawing.Point(475, 252);
            this.Diver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Diver.Name = "Diver";
            this.Diver.Size = new System.Drawing.Size(155, 72);
            this.Diver.TabIndex = 4;
            this.Diver.Text = "Diver";
            this.Diver.UseVisualStyleBackColor = true;
            this.Diver.Click += new System.EventHandler(this.Diver_Click);
            // 
            // Spectator
            // 
            this.Spectator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spectator.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Spectator.Location = new System.Drawing.Point(153, 172);
            this.Spectator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Spectator.Name = "Spectator";
            this.Spectator.Size = new System.Drawing.Size(477, 72);
            this.Spectator.TabIndex = 1;
            this.Spectator.Text = "Spectator";
            this.Spectator.UseVisualStyleBackColor = true;
            this.Spectator.Click += new System.EventHandler(this.Spectator_Click);
            // 
            // Judge
            // 
            this.Judge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Judge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Judge.Location = new System.Drawing.Point(153, 252);
            this.Judge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Judge.Name = "Judge";
            this.Judge.Size = new System.Drawing.Size(155, 72);
            this.Judge.TabIndex = 2;
            this.Judge.Text = "Judge";
            this.Judge.UseVisualStyleBackColor = true;
            this.Judge.Click += new System.EventHandler(this.Judge_Click);
            // 
            // CreateDiver
            // 
            this.CreateDiver.Location = new System.Drawing.Point(-60, 490);
            this.CreateDiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateDiver.Name = "CreateDiver";
            this.CreateDiver.Size = new System.Drawing.Size(155, 72);
            this.CreateDiver.TabIndex = 7;
            this.CreateDiver.Text = "Create a diver profile";
            this.CreateDiver.UseVisualStyleBackColor = true;
            this.CreateDiver.Visible = false;
            this.CreateDiver.Click += new System.EventHandler(this.CreateDiver_Click);
            // 
            // buttonRegisterDiver
            // 
            this.buttonRegisterDiver.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegisterDiver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegisterDiver.Image = global::ClientUI.Properties.Resources.add_user;
            this.buttonRegisterDiver.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonRegisterDiver.InitialImage")));
            this.buttonRegisterDiver.Location = new System.Drawing.Point(727, 12);
            this.buttonRegisterDiver.Name = "buttonRegisterDiver";
            this.buttonRegisterDiver.Size = new System.Drawing.Size(41, 31);
            this.buttonRegisterDiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRegisterDiver.TabIndex = 8;
            this.buttonRegisterDiver.TabStop = false;
            this.buttonRegisterDiver.Click += new System.EventHandler(this.buttonRegisterDiver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.BackgroundImage = global::ClientUI.Properties.Resources.Tower_Diving_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.buttonRegisterDiver);
            this.Controls.Add(this.CreateDiver);
            this.Controls.Add(this.Judge);
            this.Controls.Add(this.Spectator);
            this.Controls.Add(this.Diver);
            this.Controls.Add(this.Administrator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diving competition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonRegisterDiver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Administrator;
        private System.Windows.Forms.Button Diver;
        private System.Windows.Forms.Button Spectator;
        private System.Windows.Forms.Button Judge;
        private System.Windows.Forms.Button CreateDiver;
        private System.Windows.Forms.PictureBox buttonRegisterDiver;
    }
}

