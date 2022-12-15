using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [DataTestMethod]
        [DataRow(50, false, true)]
        [DataRow(40, false, true)]
        [DataRow(70, false, false)]
        [DataRow(70, true, true)]

        public void HavePartyTest(int cigar, bool isWeekend, bool expectedResult)
        {
            /*
        When squirrels get together for a party, they like to have cigars. A squirrel party is successful
        when the number of cigars is between 40 and 60, inclusive. Unless it is the weekend, in which case
        there is no upper bound on the number of cigars. Return true if the party with the given values is
        successful, or false otherwise.
        haveParty(30, false) → false
        haveParty(50, false) → true
        haveParty(70, true) → true
        */
            //public bool HaveParty(int cigars, bool isWeekend)
            //{
            //    const int MinimumCigarCount = 40;
            //    const int MaximumCigarCount = 60;

            //    bool hasMinimumCigars = (cigars >= MinimumCigarCount);
            //    bool withinMaxRangeOfCigars = (!isWeekend && cigars <= MaximumCigarCount) || isWeekend;
            //    bool successful = hasMinimumCigars && withinMaxRangeOfCigars;

            //    return successful;
            //}
            //Arrange

            
           
            CigarParty cigarParty = new CigarParty();

            //int firstInput = 30;
            //bool secondInput = false;

           // bool result = cigarParty.HaveParty(cigars, isWeekend);
            bool result2 = cigarParty.HaveParty(cigar, isWeekend);

            Assert.AreEqual(expectedResult, result2);



        }
    }
}
