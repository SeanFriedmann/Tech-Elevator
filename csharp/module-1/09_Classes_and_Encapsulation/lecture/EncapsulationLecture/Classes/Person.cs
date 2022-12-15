using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.Classes
{
    public class Person
    {
        //name
        public string Name { get; set; }
        //get; set; : property of the class
        //age
        //based on birthyear compared to the current date
        public int Age
        {
            //derived property - only get = readonly.
            get
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - birthYear;
            }
        }
        private int birthYear { get; set; }

        //height
        public double Height { get; set; }
        //public is PascalCase
        //private is camelCase

        //SSN
        private string ssn { get; set; }

        //Constructor, public <ClassName>() {....}, build object of this class
        //once a constructor is defined the default no-argument constructor is not available
        public Person(int yearOfBirth)//will allow you to set the year of birth of person in program.cs call
        {

        }

        //manually add no arg constructor
        public Person()
        {

        }
    }
}
