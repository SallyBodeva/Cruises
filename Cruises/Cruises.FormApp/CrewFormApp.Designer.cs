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
            this.radioButtonUpdateRaiting = new System.Windows.Forms.RadioButton();
            this.radioButtonFire = new System.Windows.Forms.RadioButton();
            this.radioButtonHire = new System.Windows.Forms.RadioButton();
            this.buttonHire = new System.Windows.Forms.Button();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.buttonFire = new System.Windows.Forms.Button();
            this.textBoxIdFire = new System.Windows.Forms.TextBox();
            this.labelFireCMFire = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxNewRating = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupHire = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLNFire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFNFire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelPageNum = new System.Windows.Forms.Label();
            this.groupHire.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.listBoxCrew.DoubleClick += new System.EventHandler(this.listBoxCrew_DoubleClick);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(427, 388);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(0, 15);
            this.chooseLabel.TabIndex = 1;
            // 
            // radioButtonUpdateRaiting
            // 
            this.radioButtonUpdateRaiting.AutoSize = true;
            this.radioButtonUpdateRaiting.Location = new System.Drawing.Point(147, 59);
            this.radioButtonUpdateRaiting.Name = "radioButtonUpdateRaiting";
            this.radioButtonUpdateRaiting.Size = new System.Drawing.Size(97, 19);
            this.radioButtonUpdateRaiting.TabIndex = 4;
            this.radioButtonUpdateRaiting.TabStop = true;
            this.radioButtonUpdateRaiting.Text = "Update rating";
            this.radioButtonUpdateRaiting.UseVisualStyleBackColor = true;
            this.radioButtonUpdateRaiting.Click += new System.EventHandler(this.radioButtonUpdateRaiting_Click);
            // 
            // radioButtonFire
            // 
            this.radioButtonFire.AutoSize = true;
            this.radioButtonFire.Location = new System.Drawing.Point(213, 34);
            this.radioButtonFire.Name = "radioButtonFire";
            this.radioButtonFire.Size = new System.Drawing.Size(129, 19);
            this.radioButtonFire.TabIndex = 3;
            this.radioButtonFire.TabStop = true;
            this.radioButtonFire.Text = "Fire a crew member";
            this.radioButtonFire.UseVisualStyleBackColor = true;
            this.radioButtonFire.Click += new System.EventHandler(this.radioButtonFire_Click);
            // 
            // radioButtonHire
            // 
            this.radioButtonHire.AutoSize = true;
            this.radioButtonHire.Location = new System.Drawing.Point(24, 34);
            this.radioButtonHire.Name = "radioButtonHire";
            this.radioButtonHire.Size = new System.Drawing.Size(148, 19);
            this.radioButtonHire.TabIndex = 2;
            this.radioButtonHire.TabStop = true;
            this.radioButtonHire.Text = "Hire new crew member";
            this.radioButtonHire.UseVisualStyleBackColor = true;
            this.radioButtonHire.Click += new System.EventHandler(this.radioButtonHire_Click);
            // 
            // buttonHire
            // 
            this.buttonHire.Location = new System.Drawing.Point(153, 113);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(75, 23);
            this.buttonHire.TabIndex = 9;
            this.buttonHire.Text = "Hire";
            this.buttonHire.UseVisualStyleBackColor = true;
            this.buttonHire.Click += new System.EventHandler(this.buttonHire_Click);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(271, 67);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 23);
            this.textBoxPosition.TabIndex = 8;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(195, 75);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(53, 15);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "Position:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(271, 27);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 23);
            this.textBoxAge.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(197, 35);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(31, 15);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age:";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(82, 68);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLName.TabIndex = 4;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(8, 76);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(64, 15);
            this.labelLName.TabIndex = 3;
            this.labelLName.Text = "Last name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(6, 40);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(65, 15);
            this.labelFName.TabIndex = 2;
            this.labelFName.Text = "First name:";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(82, 32);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFName.TabIndex = 1;
            // 
            // buttonFire
            // 
            this.buttonFire.Location = new System.Drawing.Point(126, 68);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(110, 23);
            this.buttonFire.TabIndex = 10;
            this.buttonFire.Text = "Fire";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // textBoxIdFire
            // 
            this.textBoxIdFire.Location = new System.Drawing.Point(21, 28);
            this.textBoxIdFire.Name = "textBoxIdFire";
            this.textBoxIdFire.Size = new System.Drawing.Size(38, 23);
            this.textBoxIdFire.TabIndex = 10;
            // 
            // labelFireCMFire
            // 
            this.labelFireCMFire.AutoSize = true;
            this.labelFireCMFire.Location = new System.Drawing.Point(0, 32);
            this.labelFireCMFire.Name = "labelFireCMFire";
            this.labelFireCMFire.Size = new System.Drawing.Size(20, 15);
            this.labelFireCMFire.TabIndex = 1;
            this.labelFireCMFire.Text = "Id:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(130, 81);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(133, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxNewRating
            // 
            this.textBoxNewRating.Location = new System.Drawing.Point(249, 38);
            this.textBoxNewRating.Name = "textBoxNewRating";
            this.textBoxNewRating.Size = new System.Drawing.Size(100, 23);
            this.textBoxNewRating.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "New rating:";
            // 
            // textBoxIdUpdate
            // 
            this.textBoxIdUpdate.Location = new System.Drawing.Point(49, 41);
            this.textBoxIdUpdate.Name = "textBoxIdUpdate";
            this.textBoxIdUpdate.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdUpdate.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id:";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(529, 360);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(82, 43);
            this.buttonPrevious.TabIndex = 14;
            this.buttonPrevious.Text = "Previous   page";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(636, 360);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(76, 43);
            this.buttonNext.TabIndex = 15;
            this.buttonNext.Text = "Next page";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // groupHire
            // 
            this.groupHire.Controls.Add(this.labelFName);
            this.groupHire.Controls.Add(this.buttonHire);
            this.groupHire.Controls.Add(this.textBoxFName);
            this.groupHire.Controls.Add(this.labelLName);
            this.groupHire.Controls.Add(this.textBoxPosition);
            this.groupHire.Controls.Add(this.textBoxLName);
            this.groupHire.Controls.Add(this.labelAge);
            this.groupHire.Controls.Add(this.labelPosition);
            this.groupHire.Controls.Add(this.textBoxAge);
            this.groupHire.Location = new System.Drawing.Point(8, 113);
            this.groupHire.Name = "groupHire";
            this.groupHire.Size = new System.Drawing.Size(389, 145);
            this.groupHire.TabIndex = 16;
            this.groupHire.TabStop = false;
            this.groupHire.Text = "Fiil the info about our new mate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHire);
            this.groupBox1.Controls.Add(this.radioButtonUpdateRaiting);
            this.groupBox1.Controls.Add(this.radioButtonFire);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 99);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1-Choose your action";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLNFire);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxFNFire);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelFireCMFire);
            this.groupBox2.Controls.Add(this.buttonFire);
            this.groupBox2.Controls.Add(this.textBoxIdFire);
            this.groupBox2.Location = new System.Drawing.Point(10, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 97);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose crew member";
            // 
            // textBoxLNFire
            // 
            this.textBoxLNFire.Location = new System.Drawing.Point(281, 28);
            this.textBoxLNFire.Name = "textBoxLNFire";
            this.textBoxLNFire.Size = new System.Drawing.Size(88, 23);
            this.textBoxLNFire.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last name:";
            // 
            // textBoxFNFire
            // 
            this.textBoxFNFire.Location = new System.Drawing.Point(126, 28);
            this.textBoxFNFire.Name = "textBoxFNFire";
            this.textBoxFNFire.Size = new System.Drawing.Size(79, 23);
            this.textBoxFNFire.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "First name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxIdUpdate);
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxNewRating);
            this.groupBox3.Location = new System.Drawing.Point(13, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 115);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose crew member";
            // 
            // labelPageNum
            // 
            this.labelPageNum.AutoSize = true;
            this.labelPageNum.Location = new System.Drawing.Point(601, 335);
            this.labelPageNum.Name = "labelPageNum";
            this.labelPageNum.Size = new System.Drawing.Size(38, 15);
            this.labelPageNum.TabIndex = 20;
            this.labelPageNum.Text = "label1";
            // 
            // CrewFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.labelPageNum);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupHire);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.listBoxCrew);
            this.Name = "CrewFormApp";
            this.Text = "CrewFormApp";
            this.Load += new System.EventHandler(this.CrewFormApp_Load);
            this.groupHire.ResumeLayout(false);
            this.groupHire.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCrew;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.RadioButton radioButtonFire;
        private System.Windows.Forms.RadioButton radioButtonHire;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.RadioButton radioButtonUpdateRaiting;
        private System.Windows.Forms.Button buttonHire;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.TextBox textBoxIdFire;
        private System.Windows.Forms.Label labelFireCMFire;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNewRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.GroupBox groupHire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLNFire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFNFire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelPageNum;
    }
}