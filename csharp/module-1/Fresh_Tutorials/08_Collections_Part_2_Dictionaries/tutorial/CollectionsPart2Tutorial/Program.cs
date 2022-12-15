using System;
using System.Collections.Generic;

namespace CollectionsPart2Tutorial
{
    public class CollectionsPart2Tutorial
    {
        static void Main(string[] args)
        {

            // Step One: Declare a Dictionary
            Dictionary<string, decimal> theDictionary = new Dictionary<string, decimal>();



            // Step Two: Add items to a Dictionary
            theDictionary.Add("20", 2.0M);
            theDictionary["10"] = 5.0M;
            theDictionary.Add("30", 4.0M);


            // Step Three: Loop through a Dictionary
            foreach(KeyValuePair<string, decimal> Sceneeee in theDictionary)
            {
                Console.WriteLine(Sceneeee.Value);
            }



        }
    }
}
