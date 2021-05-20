
namespace ClientUI
{
    partial class DeleteCompetition
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteCompetition = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to delete competetion X?";
            // 
            // buttonDeleteCompetition
            // 
            this.buttonDeleteCompetition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteCompetition.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteCompetition.Location = new System.Drawing.Point(203, 114);
            this.buttonDeleteCompetition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteCompetition.Name = "buttonDeleteCompetition";
            this.buttonDeleteCompetition.Size = new System.Drawing.Size(155, 72);
            this.buttonDeleteCompetition.TabIndex = 48;
            this.buttonDeleteCompetition.Text = "Delete Competition";
            this.buttonDeleteCompetition.UseVisualStyleBackColor = true;
            this.buttonDeleteCompetition.Click += new System.EventHandler(this.buttonDeleteCompetition_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNo.ForeColor = System.Drawing.Color.Black;
            this.buttonNo.Location = new System.Drawing.Point(364, 114);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(155, 72);
            this.buttonNo.TabIndex = 49;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // DeleteCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(722, 253);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonDeleteCompetition);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCompetition";
            this.Load += new System.EventHandler(this.DeleteCompetition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteCompetition;
        private System.Windows.Forms.Button buttonNo;
    }
}