namespace Cruises.FormApp
{
    partial class AssignVoyageToCrewFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignVoyageToCrewFormApp));
            this.listBoxVoyages = new System.Windows.Forms.ListBox();
            this.labelPagesVoyages = new System.Windows.Forms.Label();
            this.buttonPrevousV = new System.Windows.Forms.Button();
            this.buttonNetxV = new System.Windows.Forms.Button();
            this.labelSteps = new System.Windows.Forms.Label();
            this.listBoxCrew = new System.Windows.Forms.ListBox();
            this.buttonNextCrew = new System.Windows.Forms.Button();
            this.buttonPreviousCrew = new System.Windows.Forms.Button();
            this.labelPagesCrew = new System.Windows.Forms.Label();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelChosenVoyage = new System.Windows.Forms.Label();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxVoyages
            // 
            this.listBoxVoyages.BackColor = System.Drawing.Color.Lavender;
            this.listBoxVoyages.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxVoyages.FormattingEnabled = true;
            this.listBoxVoyages.ItemHeight = 23;
            this.listBoxVoyages.Location = new System.Drawing.Point(29, 31);
            this.listBoxVoyages.Name = "listBoxVoyages";
            this.listBoxVoyages.Size = new System.Drawing.Size(239, 234);
            this.listBoxVoyages.TabIndex = 0;
            this.listBoxVoyages.DoubleClick += new System.EventHandler(this.listBoxVoyages_DoubleClick);
            // 
            // labelPagesVoyages
            // 
            this.labelPagesVoyages.AutoSize = true;
            this.labelPagesVoyages.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPagesVoyages.Location = new System.Drawing.Point(127, 270);
            this.labelPagesVoyages.Name = "labelPagesVoyages";
            this.labelPagesVoyages.Size = new System.Drawing.Size(45, 21);
            this.labelPagesVoyages.TabIndex = 1;
            this.labelPagesVoyages.Text = "label1";
            // 
            // buttonPrevousV
            // 
            this.buttonPrevousV.BackColor = System.Drawing.Color.Lavender;
            this.buttonPrevousV.Location = new System.Drawing.Point(46, 305);
            this.buttonPrevousV.Name = "buttonPrevousV";
            this.buttonPrevousV.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevousV.TabIndex = 2;
            this.buttonPrevousV.Text = "<<";
            this.buttonPrevousV.UseVisualStyleBackColor = false;
            this.buttonPrevousV.Click += new System.EventHandler(this.buttonPrevousV_Click);
            // 
            // buttonNetxV
            // 
            this.buttonNetxV.BackColor = System.Drawing.Color.Lavender;
            this.buttonNetxV.Location = new System.Drawing.Point(165, 305);
            this.buttonNetxV.Name = "buttonNetxV";
            this.buttonNetxV.Size = new System.Drawing.Size(75, 23);
            this.buttonNetxV.TabIndex = 3;
            this.buttonNetxV.Text = ">>";
            this.buttonNetxV.UseVisualStyleBackColor = false;
            this.buttonNetxV.Click += new System.EventHandler(this.buttonNetxV_Click);
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSteps.Location = new System.Drawing.Point(387, 4);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(45, 21);
            this.labelSteps.TabIndex = 4;
            this.labelSteps.Text = "label1";
            // 
            // listBoxCrew
            // 
            this.listBoxCrew.BackColor = System.Drawing.Color.Lavender;
            this.listBoxCrew.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxCrew.FormattingEnabled = true;
            this.listBoxCrew.ItemHeight = 23;
            this.listBoxCrew.Location = new System.Drawing.Point(292, 31);
            this.listBoxCrew.Name = "listBoxCrew";
            this.listBoxCrew.Size = new System.Drawing.Size(239, 234);
            this.listBoxCrew.TabIndex = 5;
            this.listBoxCrew.DoubleClick += new System.EventHandler(this.listBoxCrew_DoubleClick);
            // 
            // buttonNextCrew
            // 
            this.buttonNextCrew.BackColor = System.Drawing.Color.Lavender;
            this.buttonNextCrew.Location = new System.Drawing.Point(429, 315);
            this.buttonNextCrew.Name = "buttonNextCrew";
            this.buttonNextCrew.Size = new System.Drawing.Size(75, 23);
            this.buttonNextCrew.TabIndex = 8;
            this.buttonNextCrew.Text = ">>";
            this.buttonNextCrew.UseVisualStyleBackColor = false;
            this.buttonNextCrew.Click += new System.EventHandler(this.buttonNextCrew_Click);
            // 
            // buttonPreviousCrew
            // 
            this.buttonPreviousCrew.BackColor = System.Drawing.Color.Lavender;
            this.buttonPreviousCrew.Location = new System.Drawing.Point(321, 315);
            this.buttonPreviousCrew.Name = "buttonPreviousCrew";
            this.buttonPreviousCrew.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviousCrew.TabIndex = 7;
            this.buttonPreviousCrew.Text = "<<";
            this.buttonPreviousCrew.UseVisualStyleBackColor = false;
            this.buttonPreviousCrew.Click += new System.EventHandler(this.buttonPreviousCrew_Click);
            // 
            // labelPagesCrew
            // 
            this.labelPagesCrew.AutoSize = true;
            this.labelPagesCrew.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPagesCrew.Location = new System.Drawing.Point(397, 278);
            this.labelPagesCrew.Name = "labelPagesCrew";
            this.labelPagesCrew.Size = new System.Drawing.Size(45, 21);
            this.labelPagesCrew.TabIndex = 6;
            this.labelPagesCrew.Text = "label1";
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.BackColor = System.Drawing.Color.Lavender;
            this.listBoxTeam.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.ItemHeight = 23;
            this.listBoxTeam.Location = new System.Drawing.Point(560, 31);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(239, 234);
            this.listBoxTeam.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lavender;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(610, 305);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 43);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelChosenVoyage
            // 
            this.labelChosenVoyage.AutoSize = true;
            this.labelChosenVoyage.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChosenVoyage.Location = new System.Drawing.Point(565, 7);
            this.labelChosenVoyage.Name = "labelChosenVoyage";
            this.labelChosenVoyage.Size = new System.Drawing.Size(45, 21);
            this.labelChosenVoyage.TabIndex = 11;
            this.labelChosenVoyage.Text = "label1";
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxCount.Location = new System.Drawing.Point(486, 278);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(45, 23);
            this.comboBoxCount.TabIndex = 12;
            this.comboBoxCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxCount_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-14, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // AssignVoyageToCrewFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxCount);
            this.Controls.Add(this.labelChosenVoyage);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxTeam);
            this.Controls.Add(this.buttonNextCrew);
            this.Controls.Add(this.buttonPreviousCrew);
            this.Controls.Add(this.labelPagesCrew);
            this.Controls.Add(this.listBoxCrew);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.buttonNetxV);
            this.Controls.Add(this.buttonPrevousV);
            this.Controls.Add(this.labelPagesVoyages);
            this.Controls.Add(this.listBoxVoyages);
            this.Name = "AssignVoyageToCrewFormApp";
            this.Text = "AssignVoyageToCrewFormApp";
            this.Load += new System.EventHandler(this.AssignVoyageToCrewFormApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVoyages;
        private System.Windows.Forms.Label labelPagesVoyages;
        private System.Windows.Forms.Button buttonPrevousV;
        private System.Windows.Forms.Button buttonNetxV;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.ListBox listBoxCrew;
        private System.Windows.Forms.Button buttonNextCrew;
        private System.Windows.Forms.Button buttonPreviousCrew;
        private System.Windows.Forms.Label labelPagesCrew;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelChosenVoyage;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}