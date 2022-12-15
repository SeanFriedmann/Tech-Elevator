using System;
using System.Collections.Generic;
using System.Text;
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class MoneyTests
    {
        [DataTestMethod]
        [DataRow(1.16, "quarters: 4 dimes: 1 nickles: 1 pennies: 1")]
        [DataRow(2.49, "quarters: 9 dimes: 2 nickles: 0 pennies: 4")]
        public void CorrectChangeTest(double currentBalance, string expectedResult)
        {
            var money = new Money();
            money.InputMoney(new decimal(currentBalance)); // <- you cant use decmials in the DataRow attributes for some reason? so im just creating a new one here with a double.

            var change = money.FinishTransaction();

            Assert.AreEqual(change, expectedResult);
        }
    }
}
