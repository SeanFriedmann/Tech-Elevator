using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetMod1PracticeProblems
{
    public class Conditionals
    {
        /*
	     The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on
	     vacation. We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in.
	     SleepIn(false, false) → true
	     SleepIn(true, false) → false
	     SleepIn(false, true) → true
	     */
        public bool SleepIn(bool weekday, bool vacation)
        {
            if (weekday == false || vacation == true)
            {
                return true;
            }
            return false;
        }

        /*
         Given two int values, return their sum. Unless the two values are the same, then return double their sum.
         SumDouble(1, 2) → 3
         SumDouble(3, 2) → 5
         SumDouble(2, 2) → 8
         */
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return (a + b) * 2;
            }
            else
            {
                return a + b;
            }
            return 0;
        }

        /*
       Given two temperatures, return true if one is less than 0 and the other is greater than 100.
       IcyHot(120, -1) → true
       IcyHot(-1, 120) → true
       IcyHot(2, 120) → false
       */
        public bool IcyHot(int temp1, int temp2)
        {
            if (temp1 < 0 && temp2 > 100)
            {
                return true;
            }
            if (temp2 < 0 && temp1 > 100){
                return true;
            }
            return false;
        }

        /*
         When squirrels get together for a party, they like to have cigars. A squirrel party is successful
         when the number of cigars is between 40 and 60, inclusive. Unless it is the weekend, in which case
         there is no upper bound on the number of cigars. Return true if the party with the given values is
         successful, or false otherwise.
         CigarParty(30, false) → false
         CigarParty(50, false) → true
         CigarParty(70, true) → true
         */
        public bool CigarParty(int cigars, bool isWeekend)
        {
            if (cigars > 40 && cigars < 60 && isWeekend == false)
            {
                return true;
            }
            else if (cigars < 40)
            {
                return false;
            }
            else if (cigars > 60 && isWeekend == false)
            {
                return false;
            }
            else if (cigars > 40 && isWeekend == true)
            {
                return true;
            }
            return false;
        }

        /*
         We are having a party with amounts of tea and candy. Return the int outcome of the party encoded as
         0=bad, 1=good, or 2=great. A party is good (1) if both tea and candy are at least 5. However, if
         either tea or candy is at least double the amount of the other one, the party is great (2). However,
         in all cases, if either tea or candy is less than 5, the party is always bad (0).
         TeaParty(6, 8) → 1
         TeaParty(3, 8) → 0
         TeaParty(20, 6) → 2
         */
        public int TeaParty(int tea, int candy)
        {
            if (tea < 5 || candy < 5)
            {
                return 0;
            }
           else  if (tea >=5 && candy >= 5 && tea / candy >= 2)
            {
                return 2;
            }
            else if (tea >= 5 && candy >= 5 && candy / tea >= 2)
            {
                return 2;
            }
            else if (tea >= 5 && candy >= 5)
            {
                return 1;
            }
            else return 0;
        }

        /*
        Your cell phone rings. Return true if you should answer it. Normally you answer, except in the morning
        you only answer if it is your mom calling. In all cases, if you are asleep, you do not answer.
        AnswerCell(false, false, false) → true
        AnswerCell(false, false, true) → false
        AnswerCell(true, false, false) → false
        */
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isMorning == true && isMom == true && isAsleep == false)
            {
                return true;
            }
            else if (isMorning == true && isMom == false && isAsleep == false)
            {
                return false;
            }
            else if (isAsleep == true)
            {
                return false;
            }
            else if (isMorning == false && isAsleep == false && isAsleep == false)
            {
                return true;
            }
            return false;
        }

    }
}
