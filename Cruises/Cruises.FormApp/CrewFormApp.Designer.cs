namespace Cruises.FormApp
{
    partial class CrewFormApp
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
            this.listBoxCrew = new System.Windows.Forms.ListBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonFire = new System.Windows.Forms.RadioButton();
            this.radioButtonHire = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelHiring = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.buttonHire = new System.Windows.Forms.Button();
            this.radioButtonUpdateRaiting = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelChooseCrewM = new System.Windows.Forms.Label();
            this.labelFireCMFire = new System.Windows.Forms.Label();
            this.textBoxIdFire = new System.Windows.Forms.TextBox();
            this.buttonFire = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewRating = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCrew
            // 
            this.listBoxCrew.FormattingEnabled = true;
            this.listBoxCrew.ItemHeight = 15;
            this.listBoxCrew.Location = new System.Drawing.Point(466, 21);
            this.listBoxCrew.Name = "listBoxCrew";
            this.listBoxCrew.Size = new System.Drawing.Size(293, 304);
            this.listBoxCrew.TabIndex = 0;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(10, 6);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(147, 15);
            this.chooseLabel.TabIndex = 1;
            this.chooseLabel.Text = "Step 1-Choose your action";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonUpdateRaiting);
            this.panel1.Controls.Add(this.radioButtonFire);
            this.panel1.Controls.Add(this.radioButtonHire);
            this.panel1.Controls.Add(this.chooseLabel);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 97);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonFire
            // 
            this.radioButtonFire.AutoSize = true;
            this.radioButtonFire.Location = new System.Drawing.Point(201, 45);
            this.radioButtonFire.Name = "radioButtonFire";
            this.radioButtonFire.Size = new System.Drawing.Size(129, 19);
            this.radioButtonFire.TabIndex = 3;
            this.radioButtonFire.TabStop = true;
            this.radioButtonFire.Text = "Fire a crew member";
            this.radioButtonFire.UseVisualStyleBackColor = true;
            // 
            // radioButtonHire
            // 
            this.radioButtonHire.AutoSize = true;
            this.radioButtonHire.Location = new System.Drawing.Point(12, 45);
            this.radioButtonHire.Name = "radioButtonHire";
            this.radioButtonHire.Size = new System.Drawing.Size(148, 19);
            this.radioButtonHire.TabIndex = 2;
            this.radioButtonHire.TabStop = true;
            this.radioButtonHire.Text = "Hire new crew member";
            this.radioButtonHire.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonHire);
            this.panel2.Controls.Add(this.textBoxPosition);
            this.panel2.Controls.Add(this.labelPosition);
            this.panel2.Controls.Add(this.textBoxAge);
            this.panel2.Controls.Add(this.labelAge);
            this.panel2.Controls.Add(this.textBoxLName);
            this.panel2.Controls.Add(this.labelLName);
            this.panel2.Controls.Add(this.labelFName);
            this.panel2.Controls.Add(this.textBoxFName);
            this.panel2.Controls.Add(this.labelHiring);
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 153);
            this.panel2.TabIndex = 3;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(274, 37);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 23);
            this.textBoxAge.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(200, 45);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(31, 15);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age:";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(85, 78);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLName.TabIndex = 4;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(11, 86);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(64, 15);
            this.labelLName.TabIndex = 3;
            this.labelLName.Text = "Last name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(9, 50);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(65, 15);
            this.labelFName.TabIndex = 2;
            this.labelFName.Text = "First name:";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(85, 42);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFName.TabIndex = 1;
            // 
            // labelHiring
            // 
            this.labelHiring.AutoSize = true;
            this.labelHiring.Location = new System.Drawing.Point(9, 11);
            this.labelHiring.Name = "labelHiring";
            this.labelHiring.Size = new System.Drawing.Size(176, 15);
            this.labelHiring.TabIndex = 0;
            this.labelHiring.Text = "Fiil the info about our new mate";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(198, 85);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(53, 15);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "Position:";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(274, 77);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 23);
            this.textBoxPosition.TabIndex = 8;
            // 
            // buttonHire
            // 
            this.buttonHire.Location = new System.Drawing.Point(156, 123);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(75, 23);
            this.buttonHire.TabIndex = 9;
            this.buttonHire.Text = "Hire";
            this.buttonHire.UseVisualStyleBackColor = true;
            this.buttonHire.Click += new System.EventHandler(this.buttonHire_Click);
            // 
            // radioButtonUpdateRaiting
            // 
            this.radioButtonUpdateRaiting.AutoSize = true;
            this.radioButtonUpdateRaiting.Location = new System.Drawing.Point(135, 70);
            this.radioButtonUpdateRaiting.Name = "radioButtonUpdateRaiting";
            this.radioButtonUpdateRaiting.Size = new System.Drawing.Size(97, 19);
            this.radioButtonUpdateRaiting.TabIndex = 4;
            this.radioButtonUpdateRaiting.TabStop = true;
            this.radioButtonUpdateRaiting.Text = "Update rating";
            this.radioButtonUpdateRaiting.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonFire);
            this.panel3.Controls.Add(this.textBoxIdFire);
            this.panel3.Controls.Add(this.labelFireCMFire);
            this.panel3.Controls.Add(this.labelChooseCrewM);
            this.panel3.Location = new System.Drawing.Point(5, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 69);
            this.panel3.TabIndex = 4;
            // 
            // labelChooseCrewM
            // 
            this.labelChooseCrewM.AutoSize = true;
            this.labelChooseCrewM.Location = new System.Drawing.Point(7, 9);
            this.labelChooseCrewM.Name = "labelChooseCrewM";
            this.labelChooseCrewM.Size = new System.Drawing.Size(123, 15);
            this.labelChooseCrewM.TabIndex = 0;
            this.labelChooseCrewM.Text = "Choose crew member";
            // 
            // labelFireCMFire
            // 
            this.labelFireCMFire.AutoSize = true;
            this.labelFireCMFire.Location = new System.Drawing.Point(9, 40);
            this.labelFireCMFire.Name = "labelFireCMFire";
            this.labelFireCMFire.Size = new System.Drawing.Size(20, 15);
            this.labelFireCMFire.TabIndex = 1;
            this.labelFireCMFire.Text = "Id:";
            // 
            // textBoxIdFire
            // 
            this.textBoxIdFire.Location = new System.Drawing.Point(35, 37);
            this.textBoxIdFire.Name = "textBoxIdFire";
            this.textBoxIdFire.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdFire.TabIndex = 10;
            // 
            // buttonFire
            // 
            this.buttonFire.Location = new System.Drawing.Point(196, 23);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(176, 23);
            this.buttonFire.TabIndex = 10;
            this.buttonFire.Text = "Fire";
            this.buttonFire.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonUpdate);
            this.panel4.Controls.Add(this.textBoxNewRating);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBoxIdUpdate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(6, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 109);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose crew member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id:";
            // 
            // textBoxIdUpdate
            // 
            this.textBoxIdUpdate.Location = new System.Drawing.Point(34, 43);
            this.textBoxIdUpdate.Name = "textBoxIdUpdate";
            this.textBoxIdUpdate.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdUpdate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "New rating:";
            // 
            // textBoxNewRating
            // 
            this.textBoxNewRating.Location = new System.Drawing.Point(234, 40);
            this.textBoxNewRating.Name = "textBoxNewRating";
            this.textBoxNewRating.Size = new System.Drawing.Size(100, 23);
            this.textBoxNewRating.TabIndex = 13;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(115, 83);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(133, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(529, 341);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(76, 23);
            this.buttonPrevious.TabIndex = 14;
            this.buttonPrevious.Text = "<Previous>";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(635, 341);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(76, 23);
            this.buttonNext.TabIndex = 15;
            this.buttonNext.Text = "<Next>";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // CrewFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxCrew);
            this.Name = "CrewFormApp";
            this.Text = "CrewFormApp";
            this.Load += new System.EventHandler(this.CrewFormApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCrew;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonFire;
        private System.Windows.Forms.RadioButton radioButtonHire;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelHiring;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.RadioButton radioButtonUpdateRaiting;
        private System.Windows.Forms.Button buttonHire;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.TextBox textBoxIdFire;
        private System.Windows.Forms.Label labelFireCMFire;
        private System.Windows.Forms.Label labelChooseCrewM;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNewRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
    }
}