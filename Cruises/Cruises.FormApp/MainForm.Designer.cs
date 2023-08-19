namespace Cruises.FormApp
{
    partial class MainForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(265, 42);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(200, 15);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to EnchantedEscala Cruses";
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(84, 166);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeeButton.TabIndex = 1;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button EmployeeButton;
    }
}
