using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.CRM;


namespace PetElevator.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void GetBalanceDueTest()
        {
            Customer customer = new Customer("Fred", "Frederickson");
            // string[] firstInput = { "Grooming", "Walking", "Sitting" };
            Dictionary<string, double> servicesRendered = new Dictionary<string, double>()
            {
                { "Grooming", 10.00 },
                {"Walking", 5.00 },
                {"Sitting", 5.00 }


            };
            // Dictionary<string, double> practice = new Dictionary<string, double>()
            //{
            //     {"Grooming", 10.00 }
            // };
            double expectedValue = 20.00;
            double methodOuput = customer.GetBalanceDue(servicesRendered);
            Assert.AreEqual(expectedValue, methodOuput);



        }
        //Customer customer = new Customer("Fred", "Frederickson");

    }
}
