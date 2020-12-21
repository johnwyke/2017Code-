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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAssignCount = new System.Windows.Forms.TextBox();
            this.txtNumStudents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorEntry = new System.Windows.Forms.Label();
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
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counts";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(377, 31);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 41);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Counts";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAssignCount
            // 
            this.txtAssignCount.Location = new System.Drawing.Point(182, 67);
            this.txtAssignCount.MaxLength = 2;
            this.txtAssignCount.Name = "txtAssignCount";
            this.txtAssignCount.Size = new System.Drawing.Size(100, 20);
            this.txtAssignCount.TabIndex = 3;
            this.txtAssignCount.TextChanged += new System.EventHandler(this.txtNumAssignments_TextChanged);
            // 
            // txtNumStudents
            // 
            this.txtNumStudents.Location = new System.Drawing.Point(182, 35);
            this.txtNumStudents.MaxLength = 2;
            this.txtNumStudents.Name = "txtNumStudents";
            this.txtNumStudents.Size = new System.Drawing.Size(100, 20);
            this.txtNumStudents.TabIndex = 2;
            this.txtNumStudents.TextChanged += new System.EventHandler(this.txtNumStudents_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of assignments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Students:";
            // 
            // lblErrorEntry
            // 
            this.lblErrorEntry.AutoSize = true;
            this.lblErrorEntry.Location = new System.Drawing.Point(546, 127);
            this.lblErrorEntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorEntry.Name = "lblErrorEntry";
            this.lblErrorEntry.Size = new System.Drawing.Size(91, 13);
            this.lblErrorEntry.TabIndex = 5;
            this.lblErrorEntry.Text = "                            ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(586, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 53);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 148);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigate";
            // 
            // btnLastStudent
            // 
            this.btnLastStudent.Enabled = false;
            this.btnLastStudent.Location = new System.Drawing.Point(574, 63);
            this.btnLastStudent.Name = "btnLastStudent";
            this.btnLastStudent.Size = new System.Drawing.Size(130, 23);
            this.btnLastStudent.TabIndex = 8;
            this.btnLastStudent.Text = "Last Student>>";
            this.btnLastStudent.UseVisualStyleBackColor = true;
            this.btnLastStudent.Click += new System.EventHandler(this.btnLastStudent_Click);
            // 
            // btnNxtStudent
            // 
            this.btnNxtStudent.Enabled = false;
            this.btnNxtStudent.Location = new System.Drawing.Point(404, 63);
            this.btnNxtStudent.Name = "btnNxtStudent";
            this.btnNxtStudent.Size = new System.Drawing.Size(130, 23);
            this.btnNxtStudent.TabIndex = 7;
            this.btnNxtStudent.Text = "Next Student>";
            this.btnNxtStudent.UseVisualStyleBackColor = true;
            this.btnNxtStudent.Click += new System.EventHandler(this.btnNxtStudent_Click);
            // 
            // btnFirstStudent
            // 
            this.btnFirstStudent.Enabled = false;
            this.btnFirstStudent.Location = new System.Drawing.Point(16, 63);
            this.btnFirstStudent.Name = "btnFirstStudent";
            this.btnFirstStudent.Size = new System.Drawing.Size(130, 23);
            this.btnFirstStudent.TabIndex = 6;
            this.btnFirstStudent.Text = "<<Fisrt Student";
            this.btnFirstStudent.UseVisualStyleBackColor = true;
            this.btnFirstStudent.Click += new System.EventHandler(this.btnFirstStudent_Click);
            // 
            // btnPrevStudent
            // 
            this.btnPrevStudent.Enabled = false;
            this.btnPrevStudent.Location = new System.Drawing.Point(196, 63);
            this.btnPrevStudent.Name = "btnPrevStudent";
            this.btnPrevStudent.Size = new System.Drawing.Size(130, 23);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 84);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Location = new System.Drawing.Point(182, 36);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(236, 20);
            this.txtStudentName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(76, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Student #";
            // 
            // btnSaveName
            // 
            this.btnSaveName.Enabled = false;
            this.btnSaveName.Location = new System.Drawing.Point(575, 33);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox4.Location = new System.Drawing.Point(13, 405);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(740, 110);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Info";
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Enabled = false;
            this.btnSaveScore.Location = new System.Drawing.Point(574, 31);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(75, 23);
            this.btnSaveScore.TabIndex = 8;
            this.btnSaveScore.Text = "Save Score";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(317, 74);
            this.txtScore.MaxLength = 3;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 6;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Assignment Score:";
            // 
            // txtAssignmentNum
            // 
            this.txtAssignmentNum.Enabled = false;
            this.txtAssignmentNum.Location = new System.Drawing.Point(317, 31);
            this.txtAssignmentNum.MaxLength = 2;
            this.txtAssignmentNum.Name = "txtAssignmentNum";
            this.txtAssignmentNum.Size = new System.Drawing.Size(100, 20);
            this.txtAssignmentNum.TabIndex = 4;
            this.txtAssignmentNum.TextChanged += new System.EventHandler(this.txtAssignmentNum_TextChanged);
            // 
            // lblCountAssing
            // 
            this.lblCountAssing.AutoSize = true;
            this.lblCountAssing.Location = new System.Drawing.Point(122, 33);
            this.lblCountAssing.Name = "lblCountAssing";
            this.lblCountAssing.Size = new System.Drawing.Size(156, 13);
            this.lblCountAssing.TabIndex = 3;
            this.lblCountAssing.Text = "Enter Assignment Number (1-5):";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Location = new System.Drawing.Point(29, 549);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(151, 23);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display Scores";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtDispStudent
            // 
            this.txtDispStudent.Enabled = false;
            this.txtDispStudent.Location = new System.Drawing.Point(13, 578);
            this.txtDispStudent.Name = "txtDispStudent";
            this.txtDispStudent.Size = new System.Drawing.Size(740, 241);
            this.txtDispStudent.TabIndex = 10;
            this.txtDispStudent.Text = "";
            // 
            // btnOutput
            // 
            this.btnOutput.Enabled = false;
            this.btnOutput.Location = new System.Drawing.Point(209, 549);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(151, 23);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.Text = "Output to File";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(426, 549);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(291, 20);
            this.txtFilePath.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(766, 833);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lblErrorEntry);
            this.Controls.Add(this.txtDispStudent);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}

