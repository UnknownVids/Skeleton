using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    /// <summary>
    /// Summary description for ScreenTest
    /// </summary>
    [TestClass]
    public class ScreenTest
    {
        public ScreenTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        // Tests to see if the class can be created and is not Null
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsScreen Screen = new clsScreen();
            //test to see that it exists
            Assert.IsNotNull(Screen);
        }

        [TestMethod]
        public void ScreenIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsScreen Screen = new clsScreen();
            //create some test data to assign to the property
            int TestData = 5;
            //assign the data to the property
            Screen.ScreenID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.ScreenID, TestData);
        }

        [TestMethod]
        public void ScreenNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsScreen Screen = new clsScreen();
            //create some test data to assign to the property
            string TestData = "Test Name";
            //assign the data to the property
            Screen.ScreenName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.ScreenName, TestData);
        }

        [TestMethod]
        public void CapacityPropertyOK()
        {
            //create an instance of the class we want to create
            clsScreen Screen = new clsScreen();
            //create some test data to assign to the property
            int TestData = 55;
            //assign the data to the property
            Screen.Capacity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.Capacity, TestData);
        }
        [TestMethod]
        public void ScreenBeingUsedOK()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //create some test data to the property
            Boolean TestData = true;
            //assign the data to the property
            AnScreen.ScreenBeingUsed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnScreen.ScreenBeingUsed, TestData);
        }
        [TestMethod]
        public void AdsBeforeMoviePropertyOK()
        {
            //create an instance of the class we want to create
            clsScreen Screen = new clsScreen();
            //create some test data to assign to the property
            int TestData = 5;
            //assign the data to the property
            Screen.AdsAfterMovie = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.AdsAfterMovie, TestData);
        }
        }
}
