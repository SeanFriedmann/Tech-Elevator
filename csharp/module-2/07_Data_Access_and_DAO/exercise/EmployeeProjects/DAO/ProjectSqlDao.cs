using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class ProjectSqlDao : IProjectDao
    {
        private readonly string connectionString;

        public ProjectSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Project GetProject(int projectId)
        {
            Project project = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT project_id, name, from_date, to_date FROM project WHERE project_id = @project_id", conn);

                cmd.Parameters.AddWithValue("@project_id", projectId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    project = CreateProjectFromReader(reader);
                }
            }

            return project;
        }

        private Project CreateProjectFromReader(SqlDataReader reader)
        {
            Project project = new Project();
            project.ProjectId= Convert.ToInt32(reader["project_id"]);
            project.Name = Convert.ToString(reader["name"]);
            project.FromDate = Convert.ToDateTime(reader["from_date"]);
            project.ToDate = Convert.ToDateTime(reader["to_date"]);

            return project;
        }

        public IList<Project> GetAllProjects()
        {
            IList<Project> projects = new List<Project>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM project", conn);
                // cmd.Parameters.AddWithValue("@name", name);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Project project = CreateProjectFromReader(reader);
                    projects.Add(project);
                }
            }

            return projects;

            //return new List<Project>();
        }

        public Project CreateProject(Project newProject)
        {
            int newProjectId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO project (name, from_date, to_date) " + "OUTPUT INSERTED.project_id " +
                    "VALUES (@name, @from_date, @to_date);", conn);
                cmd.Parameters.AddWithValue("@name", newProject.Name);
                cmd.Parameters.AddWithValue("@from_date", newProject.FromDate);
                cmd.Parameters.AddWithValue("@to_date", newProject.ToDate);

                newProjectId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return GetProject(newProjectId);
        }

        //public City CreateCity(City city)
        //{
        //    int newCityId;
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand("INSERT INTO city (city_name, state_abbreviation, population, area) " +
        //                                        "OUTPUT INSERTED.city_id " +
        //                                        "VALUES (@city_name, @state_abbreviation, @population, @area);", conn);
        //        cmd.Parameters.AddWithValue("@city_name", city.CityName);
        //        cmd.Parameters.AddWithValue("@state_abbreviation", city.StateAbbreviation);
        //        cmd.Parameters.AddWithValue("@population", city.Population);
        //        cmd.Parameters.AddWithValue("@area", city.Area);

        //        newCityId = Convert.ToInt32(cmd.ExecuteScalar());
        //    }
        //    return GetCity(newCityId);
        //}

        public void DeleteProject(int projectId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

               SqlCommand cmd1 = new SqlCommand("DELETE FROM project_employee WHERE project_id = @project_id", conn);
                cmd1.Parameters.AddWithValue("@project_id", projectId);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("DELETE FROM timesheet WHERE project_id = @project_id", conn);
                cmd2.Parameters.AddWithValue("@project_id", projectId);
                cmd2.ExecuteNonQuery();
               // SqlCommand cmd2 = new SqlCommand("ALTER TABLE project_employee DROP CONSTRAINT fk_project_employee_project WHERE project_id = @project_id", conn);
                SqlCommand cmd = new SqlCommand("DELETE FROM project WHERE project_id = @project_id", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);

                cmd.ExecuteNonQuery();
            }

            //*/
            //cmd = new SqlCommand("DELETE FROM book WHERE book_id = @book_id;", conn);
            //cmd.Parameters.AddWithValue("@book_id", book.BookId);
            //cmd.ExecuteNonQuery();

            //cmd = new SqlCommand("DELETE FROM author WHERE author_id = @author_id;", conn);
            //cmd.Parameters.AddWithValue("@author_id", author.AuthorId);
            //cmd.ExecuteNonQuery();
        }
    }

        //public void DeleteCity(int cityId)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand("DELETE FROM city WHERE city_id = @city_id;", conn);
        //        cmd.Parameters.AddWithValue("@city_id", cityId);

        //        cmd.ExecuteNonQuery();
        //    }
        //}

    }

