using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace Assignment3
{
    class clsWriteFIle
    {
        /// <summary>
        /// Total Number of Assignments
        /// </summary>
        private int iNumAssignments;
        /// <summary>
        /// Total Number of Students
        /// </summary>
        private int iNumStudents; 
        /// <summary>
        /// Getters and Setters
        /// </summary>
        public int iNumAssign
        {
            set { iNumAssignments = value; }
            get { return iNumAssignments; }
        }
        /// <summary>
        /// Getters and Setters
        /// </summary>
        public int iNumStud
        {
            set { iNumStudents = value; }
            get { return iNumStudents; }
        }
        /// <summary>
        /// This is going to write the data to the text file.
        /// </summary>
        /// <param name="sStudent"></param>
        /// <param name="iAssignmentScores"></param>
        /// <param name="Filename"></param>
        public void WriteData(string[] sStudent, int[,] iAssignmentScores, string Filename )
        {
            try
            {
                int count;
                string sAverageGrade = "";
                string sLine = "";
                using (StreamWriter MyStreamWriter = new StreamWriter(Filename))
                {
                    //Build Header String
                    sLine = "Studnet Name \t\t\t ";
                    for (int j = 0; j < iNumAssignments; j++)
                    {
                        count = j;
                        count++;
                        sLine = sLine + "#" + count + "\t";
                    }

                    sLine = sLine + "AVG\t GRADE\n";
                    //Write sLIne
                    MyStreamWriter.Write(sLine);
                }
                using (StreamWriter myAppend = File.AppendText(Filename))
                {
                    //Input Data
                    myAppend.Write("");
                    for (int i = 0; i < iNumStudents; i++)
                    {
                        sLine = "";
                        sLine = sLine + sStudent[i] + " \t\t\t ";
                        for (int j = 0; j < iNumAssignments; j++)
                        {
                            sLine = sLine + iAssignmentScores[i, j] + "\t";
                        }
                        sAverageGrade = CalcGradeAverage(i, iAssignmentScores);
                        sLine = sLine + sAverageGrade + "\n";

                        //Write the Line to to the opened file
                        myAppend.Write(sLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }


        }
        /// <summary>
        /// Calculate my Grade average
        /// </summary>
        /// <param name="iStudentIndex"></param>
        /// <param name="iAssignmentScores"></param>
        /// <returns> A letter</returns>
        private string CalcGradeAverage(int iStudentIndex, int[,] iAssignmentScores)
        {
            string sAverageGrade = "";
            try
            {
               
                double iAllScores = 0.0;


                for (int j = 0; j < iNumAssignments; j++)
                {
                    iAllScores += iAssignmentScores[iStudentIndex, j];
                }
                iAllScores = Math.Round((iAllScores / iNumAssignments), 2);
                //Build String for Grade and Average
                if (iAllScores >= 93.0)
                {
                    sAverageGrade = iAllScores + "A";
                }
                else if (iAllScores <= 92.9 && iAllScores >= 90.0)
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
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return sAverageGrade;
        }

    }
}
