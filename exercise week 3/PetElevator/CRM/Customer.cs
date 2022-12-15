using PetElevator.Shared;
using System;
using System.Collections.Generic;
using System.Text;


namespace PetElevator.CRM
{
    public class Customer : Person, IBillable
    {
        public string PhoneNumber { get; set; }
        public List<string> Pets { get; set; } = new List<string>();


        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
           

        }
         public Customer(string firstName, string lastName) : this(firstName, lastName, "")
         {
            
         }

        public double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            //Dictionary<string, double> servicesRendered 
            //{
            //    { "Grooming", 10.00 },
            //    {"Walking", 5.00 },
            //    {"Sitting", 5.00 }


            ////};
            //servicesRendered.Add("Grooming", 10.00);
            //servicesRendered.Add("Walking", 5.00);
            //servicesRendered.Add("Sitting", 5.00);
            double tempAmount = 0;
            foreach (KeyValuePair<string, double> service in servicesRendered)
            {
               
                
                 tempAmount += service.Value;
            }
            return tempAmount;
        }
    }
}
