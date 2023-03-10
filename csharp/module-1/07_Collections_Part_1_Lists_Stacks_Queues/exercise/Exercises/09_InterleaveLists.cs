using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> newList = new List<int>();
            //for (int i =0; i < listOne.Count; i++)
            {
                if (listOne.Count == listTwo.Count)
                    for (int i = 0; i < listOne.Count; i++)
                    {
                        newList.Add(listOne[i]);
                        newList.Add(listTwo[i]);
                        Console.WriteLine(newList);//cw will not show up in test, use debug instead
                    }
                if (listOne.Count > listTwo.Count)
                {
                    for (int i = 0; i < listOne.Count; i++)
                    {
                        //newList.Add(listOne[i]);
                        //newList.Add(listTwo[i]);
                        newList.Add(listOne[listOne.Count - listTwo.Count]);
                    }
                      
                }
                if (listTwo.Count > listOne.Count)
                {
                    for (int i = 0; i < listTwo.Count; i++)
                    {
                        //newList.Add(listOne[i]);
                        //newList.Add(listTwo[i]);
                        newList.Add(listTwo[listTwo.Count - listOne.Count]);
                    }
                }
            }
            return newList;
        }
    }
}
