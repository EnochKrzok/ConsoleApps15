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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            DistanceConverter converter = new DistanceConverter();
            BMI bmi = new BMI();

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("   BNU CO453 Applications Programming 2021-2022!  ");
            Console.WriteLine(" by The One And Only EEEEEEEEEEEEEEEEEEEEEEEEnoch ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
   
            Console.WriteLine(" What app would you like to use");
            Console.WriteLine("     distance converter (1)    ");
            Console.WriteLine("       BMI calculator (2)      ");
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
                else
                {
                    Console.WriteLine("That was not an option");
                }
            }
            else
            {
                Console.WriteLine(" Use a number to pick your choice ");
            }
            
            int i = 0;
            while (i < 100)
            {
                Console.Beep();
                i++;
            }
        }
    }
}
