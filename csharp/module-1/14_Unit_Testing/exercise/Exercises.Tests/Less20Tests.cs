using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [DataTestMethod]
        [DataRow(18, true)]
        [DataRow(19, true)]
        [DataRow(20, false)]
        [TestMethod]
  
        
        public void IsLessThanMultipleOf20Test(int n, bool expectedResult)
        {
            //Arrange
            Less20 less20 = new Less20();

            //Act
            
            bool result = less20.IsLessThanMultipleOf20(n);

            //Assert
            Assert.AreEqual(expectedResult, result);



        }
    }
}
