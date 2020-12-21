using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Reflection;

namespace Assignment3
{

    public partial class Form1 : Form
    {
        /// <summary>
        /// Private Class Varibles. The two arrays, A running Index for arrays, student and assignments numbers from text fields
        /// </summary>
        private int iNumStudents;
        private int iNumAssignments;
        private string[] sStudentNames;
        private int[,] iAssignmentScores;
        private int iArrayIndex;
        /// <summary>
        /// For multi Thread Write Class 
        /// </summary>
        clsWriteFIle writeFile; 

        /// <summary>
        /// Delegate used to display a message on the UI thread
        /// </summary>
        private delegate void DisplayMessageDelegate();

        public Form1()
        {
            InitializeComponent();
        }               
        /// <summary>
        /// This is error Handling for the number of Studnets text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumStudents_TextChanged(object sender, EventArgs e)
        {
            lblErrorEntry.Text = "";

           if( Int32.TryParse(txtNumStudents.Text, out iNumStudents))
            {
                if (iNumStudents > 10 || iNumStudents<0 || txtAssignCount.Text == "")
                {                    
                    btnSubmit.Enabled = false;
                    lblErrorEntry.Text = "Please make valid entries for both Active fields.";
                }
                else{ btnSubmit.Enabled = true; }

            }
            else
            {
                lblErrorEntry.Text = "Please make valid entries";
                btnSubmit.Enabled = false;
            }
        }
        /// <summary>
        /// This is error handling for the Number of assignments test field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void txtNumAssignments_TextChanged(object sender, EventArgs e)
        {
            lblErrorEntry.Text = "";

            if (Int32.TryParse(txtAssignCount.Text, out iNumAssignments))
            {

                if (iNumAssignments > 99 || iNumAssignments < 0|| txtNumStudents.Text == "")
                {                   
                    btnSubmit.Enabled = false;
                    lblErrorEntry.Text = "Please make valid entries for both Active fields.";
                }
                else { btnSubmit.Enabled = true; }

            }
            else
            {
                lblErrorEntry.Text = "Please make valid entries";
                btnSubmit.Enabled = false;
            }
        }

        /// <summary>
        /// Sets size of student array and Assignment array. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sStudentNames = new string[iNumStudents];
            iAssignmentScores = new int[iNumStudents, iNumAssignments];
        

            // Initalizes every index of Student array for Defualt Name
            for (int i = 0; i<iNumStudents;i++)
            {
                sStudentNames[i] = "Studnet # " + (i+1);

                for(int j =0; j < iNumAssignments; j++)
                {
                    iAssignmentScores[i, j] = 0;
                }
            }
            
            enableDisable(true);
            lblCountAssing.Text = "Enter Assignment Number(1 - " + iNumAssignments + " ):";
            txtStudentName.Text = sStudentNames[0];
        }
        /// <summary>
        /// THis method allow the enabling of all objects on the form. While also resetting back to normal 
        /// </summary>
        /// <param name="check"></param>
        private void enableDisable(Boolean check)
        {
            btnFirstStudent.Enabled = check;
            btnNxtStudent.Enabled = check;
            btnPrevStudent.Enabled = check;
            btnLastStudent.Enabled = check;
            txtStudentName.Enabled = check;
            btnSaveName.Enabled = check;
            txtAssignmentNum.Enabled = check;
            txtScore.Enabled = check;
            btnSaveScore.Enabled = !check;
            btnDisplay.Enabled = check;
            txtDispStudent.Enabled = check;
            txtAssignCount.Enabled = !check;
            txtNumStudents.Enabled = !check;
            btnSubmit.Enabled = !check;
            btnOutput.Enabled = check;
            txtFilePath.Enabled = check;

        }
        /// <summary>
        /// Method to reset the Form to Orginal State
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            iNumAssignments = 0;
            iNumStudents = 0;
            txtNumStudents.Text = "";
            txtAssignCount.Text = "";
            txtDispStudent.Text = "";
            
            enableDisable(false);
        }
        /// <summary>
        /// Displays the Studnet name in the first index of sStudentNames
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstStudent_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = sStudentNames[0];
            lblName.Text = sStudentNames[0];
            iArrayIndex = 0;
        }
        /// <summary>
        /// Displays the Student Name in the Last index of sStudentName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastStudent_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = sStudentNames[iNumStudents - 1];
            lblName.Text = sStudentNames[iNumStudents - 1];
            iArrayIndex = sStudentNames.Length - 1;
        }
        /// <summary>
        /// Checks the current array index. If not on index 0 decrement and display Studnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevStudent_Click(object sender, EventArgs e)
        {
            if (iArrayIndex==0)
            {
                txtStudentName.Text = sStudentNames[0];
            }
            else
            {
                iArrayIndex--;
                txtStudentName.Text = sStudentNames[iArrayIndex];
            }
            lblName.Text = sStudentNames[iArrayIndex];
        }
        /// <summary>
        /// Check arrayindex if same as array size then display last else increment and display next index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNxtStudent_Click(object sender, EventArgs e)
        {
            if (iArrayIndex == sStudentNames.Length - 1)
            {
                txtStudentName.Text = sStudentNames[iArrayIndex];
            }
            else
            {
                iArrayIndex++;
                txtStudentName.Text = sStudentNames[iArrayIndex];
            }
            lblName.Text = sStudentNames[iArrayIndex];
        }
        /// <summary>
        /// Takes whatever in the student name text box and saves it in the student array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveName_Click(object sender, EventArgs e)
        {
            sStudentNames[iArrayIndex] = txtStudentName.Text;
            lblName.Text = sStudentNames[iArrayIndex];
        }
        /// <summary>
        /// Checks text and if correct will enables save socre button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAssignmentNum_TextChanged(object sender, EventArgs e)
        {
            int CheckValue = 0;

            if(Int32.TryParse(txtAssignmentNum.Text, out CheckValue))
            {
                if(CheckValue > iNumAssignments || CheckValue< 0)
                {
                    lblErrorEntry.Text = "Please enter correct value for assignment number.";
                    btnSaveScore.Enabled = false;
                }else
                {
                    btnSaveScore.Enabled = true;  
                }

            }
            else
            {
                lblErrorEntry.Text = "Please enter correct value for assignment number.";
                btnSaveScore.Enabled = false;
            }
        }
        /// <summary>
        /// Checks text and makes sure it meets constraints. If it does enable save score button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            int CheckValue = 0;

            if (Int32.TryParse(txtScore.Text, out CheckValue))
            {
                if (CheckValue > 100 || CheckValue < 0)
                {
                    lblErrorEntry.Text = "Please enter correct value for assignment number.";
                    btnSaveScore.Enabled = false;
                }
                else
                {
                    btnSaveScore.Enabled = true;
                }
            }
            else
            {
                lblErrorEntry.Text = "Please enter correct value for assignment number.";
                btnSaveScore.Enabled = false;
            }
        }

        /// <summary>
        /// Sets value in multi dimension array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            int AssignNum = 0;
            int AssignScore = 0;

           if( !Int32.TryParse(txtScore.Text, out AssignScore))
            {
                AssignScore = 0;
            }
            Int32.TryParse(txtAssignmentNum.Text, out AssignNum);
            if (AssignNum > iNumAssignments || AssignNum < 0)
            {
                lblErrorEntry.Text = "Assignment Number / Assignmnet score is incorrect.";
                txtAssignmentNum.Text = "";
                txtScore.Text = "";
            }
            else
            {
                iAssignmentScores[iArrayIndex, --AssignNum] = AssignScore;
            }
        }
        /// <summary>
        /// Runs through the arrays and displays student scores and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int count;
            string sAverageGrade="";
            txtDispStudent.Text = "Studnet Name \t\t\t ";
            
                for (int j= 0; j < iNumAssignments; j++)
                {
                count = j;
                count++;
                txtDispStudent.Text = txtDispStudent.Text + "#" + count + "\t";
                }

            txtDispStudent.Text = txtDispStudent.Text + "AVG\t GRADE\n";

            for (int i = 0; i < iNumStudents; i++)
           
            {
                txtDispStudent.Text = txtDispStudent.Text + sStudentNames[i]+ " \t\t\t ";
                for (int j = 0; j < iNumAssignments; j++)
                {
                    txtDispStudent.Text = txtDispStudent.Text + iAssignmentScores[i, j] + "\t";
                }
                sAverageGrade = calcGradeAverage(i);
                txtDispStudent.Text = txtDispStudent.Text + sAverageGrade +"\n";

            }
        }
        /// <summary>
        /// Recieve the index of the student name array. Build average and get Letter Grade
        /// </summary>
        /// <param name="iStudentIndex"></param>
        /// <returns></returns>
        private string calcGradeAverage(int iStudentIndex)
        {
            string sAverageGrade = "";
            double iAllScores= 0.0;

            
                for (int j = 0; j < iNumAssignments; j++)
                {
                    iAllScores += iAssignmentScores[iStudentIndex, j];
                }
                iAllScores = Math.Round((iAllScores / iNumAssignments),2);
            //Build String for Grade and Average
            if(iAllScores >= 93.0)
            {
                sAverageGrade = iAllScores + "A";
            }else if(iAllScores<= 92.9 && iAllScores>= 90.0)
            {
                sAverageGrade = iAllScores + "\t A-";
            }
            else if (iAllScores <= 89.9 && iAllScores >= 87.0)
            {
                sAverageGrade = iAllScores + "\tB+";
            }
            else if (iAllScores <= 86.9 && iAllScores >= 83.0)
            {
                sAverageGrade = iAllScores + "\tB";
            }
            else if (iAllScores <= 82.9 && iAllScores >= 80.0)
            {
                sAverageGrade = iAllScores + "\tB-";
            }
            else if (iAllScores <= 79.9 && iAllScores >= 77.0)
            {
                sAverageGrade = iAllScores + "\tC+";
            }
            else if (iAllScores <= 76.9 && iAllScores >= 73.0)
            {
                sAverageGrade = iAllScores + "\tC";
            }
            else if (iAllScores <= 72.9 && iAllScores >= 70.0)
            {
                sAverageGrade = iAllScores + "\tC-";
            }
            else if (iAllScores <= 69.9 && iAllScores >= 67.0)
            {
                sAverageGrade = iAllScores + "\tD+";
            }
            else if (iAllScores <= 66.9 && iAllScores >= 63.0)
            {
                sAverageGrade = iAllScores + "\tD";
            }
            else if (iAllScores <= 62.9 && iAllScores >= 60.0)
            {
                sAverageGrade = iAllScores + "\tD-";
            }
            else if (iAllScores < 60.0)
            {
                sAverageGrade = iAllScores + "\tE";
            }

            return sAverageGrade;
        }
        /// <summary>
        /// Starts a new thread to write to a file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {

                btnOutput.Enabled = false;
                //Start a new Thread
                Thread MyThread = new Thread(new ThreadStart(MyThreadMethod));
                MyThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
        /// <summary>
        /// Calls my my write class after being on the new thread.
        /// </summary>
        private void MyThreadMethod()
        {
            try {
                string filePath = @"C:\Users\Public\" + txtFilePath.Text;
                writeFile = new clsWriteFIle();

                if (File.Exists(filePath))
                {
                    MessageBox.Show("File Already Exists.");
                }
                else
                {   //WRitng
                    txtFilePath.Invoke(new DisplayMessageDelegate(DisplayWriteMessage));
                    writeFile.iNumAssign = this.iNumAssignments;
                    writeFile.iNumStud = this.iNumStudents;
                    writeFile.WriteData(sStudentNames, iAssignmentScores, filePath);
                    Thread.Sleep(2000);
                    //Finished
                    txtFilePath.Invoke(new DisplayMessageDelegate(DisplayFinishMessage));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Update the TextBox
        /// </summary>
        private void DisplayWriteMessage()
        {
            txtFilePath.Text = "File is Writing.";
        }
        /// <summary>
        /// Update the TextBox
        /// </summary>
        private void DisplayFinishMessage()
        {
            txtFilePath.Text = "File is Finished.";
        }

    }
}
