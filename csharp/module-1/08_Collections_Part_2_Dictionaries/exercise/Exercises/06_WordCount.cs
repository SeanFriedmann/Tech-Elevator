using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {

            int counter = 0;
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (myDictionary.ContainsKey(word)) //apears multiple times
                {
                    myDictionary[word]++;
                }
                else
                { myDictionary[word] = 1; }
                
                
            }
            //for (int i = 0; i < words.Length; i++)
            //{


            //    //if (words[i] = ))
            //    if (myDictionary.ContainsKey(words[i]) == false) //apears multiple times
            //    {

            //        myDictionary[words[i]] = 1;
            //    }
            //    if ((myDictionary.ContainsKey(words[i]) == true))
            //    {
            //        myDictionary[words[i]] += 1;
            //    }



            return myDictionary;
        }
    }
}
                

           
        

