using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of Integers, return a List of Integers containing just the odd values.
        OddOnly( {112, 201, 774, 92, 9, 83, 41872} ) -> [201, 9, 83]
        OddOnly( {1143, 555, 7, 1772, 9953, 643} ) -> [1143, 555, 7, 9953, 643]
        OddOnly( {734, 233, 782, 811, 3, 9999} ) -> [233, 811, 3, 9999]
        */
        public List<int> OddOnly(int[] integerArray)
        {
            List<int> integerList = new List<int>(integerArray);
            List<int> newList = new List<int>();
            for (int i = 0; i < integerList.Count; i++)
            {
                if (integerList[i] % 2 != 0)
                {
                    newList.Add(integerList[i]);
                }
            }
            return newList;
        }
    }
}
