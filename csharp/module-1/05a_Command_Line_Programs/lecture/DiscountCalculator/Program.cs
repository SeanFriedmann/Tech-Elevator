using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Discount Calculator");

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage): ");
            //set doubleValue outside of loop
            
            double doubleValue = 0;

            //do while loop to make sure user is inputting a proper value
            do 
            {

                // Prompt the user for a discount amount
                // The answer needs to be saved as a double
                Console.Write("Enter the discount amount (w/out percentage): ");
                string discountAmount = Console.ReadLine();

                //User shouldnt be allowed to put discount greater than 100


                doubleValue = double.Parse(discountAmount);
                if (doubleValue > 100)
                {
                    Console.WriteLine("Please input a value below 100");

                }
                
            }
            while (doubleValue > 100);



           

            //User shouldnt be allowed to put discount greater than 100
            
            
           


            

            doubleValue = doubleValue / 100;

            Console.WriteLine("You entered " + doubleValue + "!");



            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): "); //2,5,10 dollars
            string priceSeries = Console.ReadLine();
            Console.WriteLine("You entered " + priceSeries);

            //split the string of prices into seperate values
            string[] pricesArray = priceSeries.Split(' '); // ["2.00", "5.00", "10.00"]

            //placeholders for adding up totals
            decimal totalOriginalPrice = 0;
            decimal totalSalePrice = 0;

            for (int i = 0; i < pricesArray.Length; i++)
            {
                string currentValue = pricesArray[i];
                decimal originalPrice = decimal.Parse(currentValue); //turn value into a decimal
                decimal discountAmountOfItem = originalPrice * (decimal)doubleValue; //figure out the amount of discount
                decimal priceFinal = originalPrice - discountAmountOfItem;
                Console.WriteLine($"Original price is {originalPrice:C2}, with a discount of {discountAmountOfItem:C2}, and a Sales price of: {priceFinal:C2}");

                //add to total amonunts
                totalSalePrice += priceFinal;
                totalOriginalPrice += originalPrice;

            }
            Console.WriteLine($"Your total original price is {totalOriginalPrice:C2} with a discount for a total of {totalSalePrice:C2}");




        }
    }
}
