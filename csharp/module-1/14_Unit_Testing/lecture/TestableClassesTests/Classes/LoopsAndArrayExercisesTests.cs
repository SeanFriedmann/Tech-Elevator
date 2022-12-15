using Microsoft.VisualStudio.TestTools.UnitTesting;
//needed for unit testing

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    //attribute
    //[TestClass]: signifies this is a class of automated tests
    //Run all tests button looks for classes with the [TestClass] attribute in them

    //[TestMethod]: signifies a method that does tests
    //
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert: meant for arrays
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object

        [TestMethod]
        public void MiddleWayTest() //setup test method, this is considered a test
            //returning nothing outside of method
            //give no parameters, give manual input to test certain scenarios

        {

            /*
       Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle
       elements.
       middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
       middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
       middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
       */
            //arrange
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises(); //create new instance

            int[] firstInput = { 1, 2, 3 }; //set input 1
            int[] secondInput = { 4, 5, 6 }; //set input 2

            //act
            int[] actualResult = loopsAndArrayExercises.MiddleWay(firstInput, secondInput); //set result

            //assert
            int[] expectedResult = { 2, 5 };
            CollectionAssert.AreEqual(expectedResult, actualResult); //tests if two values are equal to eachother, expcected then actual

            //lets do it again
            //Arrange
            int[] thirdInput = { 7, 7, 7 };
            int[] fourthInput = { 3, 8, 0 };

            //Act
            int[] secondActualResults = loopsAndArrayExercises.MiddleWay(thirdInput, fourthInput);

            //Assert
            int[] secondExpectedResult = { 7, 8 };
            CollectionAssert.AreEqual(secondExpectedResult, secondActualResults); //be careful about choosing the correct variables
            //CollectionAssert.AreNotEqual(secondExpectedResult, secondActualResults); throws exception if the values are the same
            CollectionAssert.AllItemsAreNotNull(secondActualResults);

            //3 parts to a unit test
            //1: Arrange: etup
            //2: Act: actually run the test
            //3: Assert: seeing if it runs correctly
        }

        public void MaxEnd3Test()
        {
            /*
            Given an array of ints length 3, figure out which is larger between the first and last elements
            in the array, and set all the other elements to be that value. Return the changed array.
            maxEnd3([1, 2, 3]) → [3, 3, 3]
            maxEnd3([11, 5, 9]) → [11, 11, 11]
            maxEnd3([2, 11, 3]) → [3, 3, 3]
            */

            //Arrange
            int[] arrayOne = { 1, 2, 3 };

            //Act
            //int currentHigh;
            //for(int i =0; i < arrayOne.Length; i++)
            //{
                
            //}


        }
    }
}