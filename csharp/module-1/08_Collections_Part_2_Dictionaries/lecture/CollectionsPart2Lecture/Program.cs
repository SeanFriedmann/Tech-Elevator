using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			/* list<string> reviews = new list<string>();
			 * 
			 * for (nt i = 0; i <Reviews.count; i++)
			 * {
			 * if (reviews[i].Contains("David")
			 * {reviews.removeAt(i);, removing items in lists sets index item 1 to index 0 :(
			 * i = i -1;
			 * 
			 * foreach (review in reviews), no access to index
			 * {
			 * cwtabtab (review)
			 */

			/*Dictionaries: collection that stores objects
			 * NOT ordered
			 * store data in a key-value pair
			 * values are retrieved by using the key
			 * values can have duplicates(synonym)
			 * keys cannot have duplicates
			 * needs to be the same data type
			 * 
			 * key: how to access data
			 * value: stuff you care about, what youre looking for
			 * replaces index with the keyword
			 */

			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

			//declaring a dictionary
			Dictionary<string, string> nameToZip = new Dictionary<string, string>();

			//add item to dictionary
			nameToZip["David"] = "44120"; //use key to set a value
										  //nameToZip.Add("David", "44170"); //will throw exception if key already exists
			nameToZip["David"] = "44170"; //updating if key already exists

			nameToZip["Tori"] = "44102";
			nameToZip["Ben"] = "44124";
			

			//retrieve values from dictionary
			Console.WriteLine("David lives in " + nameToZip["David"]);

			//retrieve just the keys
			//key type should match dictionary key type
			IEnumerable<string> keys = nameToZip.Keys; //returns a collection of all keys in the dictionary
													   //IEnumberable: collection you can loop over
			//does not require new keyword because the data is already present in the code

			foreach(string keyName in keys) //key: name of my choosing, variable name
            {

                Console.WriteLine(keyName + " lives in " + nameToZip[keyName]);
            }
			//cannot really change iteration type, ex. skip every other key/value
			//nameToZip.Keys: returns David, Tori, Ben: just key names

			if (nameToZip.ContainsKey("David"))
            {
				Console.WriteLine("David exists");
            }
			if (nameToZip.ContainsKey("Gandalf"))
			{
				Console.WriteLine("Gandalf exists"); //will not write because it does not exist
			}

			//update david zip to be "12345"
			nameToZip["David"] = "12345";
            Console.WriteLine(nameToZip["David"]);

			foreach(KeyValuePair<string, string> nameZip in nameToZip) //will return the key value pair collection
            {
                Console.WriteLine(nameZip.Key + " liveth in " + nameZip.Value);
            }

			//remove something
			nameToZip.Remove("David");
            Console.WriteLine("removed david.");
            foreach(KeyValuePair<string, string> nameZip in nameToZip)
            {
                Console.WriteLine($"Key: {nameZip.Key}, Value: {nameZip.Value}");
            }

			IEnumerable<string> values = nameToZip.Values;
			//foreach(string valueNames in values)
   //         {
   //             Console.WriteLine("Values: " + nameToZip[valueNames]);
   //         }

			Console.WriteLine(nameToZip); //will get weird output
            Console.WriteLine(nameToZip.Keys); //not proper output

			//initialize a dictionary using the initializer 
			Dictionary<string, string> studentNames = new Dictionary<string, string>()
			{
				{"Tracy", "Barry" },
				{"Colin", "Detwiller" },
				{"Kim", "Barry" },
				{"Maria G", "Garcia" },
				{"Amy", "Drapac" },
				{"Ben", "Measor" },
				{"Joe", "Gibson" },
				{"Alex", "Hewson" }
			};

			//debugging
			if(nameToZip.Count < 3) //code will stop because of this breakpoint, can show current iteration, whether the value is true or not
				//step over: go to next line
            {
                Console.WriteLine("name to zip dictionary is small");
            }
            else
            {
                Console.WriteLine("name to zip is not small");
            }

			foreach(KeyValuePair<string,string> student in studentNames) //use key value pair to return both key and value
            {
                Console.WriteLine("Key: " + student.Key);
                Console.WriteLine("Value: " + student.Value);
            }

		}
	}
}
