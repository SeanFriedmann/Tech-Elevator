namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount() : base()
        {

        }
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) { }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
           

            if ((Balance - amountToWithdraw) <= 0)
            {
                return Balance;
            }
           
            if (amountToWithdraw > Balance)
            {
                return Balance;
            }
            
            if ((Balance - amountToWithdraw) < 150)
            {
                return base.Withdraw(amountToWithdraw + 2);
            }
            if ((Balance - amountToWithdraw) >= 150) 
            {
                return base.Withdraw(amountToWithdraw);
            }


            return Balance;
        }
    }
}
