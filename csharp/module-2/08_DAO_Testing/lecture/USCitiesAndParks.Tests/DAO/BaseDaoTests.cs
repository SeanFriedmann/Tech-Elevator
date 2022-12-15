using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Transactions;

namespace USCitiesAndParks.Tests
{
    [TestClass]
    public class BaseDaoTests //all classes inherit from this base class
    {
        private const string DatabaseName = "UnitedStatesTesting";

        private const string AdminConnectionString = @"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"; 
        //connect to system DB
        protected const string ConnectionString = @"Server=.\SQLEXPRESS;Database=" + DatabaseName + ";Trusted_Connection=True;";

        /// <summary>
        /// The transaction for each test.
        /// </summary>
        private TransactionScope transaction;

        [AssemblyInitialize] //this will run before any of the tests in the project
        public static void BeforeAllTests(TestContext context)
        {
            string sql = File.ReadAllText("create-test-db.sql").Replace("test_db_name", DatabaseName);
            
            //make the UnitedStatesTesting DB
            using (SqlConnection conn = new SqlConnection(AdminConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            //load the test data into USTesting
            sql = File.ReadAllText("test-data.sql");
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
            }
        }

        [AssemblyCleanup] //run after all tests in the project
        public static void AfterAllTests()
        {
            // drop the temporary database (USTesting)
            string sql = File.ReadAllText("drop-test-db.sql").Replace("test_db_name", DatabaseName);

            using (SqlConnection conn = new SqlConnection(AdminConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                //
            }
        }


        [TestInitialize] //will run before each test
        public virtual void Setup() //allows this to be called in other classes
        {
            // Begin the transaction
            transaction = new TransactionScope(); //needed for integration testing

        }

        [TestCleanup] //will run after each test
        public void Cleanup()
        {
            // Roll back the transaction
            transaction.Dispose(); //needed for integration testing
        }

    }
}
