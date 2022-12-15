using System;
using System.Collections.Generic;
using System.Text;


namespace PetElevator.CRM
{
    public class Pet
    {

        public string PetName { get; set; }
        public string Species { get; set; }
        public List<string> Vaccinations { get; set; } = new List<string>() { "Rabies, Distemper, Parvo" };
        string listVaccinationOutput = "";

        public Pet(string petName, string species)
        {
            PetName = petName;
            Species = species;

        }
        public string ListVaccinations()
        {
            string output = "";
            foreach (string vaccination in Vaccinations)
            {
                //string tempOutput = Vaccinations.ToString();
                //listVaccinationOutput = string.Join(",", tempOutput);
                output += vaccination;

            }
            return output;
            //string output = "";
            //for (int i = 1; i < Vaccinations.Count; i++)
            //{
            //    output = $"{i},";
            //}
            //return output;
        }


    }
}
