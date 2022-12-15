using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Just when you thought it was safe to get back in the water --- Last2Revisited!!!!
         *
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1.
         *
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.
         *
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *
         * Last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         *
         */
        public Dictionary<string, int> Last2Revisited(string[] words)
        {
            //make a dict
            Dictionary<string, int> newDictionary = new Dictionary<string, int>();

            foreach (string word in words) //loop through each word in words
            {
                newDictionary[word] = 0; //create a value for the current word in the dict
                var stringToMatch = word.Substring(word.Length - 2); //set a variable to the substring of the last 2 characters, ex. hi

                for (int i = 0; i < word.Length - 2; i++) //iterate through the loop without the last 2 values
                {
                    if (word.Substring(i, 2).Contains(stringToMatch)) //if they match add 1 to the value of the word in dictionary
                    {
                        newDictionary[word] += 1;
                    }
                }
            }
            return newDictionary;
        }
    }
}
