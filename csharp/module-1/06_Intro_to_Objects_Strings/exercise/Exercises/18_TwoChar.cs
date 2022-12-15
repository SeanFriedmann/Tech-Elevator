﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and an index, return a string length 2 starting at the given index. If the index is
        too big or too small to define a string length 2, use the first 2 chars. The string length will be
        at least 2.
        TwoChar("java", 0) → "ja"
        TwoChar("java", 2) → "va"
        TwoChar("java", 3) → "ja"
        */
        public string TwoChar(string str, int index)
        {
            string newString = "";
            //string newStringNotTwoIndex = "";
            if (index >= str.Length -1)
            {
                string newStringNotTwoIndex = str.Substring(0, 2);
                return newStringNotTwoIndex;
            }
            if (index<0)
            {
                string newStringNotTwoIndex = str.Substring(0, 2);
                return newStringNotTwoIndex;
            }
            if (index < str.Length)
            {
                newString = str.Substring(index, 2);
            }
            return newString;

        }
    }
}
