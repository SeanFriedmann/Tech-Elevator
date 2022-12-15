using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.HR;
using PetElevator.CRM;

namespace PetElevator.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FullNameReturnsCorrectFormat()
        {
            Employee employee = new Employee("Test", "Testerson");

            string fullName = employee.FullName;

            Assert.AreEqual("Testerson, Test", fullName);
        }

        [TestMethod]
        public void RaiseSalaryTest_Positive()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(5); //raise 5%

            Assert.IsTrue(employee.Salary == 100 * 1.05);
        }

        [TestMethod]
        public void RaiseSalaryTest_Negative()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(-10); //"raise" by negative 10%

            Assert.AreEqual(100, employee.Salary); //salary should remain same
        }

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
            double expectedValue = 10.00;
            double methodOuput = customer.GetBalanceDue(servicesRendered) /2;
            Assert.AreEqual(expectedValue, methodOuput);



        }


    }
}
