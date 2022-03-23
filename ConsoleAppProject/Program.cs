using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            ColorSelect();

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("   BNU CO453 Applications Programming 2021-2022!  ");
            Console.WriteLine(" by The One And Only EEEEEEEEEEEEEEEEEEEEEEEEnoch ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            AppSelect();

            int i = 0;
            while (i < 100)
            {
                Console.Beep();
                i++;
            }
        }

        /// <summary>
        /// Lets you pick the app
        /// </summary>
        private static void AppSelect()
        {
            DistanceConverter converter = new DistanceConverter();
            BMI bmi = new BMI();
            StudentGrades student = new StudentGrades();

            Console.WriteLine(" What app would you like to use");
            Console.WriteLine("     distance converter (1)    ");
            Console.WriteLine("       BMI calculator (2)      ");
            Console.WriteLine("       Student Grades (3)      ");
            Console.Write(" Pls use the numbers in the brackets >");
            string choice = Console.ReadLine();

            if (Double.TryParse(choice, out double option))
            {
                option = Convert.ToDouble(choice);
                if (option == 1)
                {
                    converter.Run();
                }
                else if (option == 2)
                {
                    bmi.Run();
                }
                else if (option == 3)
                {
                    student.Run();
                }
                else
                {
                    Console.WriteLine("That was not an option");
                }
            }
            else
            {
                Console.WriteLine(" Use a number to pick your choice ");
            }
        }

        /// <summary>
        /// Lets you chose the colour of the text
        /// </summary>
        private static void ColorSelect()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Random rnd = new Random();
            int no = 0;
            foreach (var color in colors)
            {
                no++;
                Console.ForegroundColor = color;
                Console.WriteLine(" The text color is {0} (" + no + ")" , color);
            }

            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" Pick");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" which");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" colour");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" you");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" would");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" like");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" to");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" use");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" (");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write("Pls");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" use");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" the");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" numbers");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(")");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.Write(" >");
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            string colour = Console.ReadLine();

            if (Double.TryParse(colour, out _))
            {
                double option = Convert.ToDouble(colour);
                if (option == 1)
                {
                    Console.ForegroundColor = (ConsoleColor)0;
                }
                else if (option == 2)
                {
                    Console.ForegroundColor = (ConsoleColor)1;
                }
                else if (option == 3)
                {
                    Console.ForegroundColor = (ConsoleColor)2;
                }
                else if (option == 4)
                {
                    Console.ForegroundColor = (ConsoleColor)3;
                }
                else if (option == 5)
                {
                    Console.ForegroundColor = (ConsoleColor)4;
                }
                else if (option == 6)
                {
                    Console.ForegroundColor = (ConsoleColor)5;
                }
                else if (option == 7)
                {
                    Console.ForegroundColor = (ConsoleColor)6;
                }
                else if (option == 8)
                {
                    Console.ForegroundColor = (ConsoleColor)7;
                }
                else if (option == 9)
                {
                    Console.ForegroundColor = (ConsoleColor)8;
                }
                else if (option == 10)
                {
                    Console.ForegroundColor = (ConsoleColor)9;
                }
                else if (option == 11)
                {
                    Console.ForegroundColor = (ConsoleColor)10;
                }
                else if (option == 12)
                {
                    Console.ForegroundColor = (ConsoleColor)11;
                }
                else if (option == 13)
                {
                    Console.ForegroundColor = (ConsoleColor)12;
                }
                else if (option == 14)
                {
                    Console.ForegroundColor = (ConsoleColor)13;
                }
                else if (option == 15)
                {
                    Console.ForegroundColor = (ConsoleColor)14;
                }
                else if (option == 16)
                {
                    Console.ForegroundColor = (ConsoleColor)15;
                }
                else
                {
                    Console.WriteLine(" That was not an option");
                }
            }
            else
            {
                Console.WriteLine(" Use a number to pick your choice ");
            }
            ConsoleColor textColor = Console.ForegroundColor;
            Console.Write(" The text color you picked is " +textColor);
        }
    }
}
