namespace Assignment3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorEntry = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAssignCount = new System.Windows.Forms.TextBox();
            this.txtNumStudents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLastStudent = new System.Windows.Forms.Button();
            this.btnNxtStudent = new System.Windows.Forms.Button();
            this.btnFirstStudent = new System.Windows.Forms.Button();
            this.btnPrevStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssignmentNum = new System.Windows.Forms.TextBox();
            this.lblCountAssing = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtDispStudent = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtAssignCount);
            this.groupBox1.Controls.Add(this.txtNumStudents);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(659, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counts";
            // 
            // lblErrorEntry
            // 
            this.lblErrorEntry.AutoSize = true;
            this.lblErrorEntry.Location = new System.Drawing.Point(728, 156);
            this.lblErrorEntry.Name = "lblErrorEntry";
            this.lblErrorEntry.Size = new System.Drawing.Size(120, 17);
            this.lblErrorEntry.TabIndex = 5;
            this.lblErrorEntry.Text = "                            ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(503, 38);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Counts";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAssignCount
            // 
            this.txtAssignCount.Location = new System.Drawing.Point(243, 82);
            this.txtAssignCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAssignCount.MaxLength = 2;
            this.txtAssignCount.Name = "txtAssignCount";
            this.txtAssignCount.Size = new System.Drawing.Size(132, 22);
            this.txtAssignCount.TabIndex = 3;
            this.txtAssignCount.TextChanged += new System.EventHandler(this.txtNumAssignments_TextChanged);
            // 
            // txtNumStudents
            // 
            this.txtNumStudents.Location = new System.Drawing.Point(243, 43);
            this.txtNumStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumStudents.MaxLength = 2;
            this.txtNumStudents.Name = "txtNumStudents";
            this.txtNumStudents.Size = new System.Drawing.Size(132, 22);
            this.txtNumStudents.TabIndex = 2;
            this.txtNumStudents.TextChanged += new System.EventHandler(this.txtNumStudents_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of assignments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Students:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(782, 46);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 65);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLastStudent);
            this.groupBox2.Controls.Add(this.btnNxtStudent);
            this.groupBox2.Controls.Add(this.btnFirstStudent);
            this.groupBox2.Controls.Add(this.btnPrevStudent);
            this.groupBox2.Location = new System.Drawing.Point(17, 198);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(987, 182);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigate";
            // 
            // btnLastStudent
            // 
            this.btnLastStudent.Enabled = false;
            this.btnLastStudent.Location = new System.Drawing.Point(765, 78);
            this.btnLastStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLastStudent.Name = "btnLastStudent";
            this.btnLastStudent.Size = new System.Drawing.Size(173, 28);
            this.btnLastStudent.TabIndex = 8;
            this.btnLastStudent.Text = "Last Student>>";
            this.btnLastStudent.UseVisualStyleBackColor = true;
            this.btnLastStudent.Click += new System.EventHandler(this.btnLastStudent_Click);
            // 
            // btnNxtStudent
            // 
            this.btnNxtStudent.Enabled = false;
            this.btnNxtStudent.Location = new System.Drawing.Point(539, 78);
            this.btnNxtStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNxtStudent.Name = "btnNxtStudent";
            this.btnNxtStudent.Size = new System.Drawing.Size(173, 28);
            this.btnNxtStudent.TabIndex = 7;
            this.btnNxtStudent.Text = "Next Student>";
            this.btnNxtStudent.UseVisualStyleBackColor = true;
            this.btnNxtStudent.Click += new System.EventHandler(this.btnNxtStudent_Click);
            // 
            // btnFirstStudent
            // 
            this.btnFirstStudent.Enabled = false;
            this.btnFirstStudent.Location = new System.Drawing.Point(21, 78);
            this.btnFirstStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirstStudent.Name = "btnFirstStudent";
            this.btnFirstStudent.Size = new System.Drawing.Size(173, 28);
            this.btnFirstStudent.TabIndex = 6;
            this.btnFirstStudent.Text = "<<Fisrt Student";
            this.btnFirstStudent.UseVisualStyleBackColor = true;
            this.btnFirstStudent.Click += new System.EventHandler(this.btnFirstStudent_Click);
            // 
            // btnPrevStudent
            // 
            this.btnPrevStudent.Enabled = false;
            this.btnPrevStudent.Location = new System.Drawing.Point(261, 78);
            this.btnPrevStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevStudent.Name = "btnPrevStudent";
            this.btnPrevStudent.Size = new System.Drawing.Size(173, 28);
            this.btnPrevStudent.TabIndex = 5;
            this.btnPrevStudent.Text = "<Prev Student";
            this.btnPrevStudent.UseVisualStyleBackColor = true;
            this.btnPrevStudent.Click += new System.EventHandler(this.btnPrevStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStudentName);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.btnSaveName);
            this.groupBox3.Location = new System.Drawing.Point(16, 388);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(987, 103);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Location = new System.Drawing.Point(243, 44);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(313, 22);
            this.txtStudentName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(101, 50);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Student #";
            // 
            // btnSaveName
            // 
            this.btnSaveName.Enabled = false;
            this.btnSaveName.Location = new System.Drawing.Point(767, 41);
            this.btnSaveName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(100, 28);
            this.btnSaveName.TabIndex = 5;
            this.btnSaveName.Text = "Save Names";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSaveScore);
            this.groupBox4.Controls.Add(this.txtScore);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtAssignmentNum);
            this.groupBox4.Controls.Add(this.lblCountAssing);
            this.groupBox4.Location = new System.Drawing.Point(17, 498);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(987, 135);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Info";
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Enabled = false;
            this.btnSaveScore.Location = new System.Drawing.Point(765, 38);
            this.btnSaveScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(100, 28);
            this.btnSaveScore.TabIndex = 8;
            this.btnSaveScore.Text = "Save Score";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(423, 91);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScore.MaxLength = 3;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(132, 22);
            this.txtScore.TabIndex = 6;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Assignment Score:";
            // 
            // txtAssignmentNum
            // 
            this.txtAssignmentNum.Enabled = false;
            this.txtAssignmentNum.Location = new System.Drawing.Point(423, 38);
            this.txtAssignmentNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAssignmentNum.MaxLength = 2;
            this.txtAssignmentNum.Name = "txtAssignmentNum";
            this.txtAssignmentNum.Size = new System.Drawing.Size(132, 22);
            this.txtAssignmentNum.TabIndex = 4;
            this.txtAssignmentNum.TextChanged += new System.EventHandler(this.txtAssignmentNum_TextChanged);
            // 
            // lblCountAssing
            // 
            this.lblCountAssing.AutoSize = true;
            this.lblCountAssing.Location = new System.Drawing.Point(163, 41);
            this.lblCountAssing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountAssing.Name = "lblCountAssing";
            this.lblCountAssing.Size = new System.Drawing.Size(212, 17);
            this.lblCountAssing.TabIndex = 3;
            this.lblCountAssing.Text = "Enter Assignment Number (1-5):";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Location = new System.Drawing.Point(473, 672);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(201, 28);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display Scores";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtDispStudent
            // 
            this.txtDispStudent.Enabled = false;
            this.txtDispStudent.Location = new System.Drawing.Point(17, 711);
            this.txtDispStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDispStudent.Name = "txtDispStudent";
            this.txtDispStudent.Size = new System.Drawing.Size(985, 296);
            this.txtDispStudent.TabIndex = 10;
            this.txtDispStudent.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1021, 1025);
            this.Controls.Add(this.lblErrorEntry);
            this.Controls.Add(this.txtDispStudent);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAssignCount;
        private System.Windows.Forms.TextBox txtNumStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLastStudent;
        private System.Windows.Forms.Button btnNxtStudent;
        private System.Windows.Forms.Button btnFirstStudent;
        private System.Windows.Forms.Button btnPrevStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAssignmentNum;
        private System.Windows.Forms.Label lblCountAssing;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.RichTextBox txtDispStudent;
        private System.Windows.Forms.Label lblErrorEntry;
    }
}

