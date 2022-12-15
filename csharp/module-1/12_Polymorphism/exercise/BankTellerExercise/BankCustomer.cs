using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer : IAccountable
    {
        public List<IAccountable> accountables { get; set; } = new List<IAccountable>();
       
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                decimal totalBalance = 0;
                //this section needs some work
                foreach (IAccountable accountable in accountables)
                {
                    totalBalance += accountable.Balance;
                }
                    if (totalBalance >= 25000)
                    {
                        return true;
                    }
                else
                {
                    return false;
                }
                    
                    
                }
                
            
        }
        public decimal Balance { get; }


        

        public void AddAccount(IAccountable newAccount) //add accounts method
        {
            accountables.Add(newAccount); 

        }
        public IAccountable[] GetAccounts()
        {
            return accountables.ToArray();
        }
    }
  
     

}
