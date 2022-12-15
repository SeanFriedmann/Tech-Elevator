using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [DataTestMethod]
        [DataRow("Rhino", "Crash")]
        [DataRow("Giraffe", "Tower")]
        [DataRow("Elephant", "Herd")]
        [DataRow("Lion", "Pride")]
        [DataRow("Crow", "Murder")]
        [DataRow("Pigeon", "Kit")]
        [DataRow("Flamingo", "Pat")]
        [DataRow("Deer", "Herd")]
        [DataRow("Dog", "Pack")]
        [DataRow("Crocodile", "Float")]

     
       [TestMethod]
        public void GetHerdTest(string animalName, string expectedOutput)
        {
            //Arrange
            AnimalGroupName animalGroupName = new AnimalGroupName();

            //Act

            //string wantedResult = "Crash";
            string output = animalGroupName.GetHerd(animalName);

            

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }



    }
}
