using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; }
        public decimal Balance
        {
            get
            {
                return 0 - Debt;
            }
        }

        public CreditCardAccount(string accountHolderName, string accountNumber) 
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }

        public decimal Amount(decimal Balance)
        {
            Balance = -Debt;
            return Balance;
        }
        public decimal Pay(decimal amountToPay)
        {
            return Debt -= amountToPay;
        }

        public decimal Charge(decimal amountToCharge)
        {
            return Debt += amountToCharge;
        }
        
       
    }
}
