using System;
using System.Collections.Generic;
using System.IO;
namespace Capstone
{
    class VendingMachine
    {
        static Dictionary<string, Products> itemLocation = new Dictionary<string, Products>();
        static string directory = @"C:\Users\Student\git\c-sharp-minicapstonemodule1-team1\capstone";

        static string fileName = "vendingmachine.csv";
        static string fullPath = Path.Combine(directory, fileName);
        static Money balance = new Money();

        public static bool IsRunnning { get; private set; } = true;

        static void Main(string[] args)
        {

            CsvToItemDictionary();
            /*
             A main menu must display when the software runs, presenting the following options:
                (1) Display Vending Machine Items
                (2) Purchase
                (3) Exit
             */
            while (IsRunnning)
            {
                MainMenu();
            }
        }

        private static void MainMenu() 
        {
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");

            
            string userMainMenuChoice = Console.ReadLine();

            int userChoice;
            if (!int.TryParse(userMainMenuChoice, out userChoice) || userChoice < 0 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid choice.");
                return;
            }

            if (userChoice == 3) 
            {
                // (3) Exit
                // When Exit is selected by the user End the program.
                IsRunnning = false;

            }

            else if (userChoice == 1)
            {
                /* (1) Display Vending Machine Items
                
                    When the customer selects "(1) Display Vending Machine Items", they're presented with a list of all items in the vending machine with its quantity remaining:
                        * Each vending machine product has a slot identifier and a purchase price. <- DONE
                        * Each slot in the vending machine has enough room for 5 of that product.  <- DONE   
                        * A product that has run out must indicate that it's SOLD OUT. <- DONE
                */
                DisplayInventory();
            }


            else if (userChoice == 2) 
            {
                /* (2) Purchase
                        When the customer selects "(2) Purchase", they're guided through the purchasing process menu:

                            Current Money Provided: $2.00

                            (1) Feed Money
                            (2) Select Product
                            (3) Finish Transaction
                */
                /*
                    The vending machine logs all transactions to prevent theft from the vending machine. <- DONE
                       * Each purchase must generate a line in a file called Log.txt.

                */
                PurchaseMenu();
            }
            else if (userChoice == 4)
            {
                SalesReport();
            }
        }
        private static void PurchaseMenu() 
        {
            int userPurchaseChoiceAsInt = 0;
            while (userPurchaseChoiceAsInt != 3)
            {
                Console.WriteLine($"Current Money Provided: {balance.Balance:C2}");
                Console.WriteLine("");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");

                string userPurchaseChoice = Console.ReadLine();
                if(!int.TryParse(userPurchaseChoice, out userPurchaseChoiceAsInt) || userPurchaseChoiceAsInt < 0 || userPurchaseChoiceAsInt > 3)
                {
                    Console.WriteLine("Please enter a valid choice");
                }

                if (userPurchaseChoiceAsInt == 1)
                {
                    // (1) Feed Money <- DONE
                    FeedMoney();
                }
                else if (userPurchaseChoiceAsInt == 2)
                {
                    SelectProduct();

                    // (2) Select Product

                    /*
                        Show the list of products available and allow the customer to enter a code to select an item.
                            If the product code doesn't exist, the vending machine informs the customer and returns them to the Purchase menu.
                            If a product is currently sold out, the vending machine informs the customer and returns them to the Purchase menu.
                            If a customer selects a valid product, it's dispensed to the customer.
                            Dispensing an item prints the item name, cost, and the money remaining. Dispensing also returns its purchaseSaying:

                        After the machine dispenses the product return the customer to the Purchase menu <- DONE
                    */
                }
                else if (userPurchaseChoiceAsInt == 3)
                {
                    /*
                     The machine returns the customer's money using nickels, dimes, and quarters (using the smallest amount of coins possible). <- DONE
                     The machine's current balance updates to $0 remaining. <- DONE
                     After completing their purchase, the user returns to the "Main" menu to continue using the vending machine. <- DONE
                     */
                    Console.WriteLine(balance.FinishTransaction());
                }
            }
    }
        private static void FeedMoney()
        {
            Console.WriteLine("Please insert bills only!");

            string userMoney = Console.ReadLine();
            decimal userMoneyAsDecimal;
            if(!decimal.TryParse(userMoney, out userMoneyAsDecimal))
            {
                Console.WriteLine("Please enter a valid amount.");
            }

            balance.InputMoney(userMoneyAsDecimal);
        }
        private static void DisplayInventory()
        {
            foreach (var item in itemLocation)
            {
                string stockString = item.Value.Stock > 0 ? item.Value.Stock.ToString() : "SOLD OUT";
                Console.WriteLine($"{item.Key} {item.Value.ProductName} {stockString} {item.Value.Price:C2}");
            }
        }
        private static void SelectProduct()
        {
            DisplayInventory();
            Console.WriteLine("Please enter the item code!");
            string itemChoice = Console.ReadLine();

            if (itemLocation.ContainsKey(itemChoice) && itemLocation[itemChoice].Stock > 0)
            {
                Console.WriteLine($"Dispensing {itemLocation[itemChoice].ProductName}");
                Console.WriteLine($"{balance.DispenseProduct(itemLocation[itemChoice]) }");
            }
            else if(itemLocation.ContainsKey(itemChoice) && itemLocation[itemChoice].Stock == 0)
            {
                Console.WriteLine("This is out of stock sorry :'(");
            }
            else
            {
                Console.WriteLine("The code you entered is invalid.");
            }
        }
        private static void SalesReport()
        {
            string directory2 = Environment.CurrentDirectory;
            
            string fileName2 = $"{DateTime.Now.ToString().Replace(':', '_' ).Replace('/', '_')} SalesReport.txt";
            string fullpath2 = Path.Combine(directory2, fileName2);
            using (StreamWriter sw = new StreamWriter(fullpath2))
            {
                decimal sales = 0;
                foreach (Products item in itemLocation.Values)
                {
                    sw.WriteLine($"{item.ProductName}|{5 - item.Stock}");
                    sales += (5 - item.Stock) * item.Price;
                }
                sw.WriteLine($"**Total Sales** {sales:C2}");
            }
           
        }
        private static void CsvToItemDictionary()
        {
            try //NOTE: this whole try catch block technicaly is our Restock method we wrote out on the board when designing. working as intended.
            {
                // Parse out all products in vendingMachine.csv and create an instance of each product stored by the Slot Location (Ex. "A1") in the ItemLocation Dictionary.
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] lineArray = line.Split("|");

                        /*
                         * To be more inline with the P.O.O.P. (Pricipals of Object Oriented Programing) setting all these properties should be handled in the constructor.
                         * Does it realy matter? no. you can do the same thing here, but its good design.
                         *  Example:
                         *      Products product = new Product(name: lineArray[1], price: decimal.Parse(lineArray[2]), type: lineArray[3], stock: 5)
                         */

                        Products product = new Products();
                        product.ProductName = lineArray[1];
                        product.Price = decimal.Parse(lineArray[2]);
                        product.ItemLocation = lineArray[0];
                        product.Type = lineArray[3];

                        if (product.Type == "Drink")   
                        {
                            product.PurchaseSaying = "Glug Glug, Yum!";
                        }
                        if (product.Type == "Candy")
                        {
                            product.PurchaseSaying = "Munch Munch, Yum!";
                        }
                        if (product.Type == "Chip")
                        {
                            product.PurchaseSaying = "Crunch Crunch, Yum!";
                        }
                        if (product.Type == "Gum")
                        {
                            product.PurchaseSaying = "Chew Chew, Yum!";
                        }
                        // Add our product to the itemLocation using its Slot Location as the key for easy lookup when the user want to select that item for purchase.
                        itemLocation[lineArray[0]] = product;

                        // The vending machine is automatically restocked each time the application runs.
                        // Every product is initially stocked to the maximum amount.
                        product.Stock = 5;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
