using System;
using System.Collections.Generic;

namespace TEams
{
    class Program
    {
        List<Department> departments = new List<Department>();
        List<Employee> employees = new List<Employee>();
        Dictionary<string, Project> projects = new Dictionary<string, Project>();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {

            // create some departments
            CreateDepartments();

            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!


            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private void CreateDepartments()
        {
            Department Marketing = new Department(1, "Marketing");
            Department Sales = new Department(2, "Sales");
            Department Engineering = new Department(3, "Engineering");
            departments.Add(Marketing);
            departments.Add(Sales);
            departments.Add(Engineering);
        }

        /**
         * Print out each department in the collection.
         */
        private void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            for (int i = 0; i < departments.Count; i++)
            {
                Console.WriteLine($"{departments[i].Name}");
            }
        }

        /**
         * Create employees and add them to the collection of employees
         */

        private void CreateEmployees()
        {

            //Employee dean = new Employee(1, "Dean", "Johnson", "djohnson@teams.com", departments[2], "08/21/2020");
            Employee dean = new Employee();
            dean.EmployeeId = 1;
            dean.FirstName = "Dean";
            dean.LastName = "Johnson";
            dean.Email = "djohnson@teams.com";
            dean.Department = departments[2];
            dean.HireDate = "08/21/2020";
            Employee angie = new Employee(2, "Angie", "Smith", "asmith@teams.com", departments[2], "08/21/2020");
            Employee margaret = new Employee(3, "Margaret", "Thompson", "mthompson@teams.com", departments[0], "08/21/2020");
            employees.Add(dean);
            employees.Add(angie);
            employees.Add(margaret);

            
            employees[1].RaiseSalary(10);

        }
        //public double RaiseSalary(double percent)
        //{
        //    return employees[1].Salary * (1 + 10;
        //}
        //employees[1].Salary = Employee.RaiseSalary(10);
        /**
         * Print out each employee in the collection.
         */


        private void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].FullName} ({employees[i].Salary}) {employees[i].Department.Name}");
            }
        }

        /**
         * Create the 'TEams' project.
         */
        private void CreateTeamsProject()
        {
            //projects.Add("TEams", "Project Management Software", "10/10/2020", "11/10/2020");
            Project TEams = new Project("TEams", "Project Management Software", "10/10/2020", "11/10/2020");
            //projects["TEams"].TeamMembers dean2 = new projects["TEams"].TeamMembers;
            projects["TEams"] = TEams;
            TEams.TeamMembers.Add(employees[0]);
            TEams.TeamMembers.Add(employees[1]);
        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private void CreateLandingPageProject()
        {
            Project MarketLandingPage = new Project("Market Landing Page", "Lead Capture Landing Page for Marketing", "10/10/2020", "10/17/2020");
            projects["MarketLandingPage"] = MarketLandingPage;
            MarketLandingPage.TeamMembers.Add(employees[2]);

            //MarketLandingPage.TeamMembers[MarketLandingPage]
        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");
            
            foreach (var project in projects)
            {
                Console.WriteLine($"{project.Key}: {project.Value.TeamMembers.Count}");
            }
            
        }
    }
}
