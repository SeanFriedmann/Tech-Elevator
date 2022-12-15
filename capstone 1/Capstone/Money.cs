using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Money
    {
        public decimal Balance { get; private set; }
        public void InputMoney(decimal value)
        {
            Balance += value;
            Logs($"{DateTime.Now} FEED MONEY: {value:C2} {Balance:C2}");
        }

        public string DispenseProduct(Products item)
        {
            if (Balance < item.Price) // <- this may be useful, but the vending machine should be checking for this before we are actualy doing a transaction..
            {
                return "Insufficient Funds";
            }
            else if(item.Stock == 0) // <- The vending machine shouldn't let you start a transaction if theres no items in stock.
            {
                return "Out of Stock";
            }
            
            Balance -= item.Price;
            item.Stock--;
            
            Logs($"{DateTime.Now} {item.ProductName} {item.ItemLocation} {item.Price:C2} {Balance:C2}");
            return item.PurchaseSaying;
            
        }

        public string FinishTransaction() //action of finishing a transaction
        {
            //Selecting "(3) Finish Transaction" allows the customer to complete the transaction and receive any remaining change.
            //The machine returns the customer's money using nickels, dimes, and quarters (using the smallest amount of coins possible).
            //The machine's current balance updates to $0 remaining.

            var previousBalance = Balance;

            int quarters = (int)(Balance / 0.25M);
            Balance -= quarters * 0.25M;

            int dimes = (int)(Balance / 0.1M);
            Balance -= dimes * 0.1M;

            int nickles = (int)(Balance / 0.05M);
            Balance -= nickles * 0.05M;

            int pennies = (int)(Balance / 0.01M);
            Balance -= pennies * 0.01M;

            Logs($"{DateTime.Now} GIVE CHANGE: {previousBalance} {Balance}");
            return $"quarters: {quarters} dimes: {dimes} nickles: {nickles} pennies: {pennies}";

           

            //return to main menu
        }

        public void Logs(string words)
        {
            string currentDir = Environment.CurrentDirectory;
            string fileName = "log.txt";
            string fullPath = Path.Combine(currentDir, fileName);
            using (StreamWriter wr = new StreamWriter(fullPath, true))
            {
                wr.WriteLine(words);
            }

        }
    }
}
