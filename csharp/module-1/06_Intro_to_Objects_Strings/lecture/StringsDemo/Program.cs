using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A 
            char firstCharacter = name[0];
            Console.WriteLine(firstCharacter);
            // Output: e
            char lastCharacter = name[name.Length - 1]; // name[^2]
            Console.WriteLine(lastCharacter);

            Console.WriteLine($"First {firstCharacter} and Last {lastCharacter} Character. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada
            string firstThree = name.Substring(0, 3); // (0, = specified character position, ,3) = specified length
            Console.WriteLine($"First 3 characters: {firstThree}");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace
            string lastThree = name.Substring((name.Length - 3), 3);

            Console.WriteLine($"First and Last 3 characters: {firstThree}{lastThree}");

            // 4. What about the last word?
            // Output: Lovelace
            string[] words = name.Split(" ");
            Console.WriteLine($"Last Word: {words[1]}");

            //string[] splitAt = name.Split("e");
            //for (int i = 0; i < splitAt.Length; i++)
            //{
            //split takes out the seperator character
            //}

            // 5. Does the string contain inside of it "Love"?
            // Output: true
            //if (name.Contains("Love") == true)
            //{ 
            //    Console.WriteLine("Contains \"Love\"");
            //}
            bool containsLove = name.Contains("Love");
            Console.WriteLine($"Contain \"Love\": {containsLove}");

            // 6. Where does the string "lace" show up in name?
            // Output: 8
            int indexOfLace = name.IndexOf("lace");
            Console.WriteLine($"Index of \"lace\": {indexOfLace} "); //escape charactaer, indicares the " is part of the string, implicit conversion, string interpolation

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int numOfA = 0;
            string lowercase = name.ToLower();
            for (int i = 0; i < name.Length; i++)
            {
                if (lowercase[i] == 'a') // =could use a double if case and not convert all values to lowercase
                {
                    numOfA++;
                }
            }
            Console.WriteLine($"Number of \"a's\": {numOfA}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
            name = name.Replace("Ada", "Ada, Countess of Lovelace");//first parameter is old value, second is new value
            Console.WriteLine(name);

            // 9. Set name equal to null. absense of value, nothing 
            name = null; //nothing to point to in the reference type (heap)

            // 10. If name is equal to null or "", print out "All Done".
            if (String.IsNullOrEmpty(name))
            //if (name == null || name == "")
            {
                Console.WriteLine("All Done");
            }
            

            Console.ReadLine();
        }
    }
}