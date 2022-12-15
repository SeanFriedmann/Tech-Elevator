namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Count the number of "xx" in the given string. Overlapping is allowed, so "xxx" contains 2 "xx".
        CountXX("abcxx") → 1
        CountXX("xxx") → 2
        CountXX("xxxx") → 3
        */
        public int CountXX(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'x' && str[i + 1] == 'x')
                {

                    counter++;
                }
            }
            return counter ;
        }
    }
}
