
namespace ClientUI
{
    partial class DiverMenu
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
            this.buttonRegisterDive = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 13);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(87, 51);
            this.buttonMainMenu.TabIndex = 2;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterDive
            // 
            this.buttonRegisterDive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisterDive.Location = new System.Drawing.Point(113, 108);
            this.buttonRegisterDive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRegisterDive.Name = "buttonRegisterDive";
            this.buttonRegisterDive.Size = new System.Drawing.Size(155, 72);
            this.buttonRegisterDive.TabIndex = 0;
            this.buttonRegisterDive.Text = "Register dive";
            this.buttonRegisterDive.UseVisualStyleBackColor = true;
            this.buttonRegisterDive.Click += new System.EventHandler(this.buttonRegisterDive_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSchedule.Location = new System.Drawing.Point(274, 108);
            this.buttonSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(155, 72);
            this.buttonSchedule.TabIndex = 1;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiverMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(531, 283);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonRegisterDive);
            this.Controls.Add(this.buttonMainMenu);
            this.Name = "DiverMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiverMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonRegisterDive;
        private System.Windows.Forms.Button buttonSchedule;
    }
}