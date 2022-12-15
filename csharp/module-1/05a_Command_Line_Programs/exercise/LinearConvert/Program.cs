using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            double userMeasurementAsDouble = 0; //set var to hold decimal value
            do
            {
                Console.WriteLine("Hello, please enter a lenght of measurement"); //prompt user for input
                string userMeasurementAsString = Console.ReadLine();
                userMeasurementAsDouble = double.Parse(userMeasurementAsString);
            }
            while (userMeasurementAsDouble < 0);

            char userMeasurementTypeAsChar = ' ';
            do
            {
                Console.WriteLine("Is this in meters (m) or feet (f)");
                string userMeasurementType = Console.ReadLine();
                userMeasurementTypeAsChar = char.Parse(userMeasurementType);
            }
            while (userMeasurementTypeAsChar != 'm' && userMeasurementTypeAsChar != 'f');

           

                double convertedAnswer = 0;
                if (userMeasurementTypeAsChar == 'm')
                {
                    convertedAnswer = userMeasurementAsDouble / 0.3048;
                    Console.WriteLine($"Your measurement is {userMeasurementAsDouble} in meters and {convertedAnswer} in feet");
                }
                if (userMeasurementTypeAsChar == 'f')
                {
                    convertedAnswer = userMeasurementAsDouble / 3.2808399;
                    Console.WriteLine($"Your measurement is {userMeasurementAsDouble} in feet and {convertedAnswer} in meters");
                }

            //Console.WriteLine($"Your measurement is {userMeasurementAsDouble} in {userMeasurementType} and {convertedAnswer} in Fahrenheit");



        }
    }
}
