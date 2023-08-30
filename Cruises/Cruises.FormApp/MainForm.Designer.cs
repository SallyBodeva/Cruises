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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CrewFormaAppButon = new System.Windows.Forms.Button();
            this.buttonVoyagesCatalog = new System.Windows.Forms.Button();
            this.buttonResevation = new System.Windows.Forms.Button();
            this.buttonShipsCatalog = new System.Windows.Forms.Button();
            this.buttonVIP = new System.Windows.Forms.Button();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(-2, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(183, 55);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // CrewFormaAppButon
            // 
            this.CrewFormaAppButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CrewFormaAppButon.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CrewFormaAppButon.Location = new System.Drawing.Point(195, 228);
            this.CrewFormaAppButon.Name = "CrewFormaAppButon";
            this.CrewFormaAppButon.Size = new System.Drawing.Size(120, 74);
            this.CrewFormaAppButon.TabIndex = 1;
            this.CrewFormaAppButon.Text = "The crew";
            this.CrewFormaAppButon.UseVisualStyleBackColor = false;
            this.CrewFormaAppButon.Click += new System.EventHandler(this.CrewFormaAppButon_Click);
            // 
            // buttonVoyagesCatalog
            // 
            this.buttonVoyagesCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonVoyagesCatalog.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVoyagesCatalog.Location = new System.Drawing.Point(44, 121);
            this.buttonVoyagesCatalog.Name = "buttonVoyagesCatalog";
            this.buttonVoyagesCatalog.Size = new System.Drawing.Size(120, 74);
            this.buttonVoyagesCatalog.TabIndex = 2;
            this.buttonVoyagesCatalog.Text = "Voyages Catalog";
            this.buttonVoyagesCatalog.UseVisualStyleBackColor = false;
            this.buttonVoyagesCatalog.Click += new System.EventHandler(this.buttonVoyagesCatalog_Click);
            // 
            // buttonResevation
            // 
            this.buttonResevation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonResevation.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResevation.Location = new System.Drawing.Point(42, 226);
            this.buttonResevation.Name = "buttonResevation";
            this.buttonResevation.Size = new System.Drawing.Size(120, 78);
            this.buttonResevation.TabIndex = 3;
            this.buttonResevation.Text = "Make a reservation";
            this.buttonResevation.UseVisualStyleBackColor = false;
            this.buttonResevation.Click += new System.EventHandler(this.buttonResevation_Click);
            // 
            // buttonShipsCatalog
            // 
            this.buttonShipsCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonShipsCatalog.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShipsCatalog.Location = new System.Drawing.Point(195, 119);
            this.buttonShipsCatalog.Name = "buttonShipsCatalog";
            this.buttonShipsCatalog.Size = new System.Drawing.Size(120, 78);
            this.buttonShipsCatalog.TabIndex = 4;
            this.buttonShipsCatalog.Text = "Ships Catalog";
            this.buttonShipsCatalog.UseVisualStyleBackColor = false;
            this.buttonShipsCatalog.Click += new System.EventHandler(this.buttonShipsCatalog_Click);
            // 
            // buttonVIP
            // 
            this.buttonVIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonVIP.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVIP.Location = new System.Drawing.Point(44, 343);
            this.buttonVIP.Name = "buttonVIP";
            this.buttonVIP.Size = new System.Drawing.Size(118, 74);
            this.buttonVIP.TabIndex = 5;
            this.buttonVIP.Text = "Create your own VIP voyage";
            this.buttonVIP.UseVisualStyleBackColor = false;
            this.buttonVIP.Click += new System.EventHandler(this.buttonVIP_Click);
            // 
            // buttonAssign
            // 
            this.buttonAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAssign.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAssign.Location = new System.Drawing.Point(195, 343);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(120, 73);
            this.buttonAssign.TabIndex = 6;
            this.buttonAssign.Text = "Assign voyage to the crew";
            this.buttonAssign.UseVisualStyleBackColor = false;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "to Enchanted Escala Cruises";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.buttonVIP);
            this.Controls.Add(this.buttonShipsCatalog);
            this.Controls.Add(this.buttonResevation);
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
        private System.Windows.Forms.Button buttonResevation;
        private System.Windows.Forms.Button buttonShipsCatalog;
        private System.Windows.Forms.Button buttonVIP;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Label label1;
    }
}
