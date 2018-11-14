//Author: Gage Riley
//ID: 598483
//Date: 12/5/2017
//Goal-Purpose of the Program: This program allows the entry of one or more student’s names and course numeric grades; that also displays the information from the array in a Label on the form.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //ARRAYS
        //new array variables to hold the info for each player entered

        const int CONST_array_max_size = 5;

        string[] myArray_StudentNameStr = new string[5];
        int[] myArray_StudentGradeInt = new int[5];

        int student_array = 0;


        //add student info to array button/method
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {

            bool myTryParseResultBool;

            string studentName = "";
            int studentGrade = 0;

            //INPUT-VALIDATION
            if (StudentBox.Text == "")
            {
                MessageBox.Show("Error 101: Invalid Name");
                return;
            }
            studentName = StudentBox.Text;

            myTryParseResultBool = int.TryParse(GradeBox.Text, out studentGrade);
            if (myTryParseResultBool == false || studentGrade > 100 || studentGrade < 0)
            {
                MessageBox.Show("Error 201: Invalid Grade");
                return;
            }

            //ARRAYS: adding students to array
            if (student_array >= CONST_array_max_size)
            {
                MessageBox.Show("Array is full, cannot add any more to the Array...");
            }
            else
            {
                myArray_StudentNameStr[student_array] = studentName;
                myArray_StudentGradeInt[student_array] = studentGrade;

                MessageBox.Show("OK, added the student to the Array at Array index" + "[" + student_array + "]");
                StudentBox.Text = "";
                GradeBox.Text = "";
                StudentBox.Focus();
            }

            //OUTPUT
            student_array = student_array + 1;
        }

        //display the array in a label
        private void DisplayArrayBtn_Click(object sender, EventArgs e)
        {

            string myString = "";
            decimal myTotalGrades = 0;
            decimal myCount = 0;

            myString = "STUDENT DATA ENTERED SO FAR:\n";

            //loop through array_index
            for (int i = 0; i < myArray_StudentNameStr.Length; i++)
            {

                myString = myString +
                    "Array[" + i + "]  ==>  " +
                    "Student #" + (i + 1);

                if (myArray_StudentGradeInt[i] == 0)
                {
                    myString = myString + "    (NOT ENTERED)";
                }
                else
                {
                    myString = myString +
                    "    Name:" + myArray_StudentNameStr[i] +
                        "    Grade:" + myArray_StudentGradeInt[i];

                    myCount++;
                    myTotalGrades = myTotalGrades + myArray_StudentGradeInt[i];

                }

                myString = myString + "\n";
            }


            if (myCount > 0)
            {
                myString = myString +
                    "TOTAL STUDENTS:" + myCount +
                    "    AVERAGE GRADE:" + (myTotalGrades / myCount) +
                    "\n";

            }


            //OUTPUT
            ShowArrayLbl.Text = myString;

        }

        //reset the form
        private void ResetBtn_Click(object sender, EventArgs e)
        {

            StudentBox.Text = "";
            GradeBox.Text = "";
            ShowArrayLbl.Text = "";

            StudentBox.Focus();

            //ARRAYS
            //clear out the array variables
            student_array = 0;
            myArray_StudentNameStr = new string[CONST_array_max_size];
            myArray_StudentGradeInt = new int[CONST_array_max_size];
        }
    }
}
