using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {

        [DataTestMethod]
        [DataRow(new int[] { 0, 2, 4 }, true)]
        [DataRow(new int[] { 1, 2, 3 }, false)]
        [DataRow(new int[] { 1, 2, 4 }, false)]

        //GetLucky([0, 2, 4]) → true
        //GetLucky([1, 2, 3]) → false
        //GetLucky([1, 2, 4]) → false
        [TestMethod]
        public void GetLuckyTest(int[] nums, bool expectedOutput)
        {
           
            Lucky13 lucky = new Lucky13();
            bool result = lucky.GetLucky(nums);

            Assert.AreEqual(expectedOutput, result);
        }
    }
}
