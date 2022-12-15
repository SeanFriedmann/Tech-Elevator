using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [DataTestMethod]
        [DataRow(5,10,2)]
       [DataRow(5,2,0)]
       [DataRow(5,5,1)]

        [TestMethod]
        public void GetATableTest(int you, int date, int expectedResult)
        {
            DateFashion dateFashion = new DateFashion();
           
            int result = dateFashion.GetATable(you, date);


            CollectionAssert.Equals(expectedResult, result);

            
        }
       

    }
}
