namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; set; }
      
        public decimal Balance { get; private set; }

        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.Balance = balance;
        }

        public decimal Deposit(decimal amountToDeposit)
        {
            return Balance += amountToDeposit;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            return Balance -= amountToWithdraw;
        }
        public BankAccount()
        {

        }

    }
}
