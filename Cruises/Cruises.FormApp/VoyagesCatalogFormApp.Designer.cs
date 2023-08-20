namespace Cruises.FormApp
{
    partial class VoyagesCatalogFormApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "EnchantedEscala offers a luxurious escape on the Mediterranean waves, where trave" +
    "lers ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "embark on unforgettable journeys aboard our elegant ships. ";
            // 
            // VoyagesCatalogFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoyagesCatalogFormApp";
            this.Text = "VoyagesCatalogFormApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}