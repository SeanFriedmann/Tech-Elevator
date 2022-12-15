using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            double userTempAsDouble = 0;
           // do
           // {
                Console.WriteLine("Please enter the temperature: ");
                string userTempAsString = Console.ReadLine();
                userTempAsDouble = double.Parse(userTempAsString);
           // }
           // while (userTempAsDouble < 0);

            char userMeasurementTypeAsChar = ' ';
            do
            {
                Console.WriteLine("Is the temperature in (C)elsius or (F)ahrenheit? ");
                string userMeasurementType = Console.ReadLine();
                userMeasurementTypeAsChar = char.Parse(userMeasurementType);
            }
            while (userMeasurementTypeAsChar != 'C' && userMeasurementTypeAsChar != 'F');



            double convertedAnswer = 0;
            if (userMeasurementTypeAsChar == 'C')
            {
                convertedAnswer = userTempAsDouble * 1.8 + 32;
                Console.WriteLine($"Your measurement is {userTempAsDouble} in meters and {convertedAnswer} in Fahrenheit");
            }
            if (userMeasurementTypeAsChar == 'F')
            {
                convertedAnswer = (userTempAsDouble - 32) / 1.8;
                Console.WriteLine($"Your measurement is {userTempAsDouble} in feet and {convertedAnswer} in Celsius");
            }

            //Console.WriteLine($"Your measurement is {userMeasurementAsDouble} in {userMeasurementType} and {convertedAnswer} in Fahrenheit");

        }
    }
}
