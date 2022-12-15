using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using USCitiesAndParks.DAO;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.Tests
{
    [TestClass]
    public class CitySqlDaoTests : BaseDaoTests
    {
        private static readonly City CITY_1 = new City(1, "City 1", "AA", 11,111); //belong to only city, cannot be changed
        private static readonly City CITY_2 = new City(2, "City 2", "BB", 22,222);
        private static readonly City CITY_4 = new City(4, "City 4", "AA", 44,444);

        private City testCity; //declared city called test city

        private CitySqlDao dao; //declared dao called dao

        [TestInitialize] //before each test do a setup method
        public override void Setup() //override from base method setup
        {
            //a lot of arranging happens here
            dao = new CitySqlDao(ConnectionString); //makes a connection to the DB
            testCity = new City(0, "Test City", "CC", 99, 999); //setup our testCity
            base.Setup(); //run the setup method from base class, opens transactiin
        }

        [TestMethod] //first method test
        public void GetCity_ReturnsCorrectCityForId() //can we get city based on city id?
        {
            City city = dao.GetCity(1); //interact with mock db
            AssertCitiesMatch(CITY_1, city); //calling our method from bottom, checks to see if city_1 = city

            city = dao.GetCity(2);
            AssertCitiesMatch(CITY_2, city);
        }

        [TestMethod]
        public void GetCity_ReturnsNullWhenIdNotFound()
        {
            City city = dao.GetCity(99); //check for city 99
            Assert.IsNull(city); //should be nul since it doesnt exist
        }

        [TestMethod]
        public void GetCitiesByState_ReturnsAllCitiesForState()
        {
            IList<City> cities = dao.GetCitiesByState("AA"); //create list off cities for a state of AA
            Assert.AreEqual(2, cities.Count); //it better be 2
            AssertCitiesMatch(CITY_1, cities[0]);
            AssertCitiesMatch(CITY_4, cities[1]);

            cities = dao.GetCitiesByState("BB");
            Assert.AreEqual(1, cities.Count);
            AssertCitiesMatch(CITY_2, cities[0]);
        }

        [TestMethod]
        public void GetCitiesByState_ReturnsEmptyListForAbbreviationNotInDb()
        {
            IList<City> cities = dao.GetCitiesByState("XX");
            Assert.AreEqual(0, cities.Count);
        }

        [TestMethod]
        public void CreateCity_ReturnsCityWithIdAndExpectedValues()
        {
            City createdCity = dao.CreateCity(testCity);

            int newId = createdCity.CityId;
            Assert.IsTrue(newId > 0);

            testCity.CityId = newId;
            AssertCitiesMatch(testCity, createdCity);
        }

        [TestMethod]
        public void CreatedCityHasExpectedValuesWhenRetrieved()
        {
            City createdCity = dao.CreateCity(testCity);

            int newId = createdCity.CityId;
            City retrievedCity = dao.GetCity(newId);

            AssertCitiesMatch(createdCity, retrievedCity);
        }

        [TestMethod]
        public void UpdatedCityHasExpectedValuesWhenRetrieved()
        {
            City cityToUpdate = dao.GetCity(1);

            cityToUpdate.CityName = "Updated";
            cityToUpdate.StateAbbreviation = "CC";
            cityToUpdate.Population = 99;
            cityToUpdate.Area = 999;

            dao.UpdateCity(cityToUpdate);

            City retrievedCity = dao.GetCity(1);
            AssertCitiesMatch(cityToUpdate, retrievedCity);
        }

        [TestMethod]
        public void DeletedCityCantBeRetrieved()
        {
            dao.DeleteCity(4);

            City retrievedCity = dao.GetCity(4);
            Assert.IsNull(retrievedCity);

            IList<City> cities = dao.GetCitiesByState("AA");
            Assert.AreEqual(1, cities.Count);
            AssertCitiesMatch(CITY_1, cities[0]);
        }

        private void AssertCitiesMatch(City expected, City actual) //reason is we take a row out of the SQLDataReader and turn it into a c# object
            //data comes in as a SQL data type
            //so we must make our own assert statements using the data coming from squeal
            //data conversion happens in the Data Access Object (DAO) but testing in assert statement
            //expected/actual: first and second values youre pulling in in your test methods
        {
            Assert.AreEqual(expected.CityId, actual.CityId);
            Assert.AreEqual(expected.CityName, actual.CityName);
            Assert.AreEqual(expected.StateAbbreviation, actual.StateAbbreviation);
            Assert.AreEqual(expected.Population, actual.Population);
            Assert.AreEqual(expected.Area, actual.Area);
        }
    }
}
