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
            TestItem.AdsBeforeMovie = 15;
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
            TestScreen.AdsBeforeMovie = 15;
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
            TestItem.AdsBeforeMovie = 15;
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
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //create the item of test data
            clsScreen TestItem = new clsScreen();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.AdsBeforeMovie = 17;
            TestItem.Capacity = "135";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.ScreenBeingUsed = true;
            TestItem.ScreenName = "Theatre 10";
            //set ThisScreen to the test data
            AllScreens.ThisScreen = TestItem;
            //add the record
            PrimaryKey = AllScreens.Add();
            //set the primary key of the test data
            TestItem.ScreenID = PrimaryKey;
            //find the record
            AllScreens.ThisScreen.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllScreens.ThisScreen, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //create the item of test data
            clsScreen TestItem = new clsScreen();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AdsBeforeMovie = 15;
            TestItem.Capacity = "100";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.ScreenBeingUsed = true;
            TestItem.ScreenName = "IMAX 1";
            //set ThisScreen to the test data
            AllScreens.ThisScreen = TestItem;
            //add the record
            PrimaryKey = AllScreens.Add();
            //set the primary key of the test data
            TestItem.ScreenID = PrimaryKey;
            //modify the test data
            TestItem.AdsBeforeMovie = 20;
            TestItem.Capacity = "127";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.ScreenBeingUsed = false;
            TestItem.ScreenName = "General";
            //set the record based on the new test data
            AllScreens.ThisScreen = TestItem;
            //update the record
            AllScreens.Update();
            //find the record
            AllScreens.ThisScreen.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllScreens.ThisScreen, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //create the item of test data
            clsScreen TestItem = new clsScreen();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.AdsBeforeMovie = 17;
            TestItem.Capacity = "135";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.ScreenBeingUsed = true;
            TestItem.ScreenName = "Theatre 10";
            //set ThisScreen to the test data
            AllScreens.ThisScreen = TestItem;
            //add the record
            PrimaryKey = AllScreens.Add();
            //set the primary key of the test data
            TestItem.ScreenID = PrimaryKey;
            //delete the record
            AllScreens.Delete();
            //now find the record
            Boolean Found = AllScreens.ThisScreen.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCapacityMethodOK()
        {
            //create an instance of the class containg unfiltered results
            clsScreenCollection AllScreens = new clsScreenCollection();
            //create an instance of the filtered data
            clsScreenCollection FilteredScreens = new clsScreenCollection();
            //apply a blank string (should return all records);
            FilteredScreens.ReportByCapacity("");
            //test to see that the two values are the same
            Assert.AreEqual(AllScreens.Count, FilteredScreens.Count);
        }
        [TestMethod]
        public void ReportByCapacityNoneFound()
        {
            //create an instance of the filtered data
            clsScreenCollection FilteredScreens = new clsScreenCollection();
            //apply a blank string (should return all records);
            FilteredScreens.ReportByCapacity("xx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredScreens.Count);
        }
        [TestMethod]
        public void ReportByCapacityTestDataFound()
        {
            //create an instance of the filtered data
            clsScreenCollection FilteredScreens = new clsScreenCollection();
            //var to store outcome
            Boolean OK = true;
            //aply a capacity that doesn't exist
            FilteredScreens.ReportByCapacity("250");
            //check that the correct number of records are found
            if(FilteredScreens.Count == 2)
            {
                //check that the first record is ID 8
                if (FilteredScreens.ScreenList[0].ScreenID != 3)
                {
                    OK = false;
                }
                //check that the first record is ID 9
                if (FilteredScreens.ScreenList[1].ScreenID != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}


