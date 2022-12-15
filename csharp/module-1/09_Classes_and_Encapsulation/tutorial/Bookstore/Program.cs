using System;

namespace TechElevator.Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tech Elevator Bookstore");
            Console.WriteLine();

            // Step Three: Test the getters and setters
            ////book twocities = new book();
            //twoCities.Title = "A Tale of Two Cities";
            //twoCities.Author = "Charles Dickens";
            //twoCities.Price = 14.99M;
            //Console.WriteLine($"Title: {twoCities.Title}, Author: {twoCities.Author}, Price: {twoCities.Price}");
            

            // Step Five: Test the Book constructor
            Book threeMusketeers = new Book("The three muskets", "Alex Dumas", 12.95M);
            Console.WriteLine(threeMusketeers.GetBookInfo());
            //Console.WriteLine($"Title: {threeMusketeers.Title}, Author: {threeMusketeers.Author}, Price: {threeMusketeers.Price}");


            // Step Nine: Test the ShoppingCart class
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Add(threeMusketeers);
            Console.WriteLine(shoppingCart.GetReceipt());
        }
    }
}
