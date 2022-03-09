using System;
namespace ConsoleAppProject.App02
    
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public int choiceUnit;

        public double bmi;

        public double height;

        public double weight;

        public void Run()
        {
            OutputHeading();
            ChoiceUnit();
            Questions();
            if (choiceUnit == 1)
            {
                ImperialBMI();
            }
            else if (choiceUnit == 2)
            {
                MetricBMI();
            }
            CalculateBMI();
            Again();
        }

        private void OutputHeading()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("            App02 BMI Calculator           ");
            Console.WriteLine("            By Enoch Jozue Krzok           ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("    Can be used with imperial or metric    ");
            Console.WriteLine("              Pls use Numbers              ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
        }
        
        private void ChoiceUnit()
        {
            Console.Write(" Would you like to use imperial(1) (pounds and inches) or metric(2) (kilograms and meters) >");
            string choiceU = Console.ReadLine();
            if (int.TryParse(choiceU, out choiceUnit))
            {
                choiceUnit = Convert.ToInt32(choiceU);
                if (!(choiceUnit == 1 || choiceUnit == 2))
                {
                    Console.WriteLine(" Pls enter a value 1 (imperial) or 2 (metric)");
                    ChoiceUnit();
                }
            }
            else
            {
                Console.WriteLine(" Pls enter a correct value ");
                ChoiceUnit();
            }
        }

        private void Questions()
        {
            string peak = "";
            string load = "";
            string inchter = "";
            string pouams = "";

            if (choiceUnit == 1)
            {
                inchter = "inches";
                pouams = "pounds";
            }
            else if (choiceUnit == 2)
            {
                inchter = "meters";
                pouams = "kilograms";
            }

            while (!double.TryParse(peak, out _))
            {
                Console.Write(" How tall are you in " + inchter + " >");
                peak = Console.ReadLine();
            }
            height = Convert.ToDouble(peak);

            while (!double.TryParse(load, out _))
            {
                Console.Write(" How much do you weigh in " + pouams + " >");
                load = Console.ReadLine();
            }
            weight = Convert.ToDouble(load);
        }

        public void MetricBMI()
        {
            bmi = weight / (height * height);
        }

        public void ImperialBMI()
        {
            bmi = weight * 703 / (height * height);
        }

        private void CalculateBMI()
        {
            Console.WriteLine(" Your BMI is " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine(" You are underweight");
            }
            else if ( 18.5 <= bmi && bmi < 25 )
            {
                Console.WriteLine(" You are normal");
            }
            else if (25 <= bmi && bmi < 30)
            {
                Console.WriteLine(" You are overweight");
            }
            else if (30 <= bmi && bmi < 35)
            {
                Console.WriteLine(" You are obese class 1");
            }
            else if (35 <= bmi && bmi < 40)
            {
                Console.WriteLine(" You are obese class 2");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine(" You are obese class 3");
            }
            
            Console.WriteLine(" Not to be racist but BAME have Higher risk (it seems BMI is based on white people sorry)");
        }

        /// <summary>
        /// Lets you run the program again
        /// </summary>
        private void Again()
        {
            Console.Write(" Would you like to go again y/n > ");
            string retry = Console.ReadLine();
            if (retry.Equals("y", StringComparison.CurrentCultureIgnoreCase))
            {
                Run();
            }
            else if (retry.Equals("n", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Write(" Hope you had a pleasant experiance. ");
            }
            else
            {
                Console.Write(" Read the instructions next time! ");
            }
        }
    }
}
