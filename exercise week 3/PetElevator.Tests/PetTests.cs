using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.CRM;

namespace PetElevator.Tests
{
    [TestClass]
    public class PetTests
    {
       
        [TestMethod]
        public void PetTest()
        {
            Pet pet = new Pet("Jerry", "Terrier");

            string expectedPetVaccinations = "Rabies, Distemper, Parvo";
            string actualVaccinationResult = pet.ListVaccinations();

            Assert.AreEqual(expectedPetVaccinations, actualVaccinationResult);
        }


    }
}
