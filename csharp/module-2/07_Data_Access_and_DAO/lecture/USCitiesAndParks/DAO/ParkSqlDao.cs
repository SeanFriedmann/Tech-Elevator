using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    public class ParkSqlDao : IParkDao
    {
        private readonly string connectionString;

        public ParkSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Park GetPark(int parkId)
        {
            Park park = null;
            //declare a park but leave it empty for now 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM park WHERE park_id = @park_id", conn);

                cmd.Parameters.AddWithValue("@park_id", parkId);

                SqlDataReader reader = cmd.ExecuteReader(); 

                if (reader.Read())//only want one row of code back from SQL , not multiple 
                {
                    park = CreateParkFromReader(reader);
                }

            }
            return park;

        }

        public IList<Park> GetParksByState(string stateAbbreviation)
        {
            IList<Park> parks = new List<Park>();
            //create a new IList object named park
            //lists implement IList interface

            using (SqlConnection parkConnection = new SqlConnection(connectionString))
                //using SQLConnection to open up the connection to SQL
                //instantiate the connection
            {
                parkConnection.Open();
                //have to open connection to start working on it

                SqlCommand parkCommand = new SqlCommand("SELECT * FROM park JOIN park_state ON park_state.park_id = park.park_id WHERE state_abbreviation = @state_abbreviation", parkConnection);
                //build a sql query to do what you want aka in this case get parks by state
                //SELECT statement still needs the JOIN if you make to combine 2 tables together 

                parkCommand.Parameters.AddWithValue("@state_abbreviation", stateAbbreviation);
                //add the parameter of stateAbbreviation with the value from @state_abbreviation
                //second value is passed in from the method

                SqlDataReader reader = parkCommand.ExecuteReader();
                //create the new instance of reader for the park command

                //create park object(s) from the data coming back from the reader
                while (reader.Read())
                {
                    Park park = CreateParkFromReader(reader);
                    //instantiate park
                    parks.Add(park);
                    //add the current park to the park list
                }
            }
            return parks;
            //return the parks list
            
        }

        public Park CreatePark(Park park)
        {
            //return a park
            //take in park object 


            throw new NotImplementedException();
        }

        public void UpdatePark(Park park)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE park SET park_name = @park_name, date_established = @date_established, area = @area, has_camping = @has_camping WHERE park_id = @park_id", conn);
                cmd.Parameters.AddWithValue("@park_name", park);


                

                    
            }
            throw new NotImplementedException();
        }

        public void DeletePark(int parkId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand("DELETE FROM park_state WHERE park_id = @park_id", conn);
                cmd1.Parameters.AddWithValue("@park_id", parkId);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("DELETE FROM park WHERE park_id = @park_id", conn);
                cmd.Parameters.AddWithValue("@park_id", parkId);
                

                //no need to execute anything, no results expected
                cmd.ExecuteNonQuery();
            }
            
        }

        public void AddParkToState(int parkId, string state_abbreviation)
            //do not need data back out hence the void return type
            

        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO park_state(park_id, state_abbreviation) VALUES (@park_id, state_abbreviation)", conn);
                cmd.Parameters.AddWithValue("@park_id", parkId);
                cmd.Parameters.AddWithValue("@state_abbreviation", state_abbreviation);

                //no need to execute anything, no results expected
                cmd.ExecuteNonQuery();

            }
               
        }

        public void RemoveParkFromState(int parkId, string state_abbreviation)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM park_state WHERE park_id = @park_id AND state_abbreviation = @state_abbreviation", conn);
                cmd.Parameters.AddWithValue("@park_id", parkId);
                cmd.Parameters.AddWithValue("@state_abbreviation", state_abbreviation);

                //no need to execute anything, no results expected
                cmd.ExecuteNonQuery();
            }

                //DELETE FROM park_state WHERE park_id = @park_id

                
        }

        private Park CreateParkFromReader(SqlDataReader reader) //make a park object out of a row of sql data
        {
            Park park = new Park();
            park.ParkId = Convert.ToInt32(reader["park_id"]);
            //reader: row of data
            //"park_id": column name
            park.ParkName = Convert.ToString(reader["park_name"]);
            park.DateEstablished = Convert.ToDateTime(reader["date_established"]);
            park.Area = Convert.ToDecimal(reader["area"]);
            park.HasCamping = Convert.ToBoolean(reader["has_camping"]);

            return park;
        }
    }
}
