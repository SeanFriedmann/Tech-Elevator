using System;

namespace CommandLineProgramsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a kilo value to start at: ");
            string value = Console.ReadLine();
            int kilometerStart = int.Parse(value);

            Console.WriteLine("enter a kilo value to start at: ");
            string value2 = Console.ReadLine();
            int kilometerEnd = int.Parse(value2);

            Console.WriteLine("enter a kilo value to start at: ");
            string value3 = Console.ReadLine();
            int incrementBy = int.Parse(value3);

            //Console.WriteLine("GOing from " + kilometerStart + "to" + kilometerEnd + "incremented by" + incrementBy);

            for (int km = kilometerStart; km <= kilometerEnd; km += incrementBy)
            {
                double miles = KilometersToMiles(km);
                Console.WriteLine(km + "km is" + miles + "mi");
            }
        }

        public static double KilometersToMiles(int kilometers)
        {
            const double MilesPerKilo = 0.621371;
            return kilometers * MilesPerKilo;
        }
    }
}
