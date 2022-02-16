using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app does distance conversions between six diffrent units (to and from) being meters, kilometers, nanometers, miles, feet and inches
    /// </summary>
    /// <author>
    /// Enoch Jozue Krzok version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double inputLength;

        private double outputLength;

        private double middleLength;

        private string inputUnit;

        private string outputUnit;

        private string retry;
        /// <summary>
        /// This method will run the distance converter
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputUnits();
            InputLength();
            ConvertToMeters();
            ConvertFromMeters();
            OutputLength();
            Check();
            Again();
        }

        /// <summary>
        /// outputs a heading
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("          App01 Distance Converter         ");
            Console.WriteLine("            By Enoch Jozue Krzok           ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" You can convert from and to the following ");
            Console.WriteLine("      Meters, Kilometers, Feet, Miles      ");
            Console.WriteLine("            Inches and Nanometers          ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
        }

        /// <summary>
        /// User inputs units that will be used
        /// </summary>
        private void InputUnits()
        {
            Console.Write(" Pls enter the units you want to convert from > ");
            inputUnit = Console.ReadLine();
            Console.Write(" Pls enter the units you want to convert to > ");
            outputUnit = Console.ReadLine();
        }

        /// <summary>
        /// User inputs length that will be used (only for inputunit)
        /// </summary>
        private void InputLength()
        {
            Console.Write(" Pls enter " + inputUnit + " you want to convert to " + outputUnit + " > ");
            string value = Console.ReadLine();
            inputLength = Convert.ToDouble(value);
        }

        /// <summary>
        /// Converts every available unit to meters
        /// </summary>
        private void ConvertToMeters()
        {
            ///meters to meters
            if (inputUnit.Equals("meters", StringComparison.CurrentCultureIgnoreCase))
            {
                middleLength = inputLength;
            }
            ///meters to feet
            else if (inputUnit.Equals("feet", StringComparison.CurrentCultureIgnoreCase))
            {
                middleLength = inputLength * 0.3048;
            }
            ///meters to kilometers
            else if (inputUnit.Equals("kilometers", StringComparison.CurrentCultureIgnoreCase))
            {
                middleLength = inputLength * 1000;
            }
            ///meters to miles
            else if (inputUnit.Equals("miles", StringComparison.CurrentCultureIgnoreCase))
            {
                middleLength = inputLength * 1609.35;
            }
            ///meters to inches
            else if (inputUnit.Equals("inches", StringComparison.CurrentCultureIgnoreCase))
            {
                middleLength = inputLength * 0.0254;
            }
            ///meters to nanometers
            else if (inputUnit.Equals("nanometers", StringComparison.CurrentCultureIgnoreCase))
            {
                middleLength = inputLength * 0.000000001;
            }
        }

        /// <summary>
        /// Converts any available units from meters
        /// </summary>
        private void ConvertFromMeters()
        {
            ///meters to feet
            if (outputUnit.Equals("feet", StringComparison.CurrentCultureIgnoreCase))
            {
                outputLength = middleLength * 3.280839895;
            }
            ///meters to meters
            else if (outputUnit.Equals("meters", StringComparison.CurrentCultureIgnoreCase))
            {
                outputLength = middleLength;
            }
            ///meters to kilometers
            else if (outputUnit.Equals("kilometers", StringComparison.CurrentCultureIgnoreCase))
            {
                outputLength = middleLength * 0.001;
            }
            ///meters to miles
            else if (outputUnit.Equals("miles", StringComparison.CurrentCultureIgnoreCase))
            {
                outputLength = middleLength * 0.0006213689;
            }
            ///meters to inches
            else if (outputUnit.Equals("inches", StringComparison.CurrentCultureIgnoreCase))
            {
                outputLength = middleLength * 39.37007874;
            }
            ///meters to nanometers
            else if (outputUnit.Equals("nanometers", StringComparison.CurrentCultureIgnoreCase))
            {
                outputLength = middleLength * 1000000000;
            }
        }

        /// <summary>
        /// outputs the results
        /// </summary>
        private void OutputLength()
        {
            Console.WriteLine(" " + inputLength + " " + inputUnit + " is " + outputLength + " " + outputUnit);
        }

        /// <summary>
        /// checks for spelling errors
        /// </summary>
        private void Check()
        {
            if (outputLength == 0 && inputLength != 0)
            {
                Console.WriteLine(" Pls check your spelling (remember that you have to write in full and use plurals e.g. meters not meter even if your length is 1)");
            }
        }

        /// <summary>
        /// Lets you run the program again
        /// </summary>
        private void Again()
        {
            Console.Write(" Would you like to go again y/n > ");
            retry = Console.ReadLine();
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
