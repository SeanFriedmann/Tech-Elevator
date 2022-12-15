using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using USCitiesAndParks.DAO;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.Tests
{
    [TestClass]
    public class ParkSqlDaoTests : BaseDaoTests
    {
        private static readonly Park PARK_1 = new Park(1, "Park 1", DateTime.Parse("1800-01-02"), 100, true);
        private static readonly Park PARK_2 = new Park(2, "Park 2", DateTime.Parse("1900-12-31"), 200, false);
        private static readonly Park PARK_3 = new Park(3, "Park 3", DateTime.Parse("2000-06-15"), 300, false);

        private ParkSqlDao dao;

        [TestInitialize]
        public override void Setup() //connect to base setup 
        {
            dao = new ParkSqlDao(ConnectionString); //geting a new DAO and new connection before every test
            base.Setup(); //open a transaction before every test so it rolls back at the end 
        }

        [TestMethod] //
        public void GetPark_ReturnsCorrectParkForId()
        {
            //lets test getting park 2 
           Park park =  dao.GetPark(2); //should get the park with id 2 from the db
            AssertParksMatch(PARK_2, park);

            //POCO: Plain Old C# Object
        }

        [TestMethod]
        public void GetPark_ReturnsNullWhenIdNotFound()
        {
            Park park = dao.GetPark(99);
            Assert.IsNull(park);
        }

        [TestMethod]
        public void GetParksByState_ReturnsAllParksForState()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetParksByState_ReturnsEmptyListForAbbreviationNotInDb()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CreatePark_ReturnsParkWithIdAndExpectedValues()
        {
            Park testPark = new Park(0, "Test Park", DateTime.Now, 900, true); //set data for new park

            Park newParkFromDB = dao.CreatePark(testPark); //create new instance of create park
            //park_id should no longer be 0 
            Assert.IsTrue(newParkFromDB.ParkId > 0);
            testPark.ParkId = newParkFromDB.ParkId; //this sets the testPark id to match the one that was made in the database
            AssertParksMatch(testPark, newParkFromDB);
            //test to make sure the park_id didnt stay at 0
           // AssertParksMatch(testPark, newParkFromDB);
        }

        [TestMethod]
        public void CreatedParkHasExpectedValuesWhenRetrieved() //skip
        {
            Assert.Fail();
        }

        [TestMethod]
        public void UpdatedParkHasExpectedValuesWhenRetrieved()
        {
            Park parkUpdate = dao.GetPark(2); //retrieve park 2 to update 
            parkUpdate.HasCamping = true; //set camping to yes (it was no)

            dao.UpdatePark(parkUpdate); //update the park

            Park retrievedPark = dao.GetPark(2); //get the park again

            AssertParksMatch(parkUpdate, retrievedPark); //make sure your actual and wanted match
        }

        [TestMethod]
        public void DeletedParkCantBeRetrieved()
        {
            dao.DeletePark(3); //bye bye biatch
            Park retrievedPark = dao.GetPark(3); //shouldnt work
            Assert.IsNull(retrievedPark);
        }

        [TestMethod]
        public void ParkAddedToStateIsInListOfParksByState()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ParkRemovedFromStateIsNotInListOfParksByState()
        {
            Assert.Fail();
        }

        private void AssertParksMatch(Park expected, Park actual) //use this method so you dont need to rewrite all the column names over again
        {
            Assert.AreEqual(expected.ParkId, actual.ParkId);
            Assert.AreEqual(expected.ParkName, actual.ParkName);
            Assert.AreEqual(expected.DateEstablished.Date, actual.DateEstablished.Date);
            Assert.AreEqual(expected.Area, actual.Area);
            Assert.AreEqual(expected.HasCamping, actual.HasCamping);
        }
    }
}
