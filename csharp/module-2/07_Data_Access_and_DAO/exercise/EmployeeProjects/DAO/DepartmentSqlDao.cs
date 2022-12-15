using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class DepartmentSqlDao : IDepartmentDao
    {
        private readonly string connectionString;

        public DepartmentSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Department GetDepartment(int departmentId)
        {
            Department department = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT department_id, name FROM department WHERE department_id = @department_id", conn);

                cmd.Parameters.AddWithValue("@department_id", departmentId);

                SqlDataReader departmentReader = cmd.ExecuteReader();

                if (departmentReader.Read())
                {
                    department = CreateDepartmentFromReader(departmentReader);
                }
            }

            return department;
        }

        private Department CreateDepartmentFromReader(SqlDataReader reader)
        {
            Department department = new Department();
            department.DepartmentId = Convert.ToInt32(reader["department_id"]);
            department.Name = Convert.ToString(reader["name"]);

            return department;
        }

        public IList<Department> GetAllDepartments()
        {
            IList<Department> departments = new List<Department>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM department", conn);
              // cmd.Parameters.AddWithValue("@name", name);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Department department = CreateDepartmentFromReader(reader);
                    departments.Add(department);
                }
            }

            return departments;

        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE department SET  name = @name WHERE department_id = @department_id", conn);
                cmd.Parameters.AddWithValue("@department_id", updatedDepartment.DepartmentId);
                cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);

                cmd.ExecuteNonQuery();
            }
        }

        //public void UpdateCity(City city)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand("UPDATE city SET city_name = @city_name, state_abbreviation = @state_abbreviation, population = @population, area = @area WHERE city_id = @city_id;", conn);
        //        cmd.Parameters.AddWithValue("@city_name", city.CityName);
        //        cmd.Parameters.AddWithValue("@state_abbreviation", city.StateAbbreviation);
        //        cmd.Parameters.AddWithValue("@population", city.Population);
        //        cmd.Parameters.AddWithValue("@area", city.Area);
        //        cmd.Parameters.AddWithValue("@city_id", city.CityId);

        //        cmd.ExecuteNonQuery();
        //    }
        //}


    }

   
}
