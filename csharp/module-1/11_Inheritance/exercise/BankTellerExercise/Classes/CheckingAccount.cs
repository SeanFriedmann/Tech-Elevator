namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount() : base()
        {

        }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) { }

        public decimal AmountOfWithdraw { get; private set; }
        
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance < 0 && Balance > -100)
            {
                return base.Withdraw(amountToWithdraw + 10);
            }
            if ((Balance - amountToWithdraw) <= -100)
            {
                return Balance;
            }
            if ((Balance - amountToWithdraw) > 0)
            {
                return base.Withdraw(amountToWithdraw);
            }

            
            return Balance;
        }

        
    }
}
