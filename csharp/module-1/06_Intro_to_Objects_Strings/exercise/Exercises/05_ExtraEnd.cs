﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a new string made of 3 copies of the last 2 chars of the original string. The string
        length will be at least 2.
        ExtraEnd("Hello") → "lololo"
        ExtraEnd("ab") → "ababab"
        ExtraEnd("Hi") → "HiHiHi"
        */
        public string ExtraEnd(string str)
        {
            string secondLast = str.Substring(str.Length - 2, 1);
            string lastLast = str.Substring(str.Length - 1);
            return secondLast + lastLast + secondLast + lastLast + secondLast + lastLast;
        }
    }
}
