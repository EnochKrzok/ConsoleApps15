using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This class lets you input and output marks, output grades and grade profiles and quit
    /// </summary>
    /// <author>
    /// Enoch Jozue Krzok version 1.0
    /// </author>
    public class StudentGrades
    {
        public const int NumberOfStudents = 10;

        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public Grades[] Grades { get; set; }
        public int[] Gradeprofile { get; set; }

        public int Total { get; set; }
        public double Mean { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        /// <summary>
        /// assign stuff to stuff
        /// </summary>
        public StudentGrades()
        {
            Students = new string[NumberOfStudents] { "Stu1", "Stu2", "Stu3", "Stu4", "Stu5", "Stu6", "Stu7", "Stu8", "Stu9", "Stu10" };
            Marks = new int[NumberOfStudents] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Grades = new Grades[NumberOfStudents] { App03.Grades.F, App03.Grades.F, App03.Grades.F, App03.Grades.D, App03.Grades.C, App03.Grades.B, App03.Grades.A, App03.Grades.A, App03.Grades.A, App03.Grades.A };
            Gradeprofile = new int[5];
        }

        /// <summary>
        /// run the student grades program
        /// </summary>
        public void Run()
        {
            Heading();
            Menu();
        }

        /// <summary>
        /// outputs a heading
        /// </summary>
        private void Heading()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("            App03 Student Grades           ");
            Console.WriteLine("            By Enoch Jozue Krzok           ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("         Stuff about student grades        ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
        }

        /// <summary>
        /// lets you chose which thing you want to do
        /// </summary>
        private void Menu()
        {
            Console.WriteLine(" What would you like to do?");
            Console.WriteLine(" 1. Input Marks ");
            Console.WriteLine(" 2. Output Marks ");
            Console.WriteLine(" 3. Output Stats ");
            Console.WriteLine(" 4. Output Grade Profile ");
            Console.WriteLine(" 5. Quit ");
            string choice = Console.ReadLine();
            if (Double.TryParse(choice, out _))
            {
                double option = Convert.ToDouble(choice);
                if (option == 1)
                {
                    InputMarks();
                    Menu();
                }
                else if (option == 2)
                {
                    OutputMarks();
                    Menu();
                }
                else if (option == 3)
                {
                    CalculateMean();
                    CalculateMinMax();
                    OutputStats();
                    Menu();
                }
                else if (option == 4)
                {
                    CalculateGradeProfile();
                    OutputGradeProfile();
                    Menu();
                }
                else if (option == 5)
                {
                    Console.WriteLine(" THANK YOU FOR USING THIS PROGRAM");
                }
                else
                {
                    Console.WriteLine(" That was not an option");
                    Menu();
                }
            }
            else
            {
                Console.WriteLine(" Use a number to pick your choice ");
                Menu();
            }
        }

        /// <summary>
        /// inputs a int (0-100) and converts said int to enum grade
        /// </summary>
        private void InputMarks()
        {
            for (int i = 0; i < NumberOfStudents; i++)
            {
                Marks[i] = (int)ConsoleHelper.InputNumber($" Pls enter mark for {Students[i]} ", 0, 100);
                Grades[i] = ConvertMarktoGrade(Marks[i]);
            }
        }

        /// <summary>
        /// converts marks to grades
        /// </summary>
        public Grades ConvertMarktoGrade(int mark)
        {
            if (mark < 40)
            {
                return App03.Grades.F;
            }
            else if (mark < 50)
            {
                return App03.Grades.D;
            }
            else if (mark < 60)
            {
                return App03.Grades.C;
            }
            else if (mark < 70)
            {
                return App03.Grades.B;
            }
            else
            {
                return App03.Grades.A;
            }
        }

        /// <summary>
        /// Output Marks
        /// </summary>
        private void OutputMarks()
        {
            for (int i = 0; i < NumberOfStudents; i++)
            {
                Console.WriteLine($" {Students[i]} mark is {Marks[i]} and grade is {Grades[i]}");
            }
        }

        /// <summary>
        /// Caculates mean of marks
        /// </summary>
        public void CalculateMean()
        {
            foreach (int mark in Marks)
            {
                Total += mark;
            }

            Mean = Total / NumberOfStudents;
        }

        /// <summary>
        /// Caculates min and max of marks
        /// </summary>
        public void CalculateMinMax()
        {
            Min = Marks[0];
            Max = Marks[0];
            foreach (int mark in Marks)
            {
                if (mark < Min)
                {
                    Min = mark;
                }
                else if (mark > Max)
                {
                    Max = mark;
                }
            }
        }

        /// <summary>
        /// outputs the statistics (mean, max, min)
        /// </summary>
        private void OutputStats()
        {
            Console.WriteLine($" The mean mark is {Mean}");
            Console.WriteLine($" The minimum mark is {Min}");
            Console.WriteLine($" The maximum mark is {Max}");
        }

        /// <summary>
        /// calculates the precentage of students how got each grade 
        /// </summary>
        public void CalculateGradeProfile()
        {
            foreach (Grades grade in Grades)
            {
                Gradeprofile[(int)grade] += 1;
            }

            for (int i = 0; i < Gradeprofile.Length; i++)
            {
                Gradeprofile[i] = Gradeprofile[i] * 100 / NumberOfStudents;
            }
        }

        /// <summary>
        /// outputs the grade profile
        /// </summary>
        private void OutputGradeProfile()
        {
            foreach (Grades val in Enum.GetValues(typeof(Grades)))
            {
                Console.WriteLine($" The percentage of students that got {val} is {Gradeprofile[(int)val]} %");
            }
        }
    }
}
