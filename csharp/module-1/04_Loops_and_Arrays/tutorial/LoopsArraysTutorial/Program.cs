using System;

namespace LoopsArraysTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // write your code here
            int i;
            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            for (i = 10; i >=0; i--)
            {
                Console.WriteLine(i);
            }
            int[] forecastTemperature = new int[5];
            forecastTemperature[0] = 72;
            forecastTemperature[1] = 78;
            forecastTemperature[2] = 58;
            forecastTemperature[3] = 79;
            forecastTemperature[4] = 74;
            forecastTemperature[2] = forecastTemperature[2] + 10;

            for (i = 0; i < forecastTemperature.Length; i++)
            {
                Console.WriteLine(forecastTemperature[i]);
            }
            int highestTemperatureValue = forecastTemperature[0];
            int highestTemperatureIndex = 0;

            for (int j = 1; j < forecastTemperature.Length; j++)
            {
                if (forecastTemperature[j] > highestTemperatureValue)
                {
                    highestTemperatureValue = forecastTemperature[j];
                    highestTemperatureIndex = j;

                }
               //
            }
            Console.WriteLine("High temp is " + highestTemperatureValue);
            Console.WriteLine("high temp is in " + (highestTemperatureIndex + 1));
        }
    }
}
