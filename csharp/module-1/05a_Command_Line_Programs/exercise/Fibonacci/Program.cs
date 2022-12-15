using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt for user input\
           
            Console.WriteLine("Please enter an integer: "); //prompt to enter an int
            string userInput = Console.ReadLine(); // reads user value and assigns to int
            int userInputAsInt = int.Parse(userInput); //parse input into a int
            Console.WriteLine($"Your value is {userInputAsInt}"); //read user their int value

            int[] fib = new int[userInputAsInt]; //create an array of ints with the length of the user input 
            fib[0] = 0; //set fibonacci value 1 to 1
            fib[1] = 1; // set fibonacci value 2 to 2
            Console.Write($"{ fib[0]} { fib[1]}"); //display fibonacci values 1 and 2
            if (userInputAsInt >= 0) //if user value is positive input a value
            {
                for (int i = 2; i < userInputAsInt; i++) // start off i on 3rd value, incrememnt by 1 until the counter is the user value
                {
                    fib[i] = fib[i - 2] + fib[i - 1]; //fib value = last 2 indexes
                    if(fib[i] > userInputAsInt) //ensures fib is set properly 
                    {
                        break; //stops running the loop
                    }
                    else
                    {
                        
                        Console.Write($" {fib[i]}"); //print output to user
                    }
                }
            }
            //concept to write the fibacci code
        }
    }
}
