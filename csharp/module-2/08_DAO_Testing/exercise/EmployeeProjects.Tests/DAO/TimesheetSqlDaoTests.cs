using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EmployeeProjects.DAO;
using EmployeeProjects.Models;

namespace EmployeeProjects.Tests.DAO
{
    [TestClass]
    public class TimesheetSqlDaoTests : BaseDaoTests
    {
        private static readonly Timesheet TIMESHEET_1 = new Timesheet(1, 1, 1, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 1");
        private static readonly Timesheet TIMESHEET_2 = new Timesheet(2, 1, 1, DateTime.Parse("2021-01-02"), 1.5M, true, "Timesheet 2");
        private static readonly Timesheet TIMESHEET_3 = new Timesheet(3, 2, 1, DateTime.Parse("2021-01-01"), 0.25M, true, "Timesheet 3");
        private static readonly Timesheet TIMESHEET_4 = new Timesheet(4, 2, 2, DateTime.Parse("2021-02-01"), 2.0M, false, "Timesheet 4");

        private TimesheetSqlDao dao;


        [TestInitialize]
        public override void Setup()
        {
            dao = new TimesheetSqlDao(ConnectionString);
            base.Setup();
        }

        [TestMethod]
        public void GetTimesheet_ReturnsCorrectTimesheetForId()
        {
            Timesheet timesheet = dao.GetTimesheet(1);

            AssertTimesheetsMatch(TIMESHEET_1, timesheet);
        }

        [TestMethod]
        public void GetTimesheet_ReturnsNullWhenIdNotFound()
        {
            Timesheet timesheet = dao.GetTimesheet(99);
            Assert.IsNull(timesheet);
        }

        [TestMethod]
        public void GetTimesheetsByEmployeeId_ReturnsListOfAllTimesheetsForEmployee()
        {
            IList<Timesheet> timesheets = dao.GetTimesheetsByEmployeeId(1);
            Assert.AreEqual(2, timesheets.Count);
            AssertTimesheetsMatch(TIMESHEET_1, timesheets[0]);
            AssertTimesheetsMatch(TIMESHEET_2, timesheets[1]);

            

            //IList<City> cities = dao.GetCitiesByState("AA"); //create list off cities for a state of AA
            //Assert.AreEqual(2, cities.Count); //it better be 2
            //AssertCitiesMatch(CITY_1, cities[0]);
            //AssertCitiesMatch(CITY_4, cities[1]);

            //cities = dao.GetCitiesByState("BB");
            //Assert.AreEqual(1, cities.Count);
            //AssertCitiesMatch(CITY_2, cities[0]);
            //Assert.Fail();
        }

        [TestMethod]
        public void GetTimesheetsByProjectId_ReturnsListOfAllTimesheetsForProject()
        {
            IList<Timesheet> timesheets = dao.GetTimesheetsByEmployeeId(1);
            Assert.AreEqual(2, timesheets.Count);
            AssertTimesheetsMatch(TIMESHEET_1, timesheets[0]);
            AssertTimesheetsMatch(TIMESHEET_2, timesheets[1]);
        }

        [TestMethod]
        public void CreateTimesheet_ReturnsTimesheetWithIdAndExpectedValues()
        {
            Timesheet testTimesheet = new Timesheet(5, 3, 3, DateTime.Parse("2021-03-01"), 1.25M, true, "Timesheet 5");

            Timesheet newTimesheetFromDB = dao.CreateTimesheet(testTimesheet); //create new instance of create park
            //park_id should no longer be 0 
            Assert.IsTrue(newTimesheetFromDB.TimesheetId > 0);
            testTimesheet.TimesheetId = newTimesheetFromDB.TimesheetId; //t
            AssertTimesheetsMatch(testTimesheet, newTimesheetFromDB);
        }

        [TestMethod]
        public void CreatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void UpdatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet timesheetUpdate = dao.GetTimesheet(2); //retrieve park 2 to update 
            timesheetUpdate.IsBillable = true; //set camping to yes (it was no)

            dao.UpdateTimesheet(timesheetUpdate); //update the park

            Timesheet timesheetRetrieve = dao.GetTimesheet(2); //get the park again

            AssertTimesheetsMatch(timesheetUpdate, timesheetRetrieve); //make sure your actual and wanted match
           // Assert.Fail();
        }

        [TestMethod]
        public void DeletedTimesheetCantBeRetrieved()
        {
            dao.DeleteTimesheet(3); 
            Timesheet retrievedTimesheet = dao.GetTimesheet(3); 
            Assert.IsNull(retrievedTimesheet);
          
        }

        [TestMethod]
        public void GetBillableHours_ReturnsCorrectTotal()
        {

            Assert.Fail();
        }

        private void AssertTimesheetsMatch(Timesheet expected, Timesheet actual)
        {
            Assert.AreEqual(expected.TimesheetId, actual.TimesheetId);
            Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
            Assert.AreEqual(expected.ProjectId, actual.ProjectId);
            Assert.AreEqual(expected.DateWorked, actual.DateWorked);
            Assert.AreEqual(expected.HoursWorked, actual.HoursWorked);
            Assert.AreEqual(expected.IsBillable, actual.IsBillable);
            Assert.AreEqual(expected.Description, actual.Description);
        }
    }
}
