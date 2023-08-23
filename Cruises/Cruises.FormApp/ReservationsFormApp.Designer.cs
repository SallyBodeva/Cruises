namespace Cruises.FormApp
{
    partial class ReservationsFormApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVoyages = new System.Windows.Forms.ComboBox();
            this.buttonMakeReservation = new System.Windows.Forms.Button();
            this.radioButtonRetiree = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passengers reservation form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxVoyages);
            this.groupBox1.Controls.Add(this.buttonMakeReservation);
            this.groupBox1.Controls.Add(this.radioButtonRetiree);
            this.groupBox1.Controls.Add(this.radioButtonStudent);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPhoneNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxLname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(102, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 344);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passenger\'s info:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(361, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Choose your desirable adventure::";
            // 
            // comboBoxVoyages
            // 
            this.comboBoxVoyages.FormattingEnabled = true;
            this.comboBoxVoyages.Location = new System.Drawing.Point(361, 47);
            this.comboBoxVoyages.Name = "comboBoxVoyages";
            this.comboBoxVoyages.Size = new System.Drawing.Size(199, 23);
            this.comboBoxVoyages.TabIndex = 11;
            // 
            // buttonMakeReservation
            // 
            this.buttonMakeReservation.Location = new System.Drawing.Point(199, 289);
            this.buttonMakeReservation.Name = "buttonMakeReservation";
            this.buttonMakeReservation.Size = new System.Drawing.Size(196, 36);
            this.buttonMakeReservation.TabIndex = 10;
            this.buttonMakeReservation.Text = "Make a resevation";
            this.buttonMakeReservation.UseVisualStyleBackColor = true;
            this.buttonMakeReservation.Click += new System.EventHandler(this.buttonMakeReservation_Click);
            // 
            // radioButtonRetiree
            // 
            this.radioButtonRetiree.AutoSize = true;
            this.radioButtonRetiree.Location = new System.Drawing.Point(160, 251);
            this.radioButtonRetiree.Name = "radioButtonRetiree";
            this.radioButtonRetiree.Size = new System.Drawing.Size(61, 19);
            this.radioButtonRetiree.TabIndex = 9;
            this.radioButtonRetiree.TabStop = true;
            this.radioButtonRetiree.Text = "Retiree";
            this.radioButtonRetiree.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(34, 251);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(66, 19);
            this.radioButtonStudent.TabIndex = 8;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(34, 212);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(221, 23);
            this.textBoxAge.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Age:";
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(34, 158);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(221, 23);
            this.textBoxPhoneNum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone number:";
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(34, 103);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(221, 23);
            this.textBoxLname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name:";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(33, 47);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(221, 23);
            this.textBoxFName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name:";
            // 
            // ReservationsFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ReservationsFormApp";
            this.Text = "ReservationsFormApp";
            this.Load += new System.EventHandler(this.ReservationsFormApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVoyages;
        private System.Windows.Forms.Button buttonMakeReservation;
        private System.Windows.Forms.RadioButton radioButtonRetiree;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label2;
    }
}