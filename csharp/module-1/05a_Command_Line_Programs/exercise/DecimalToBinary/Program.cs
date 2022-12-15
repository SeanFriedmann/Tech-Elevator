using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello, please enter a decimal values seperated by spaces: "); //prompt user for a group of int values
            string userinput =Console.ReadLine(); // read user input

            string[] userInputArray = userinput.Split(' '); //change user input from string to string array

            
            for (int i = 0; i <userInputArray.Length; i++) //loop through the length of the array
            {
                string currentValue = userInputArray[i]; //set current index to a string 
                int currentValueInt = int.Parse(currentValue); //convert string to integer
                string binary = Convert.ToString(currentValueInt, 2); //convert int to string in base 2 (binary)
                Console.WriteLine($"{userInputArray[i]} is {binary} in binary."); //print value out to user

            }
            
        }
    }
}
