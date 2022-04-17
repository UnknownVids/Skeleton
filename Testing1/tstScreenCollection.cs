using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstScreenCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //test to see that it exists
            Assert.IsNotNull(AllScreens);
        }
        [TestMethod]
        public void ScreenListOK()
        {
            //create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsScreen> TestList = new List<clsScreen>();
            //add an item to the list
            //create the item of test data
            clsScreen TestItem = new clsScreen();
            //set its properties
            TestItem.AdsBeforeMovie = "15";
            TestItem.Capacity = "100";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.ScreenBeingUsed = true;
            TestItem.ScreenID = 1;
            TestItem.ScreenName = "IMAX 1";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllScreens.ScreenList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllScreens.ScreenList, TestList);
        }
        [TestMethod]
        public void ThisScreenPropertyOK()
        {
            //create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //create some test data to assign to the property
            clsScreen TestScreen = new clsScreen();
            //set the properties of the test object
            TestScreen.AdsBeforeMovie = "15";
            TestScreen.Capacity = "100";
            TestScreen.DateBooked = DateTime.Now.Date;
            TestScreen.ScreenBeingUsed = true;
            TestScreen.ScreenID = 1;
            TestScreen.ScreenName = "IMAX 1";
            //assign the data to the property
            AllScreens.ThisScreen = TestScreen;
            //test to see that the two values are the same
            Assert.AreEqual(AllScreens.ThisScreen, TestScreen);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsScreen> TestList = new List<clsScreen>();
            //add an item to the list
            //create the item of test data
            clsScreen TestItem = new clsScreen();
            //set its properties
            TestItem.AdsBeforeMovie = "15";
            TestItem.Capacity = "100";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.ScreenBeingUsed = true;
            TestItem.ScreenID = 1;
            TestItem.ScreenName = "IMAX 1";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllScreens.ScreenList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllScreens.Count, TestList.Count);
        }
    }

}
