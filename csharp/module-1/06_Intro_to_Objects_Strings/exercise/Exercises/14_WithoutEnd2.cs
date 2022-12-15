namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version without both the first and last char of the string. The string
        may be any length, including 0.
        WithoutEnd2("Hello") → "ell"
        WithoutEnd2("abc") → "b"
        WithoutEnd2("ab") → ""
        */
        public string WithoutEnd2(string str)
        {
            string withoutFirstOrLast = "";
            if (str.Length > 2)
            {
                withoutFirstOrLast = str.Substring(1, str.Length - 2);
            }
            if (str.Length <= 2)
            {
                return "";
            }
            //else if (str.Length == 1)
            //{
            //    string nullValue = "";
            //    return nullValue;
            //}
            return withoutFirstOrLast;
        }
    }
}
