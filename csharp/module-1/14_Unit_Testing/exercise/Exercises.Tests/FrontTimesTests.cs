using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        [DataTestMethod]
        [DataRow("Chocolate", 2, "ChoCho")]
        [DataRow("Chocolate", 3, "ChoChoCho")]
        [DataRow("Abc", 3, "AbcAbcAbc")]

        [TestMethod]
        //[DataRow("Chocolate", 2)]
        //[DataRow("Chocolate", 3)]
        //[DataRow("Abc", 3)]
        public void GenerateStringTest(string str, int n, string expectedResult)
        {
            //arrange
            FrontTimes frontTimes = new FrontTimes();

            //act
            //string firstInput = "Chocolate";
            //int secondInput = 2;
            //string desiredResult = "ChoCho";
            string codeResult = frontTimes.GenerateString(str, n);

            //assert
            Assert.AreEqual(expectedResult, codeResult);

            //act 


        }
    }
}
