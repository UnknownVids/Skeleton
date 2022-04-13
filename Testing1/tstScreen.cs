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
        public void IDPropertyOK()
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
        public void NamePropertyOK()
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
            Screen.ScreenCapacity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.ScreenCapacity, TestData);
        }

        [TestMethod]
        public void ScreenListSelectOK()
        {
            // Create the screen management list
            clsScreenManagement ScreenList = new clsScreenManagement();

            // Create some test data
            clsScreen TestScreen = new clsScreen();

            //create some test data to assign to the property
            TestScreen.ScreenID = 5;
            TestScreen.ScreenCapacity = 50;
            TestScreen.ScreenName = "Test Name";

            ScreenList.SelectedScreen = TestScreen;

            //test to see that the two values are the same
            Assert.AreEqual(ScreenList.SelectedScreen, TestScreen);
        }

    }
}
