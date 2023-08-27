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
            this.SuspendLayout();
            // 
            // listBoxVoyages
            // 
            this.listBoxVoyages.FormattingEnabled = true;
            this.listBoxVoyages.ItemHeight = 15;
            this.listBoxVoyages.Location = new System.Drawing.Point(27, 77);
            this.listBoxVoyages.Name = "listBoxVoyages";
            this.listBoxVoyages.Size = new System.Drawing.Size(239, 244);
            this.listBoxVoyages.TabIndex = 0;
            this.listBoxVoyages.DoubleClick += new System.EventHandler(this.listBoxVoyages_DoubleClick);
            // 
            // labelPagesVoyages
            // 
            this.labelPagesVoyages.AutoSize = true;
            this.labelPagesVoyages.Location = new System.Drawing.Point(125, 324);
            this.labelPagesVoyages.Name = "labelPagesVoyages";
            this.labelPagesVoyages.Size = new System.Drawing.Size(38, 15);
            this.labelPagesVoyages.TabIndex = 1;
            this.labelPagesVoyages.Text = "label1";
            // 
            // buttonPrevousV
            // 
            this.buttonPrevousV.Location = new System.Drawing.Point(44, 351);
            this.buttonPrevousV.Name = "buttonPrevousV";
            this.buttonPrevousV.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevousV.TabIndex = 2;
            this.buttonPrevousV.Text = "<<";
            this.buttonPrevousV.UseVisualStyleBackColor = true;
            this.buttonPrevousV.Click += new System.EventHandler(this.buttonPrevousV_Click);
            // 
            // buttonNetxV
            // 
            this.buttonNetxV.Location = new System.Drawing.Point(163, 351);
            this.buttonNetxV.Name = "buttonNetxV";
            this.buttonNetxV.Size = new System.Drawing.Size(75, 23);
            this.buttonNetxV.TabIndex = 3;
            this.buttonNetxV.Text = ">>";
            this.buttonNetxV.UseVisualStyleBackColor = true;
            this.buttonNetxV.Click += new System.EventHandler(this.buttonNetxV_Click);
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(356, 30);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(38, 15);
            this.labelSteps.TabIndex = 4;
            this.labelSteps.Text = "label1";
            // 
            // listBoxCrew
            // 
            this.listBoxCrew.FormattingEnabled = true;
            this.listBoxCrew.ItemHeight = 15;
            this.listBoxCrew.Location = new System.Drawing.Point(290, 77);
            this.listBoxCrew.Name = "listBoxCrew";
            this.listBoxCrew.Size = new System.Drawing.Size(239, 244);
            this.listBoxCrew.TabIndex = 5;
            this.listBoxCrew.DoubleClick += new System.EventHandler(this.listBoxCrew_DoubleClick);
            // 
            // buttonNextCrew
            // 
            this.buttonNextCrew.Location = new System.Drawing.Point(427, 361);
            this.buttonNextCrew.Name = "buttonNextCrew";
            this.buttonNextCrew.Size = new System.Drawing.Size(75, 23);
            this.buttonNextCrew.TabIndex = 8;
            this.buttonNextCrew.Text = ">>";
            this.buttonNextCrew.UseVisualStyleBackColor = true;
            this.buttonNextCrew.Click += new System.EventHandler(this.buttonNextCrew_Click);
            // 
            // buttonPreviousCrew
            // 
            this.buttonPreviousCrew.Location = new System.Drawing.Point(319, 361);
            this.buttonPreviousCrew.Name = "buttonPreviousCrew";
            this.buttonPreviousCrew.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviousCrew.TabIndex = 7;
            this.buttonPreviousCrew.Text = "<<";
            this.buttonPreviousCrew.UseVisualStyleBackColor = true;
            this.buttonPreviousCrew.Click += new System.EventHandler(this.buttonPreviousCrew_Click);
            // 
            // labelPagesCrew
            // 
            this.labelPagesCrew.AutoSize = true;
            this.labelPagesCrew.Location = new System.Drawing.Point(395, 332);
            this.labelPagesCrew.Name = "labelPagesCrew";
            this.labelPagesCrew.Size = new System.Drawing.Size(38, 15);
            this.labelPagesCrew.TabIndex = 6;
            this.labelPagesCrew.Text = "label1";
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.ItemHeight = 15;
            this.listBoxTeam.Location = new System.Drawing.Point(558, 77);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(239, 244);
            this.listBoxTeam.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(619, 351);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 43);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelChosenVoyage
            // 
            this.labelChosenVoyage.AutoSize = true;
            this.labelChosenVoyage.Location = new System.Drawing.Point(558, 46);
            this.labelChosenVoyage.Name = "labelChosenVoyage";
            this.labelChosenVoyage.Size = new System.Drawing.Size(38, 15);
            this.labelChosenVoyage.TabIndex = 11;
            this.labelChosenVoyage.Text = "label1";
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxCount.Location = new System.Drawing.Point(484, 324);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(45, 23);
            this.comboBoxCount.TabIndex = 12;
            this.comboBoxCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxCount_SelectedIndexChanged);
            // 
            // AssignVoyageToCrewFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}