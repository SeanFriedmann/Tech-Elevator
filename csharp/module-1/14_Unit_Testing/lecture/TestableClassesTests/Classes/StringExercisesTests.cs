using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class StringExercisesTests
    {
        //Assert: singular value
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object, point to same object in memory, as opposed to the same value
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        [TestMethod]//attribute to test a method
        public void MakeAbbaTest() //public to be displayed to all code, do not need to return anything, method name test
        {
            //Arrange
            StringExercises stringExercises = new StringExercises(); //create a new stringExercise object (create dependency as well)
                          //setup actual connection to exercise                                           //string stringOne = "Hi";
                                                                     //string stringTwo = "Bye";
            string result = stringExercises.MakeAbba("Hi", "Bye");

            //Assert
            Assert.AreEqual("HiByeByeHi", result);

        }




        [TestMethod]
        public void MakeAbbaTestKnownFailure()
        {
            //Arrange
            StringExercises stringExercises = new StringExercises();
            //Act
            string resultTwo = stringExercises.MakeAbba("What", "Up");

        //Asser
        Assert.AreEqual("UpWhatWhatUp", resultTwo, "Please try again"); //this fails but gives user feedback in the test explorer
        }
        /*
        Given two strings, a and b, return the result of putting them together in the order abba,
        e.g. "Hi" and "Bye" returns "HiByeByeHi".
        makeAbba("Hi", "Bye") → "HiByeByeHi"
        makeAbba("Yo", "Alice") → "YoAliceAliceYo"
        makeAbba("What", "Up") → "WhatUpUpWhat"
        */

    }
}