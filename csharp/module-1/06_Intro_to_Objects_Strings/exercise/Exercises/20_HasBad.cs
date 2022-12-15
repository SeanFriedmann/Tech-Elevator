namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with
        "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0. Note: use .equals()
        to compare 2 strings.
        HasBad("badxx") → true
        HasBad("xbadxx") → true
        HasBad("xxbadxx") → false
        */
        public bool HasBad(string str)
        {
            
            if (str.Length < 3)
            {
                return false;
            }
            string firstThree = str.Substring(0, 3);
           
            if (firstThree.Contains("bad") == true)
            {

                return true;
            }
            if (str.Length < 4)
            {
                return false;   
            }
            string firstFour = str.Substring(1, 3);
            if (firstFour.Contains("bad") == true)
            {
                return true;
            }

            return false;
        }
    }
}
