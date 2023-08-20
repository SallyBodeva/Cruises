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
            this.CrewFormaAppButon = new System.Windows.Forms.Button();
            this.buttonVoyagesCatalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(288, 46);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(153, 45);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // CrewFormaAppButon
            // 
            this.CrewFormaAppButon.Location = new System.Drawing.Point(72, 112);
            this.CrewFormaAppButon.Name = "CrewFormaAppButon";
            this.CrewFormaAppButon.Size = new System.Drawing.Size(120, 74);
            this.CrewFormaAppButon.TabIndex = 1;
            this.CrewFormaAppButon.Text = "The crew";
            this.CrewFormaAppButon.UseVisualStyleBackColor = true;
            this.CrewFormaAppButon.Click += new System.EventHandler(this.CrewFormaAppButon_Click);
            // 
            // buttonVoyagesCatalog
            // 
            this.buttonVoyagesCatalog.Location = new System.Drawing.Point(225, 112);
            this.buttonVoyagesCatalog.Name = "buttonVoyagesCatalog";
            this.buttonVoyagesCatalog.Size = new System.Drawing.Size(120, 74);
            this.buttonVoyagesCatalog.TabIndex = 2;
            this.buttonVoyagesCatalog.Text = "Voyages- Catalog";
            this.buttonVoyagesCatalog.UseVisualStyleBackColor = true;
            this.buttonVoyagesCatalog.Click += new System.EventHandler(this.buttonVoyagesCatalog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoyagesCatalog);
            this.Controls.Add(this.CrewFormaAppButon);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button CrewFormaAppButon;
        private System.Windows.Forms.Button buttonVoyagesCatalog;
    }
}
