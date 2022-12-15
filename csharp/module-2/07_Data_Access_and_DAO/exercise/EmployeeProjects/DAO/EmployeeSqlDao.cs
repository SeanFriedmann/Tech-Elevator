using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class EmployeeSqlDao : IEmployeeDao
    {
        private readonly string connectionString;

        public EmployeeSqlDao(string connString)
        {
            connectionString = connString;
        }

        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM employee", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }
            }
            return employees;

        }

        //public IList<Department> GetAllDepartments()
        //{
        //    IList<Department> departments = new List<Department>();

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM department", conn);
        //        // cmd.Parameters.AddWithValue("@name", name);

        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Department department = CreateDepartmentFromReader(reader);
        //            departments.Add(department);
        //        }
        //    }

        //    return departments;

        //}

        public IList<Employee> SearchEmployeesByName(string firstNameSearch, string lastNameSearch)
        {
            IList<Employee> searchList = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;

                if ((firstNameSearch == "" || firstNameSearch == null) && (lastNameSearch == "" || lastNameSearch == null))
                {
                    cmd = new SqlCommand("SELECT * FROM employee", conn);
                }
                if (firstNameSearch == "" || firstNameSearch == null)
                {
                    cmd = new SqlCommand("SELECT * FROM employee WHERE last_name LIKE @lastNameSearch", conn);
                    string lastName = ("%" + lastNameSearch + "%");
                    cmd.Parameters.AddWithValue("@lastNameSearch", lastName);

                }
                if (lastNameSearch == "" || firstNameSearch == null)
                {
                    cmd = new SqlCommand("SELECT * FROM employee WHERE first_name LIKE @firstNameSearch", conn);
                    string firstName = ("%" + firstNameSearch + "%");
                    cmd.Parameters.AddWithValue("@firstNameSearch", firstName);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM employee WHERE first_name LIKE @firstNameSearch AND last_name LIKE @lastNameSearch", conn);
                    string firstName = ("%" + firstNameSearch + "%");
                    cmd.Parameters.AddWithValue("@firstNameSearch", firstName);
                    string lastName = ("%" + lastNameSearch + "%");
                    cmd.Parameters.AddWithValue("@lastNameSearch", lastName);

                }

                

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    searchList.Add(employee);
                }
            }

            return searchList;
        }

        public IList<Employee> GetEmployeesByProjectId(int projectId)
        {
            IList<Employee> employeesByProjectId = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM employee JOIN project_employee ON employee.employee_id = project_employee.employee_id WHERE project_id = @project_id", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employeesByProjectId.Add(employee);
                }
            }

            return employeesByProjectId;
        }

        public void AddEmployeeToProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO project_employee(project_id, employee_id) " + "VALUES(@project_id, @employee_id);", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
                cmd.Parameters.AddWithValue("@employee_id", employeeId);

                cmd.ExecuteReader();

              
            }
        }

        public void RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM project_employee WHERE project_id = @project_id AND employee_id = @employee_id;", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
                //cmd.ExecuteNonQuery();
               // SqlCommand cmd1 = new SqlCommand("DELETE FROM project_employee WHERE employee_id = @employee_id;", conn);
                cmd.Parameters.AddWithValue("@employee_id", employeeId);

                cmd.ExecuteNonQuery();


            }
        }

        public IList<Employee> GetEmployeesWithoutProjects()
        {
            IList<Employee> employeesWithoutProjects = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM employee LEFT JOIN project_employee ON employee.employee_id = project_employee.employee_id WHERE project_id IS NULL; ", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employeesWithoutProjects.Add(employee);
                }

            }
            return employeesWithoutProjects;
        }

        private Employee CreateEmployeeFromReader(SqlDataReader reader)
        {
            Employee employee = new Employee();
            employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
            employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
            employee.FirstName = Convert.ToString(reader["first_name"]);
            employee.LastName = Convert.ToString(reader["last_name"]);
            employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
            employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

            return employee;
        }



        //private Department CreateDepartmentFromReader(SqlDataReader reader)
        //{
        //    Department department = new Department();
        //    department.DepartmentId = Convert.ToInt32(reader["department_id"]);
        //    department.Name = Convert.ToString(reader["name"]);

        //    return department;
        //}

    }
}
