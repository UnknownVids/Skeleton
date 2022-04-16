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
        //good test data
        //create some test data to pass the method
        string screenName = "IMAX 1";
        string capacity = "100";
        string adsBeforeMovie = "15";
        string dateBooked = DateTime.Now.Date.ToString();
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
            int TestData = 1;
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
            string TestData = "IMAX 1";
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
            int TestData = 100;
            //assign the data to the property
            Screen.Capacity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.Capacity, TestData);
        }
        [TestMethod]
        public void ScreenBeingUsedOK()
        {
            //create an instance of the class we want to create
            clsScreen Screen = new clsScreen();
            //create some test data to the property
            Boolean TestData = true;
            //assign the data to the property
            Screen.ScreenBeingUsed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.ScreenBeingUsed, TestData);
        }
        [TestMethod]
        public void AdsBeforeMoviePropertyOK()
        {
            //create an instance of the class we want to create
            clsScreen Screen = new clsScreen();
            //create some test data to assign to the property
            int TestData = 15;
            //assign the data to the property
            Screen.AdsBeforeMovie = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.AdsBeforeMovie, TestData);
        }
        [TestMethod]
        public void DateBookedOK()
        {
            //create an instance of the class we want to create
            clsScreen Screen = new clsScreen();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //asign the data to the property
            Screen.DateBooked = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Screen.DateBooked, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //Boolean variable to store the resuls of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ScreenID = 1;
            //invoke the method
            Found = AnScreen.Find(ScreenID);
            //test to see if the results are true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestScreenIDFound()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ScreenID = 1;
            //invoke the method
            Found = AnScreen.Find(ScreenID);
            //check the address no
            if (AnScreen.ScreenID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestScreenNameFound()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ScreenID = 1;
            //invoke the method
            Found = AnScreen.Find(ScreenID);
            //check the screen name
            if (AnScreen.ScreenName != "IMAX 1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCapacityFound()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ScreenID = 1;
            //invoke the method
            Found = AnScreen.Find(ScreenID);
            //check the address no
            if (AnScreen.Capacity != 100)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestScreenBeingUsedFound()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ScreenID = 1;
            //invoke the method
            Found = AnScreen.Find(ScreenID);
            //check the address no
            if (AnScreen.ScreenBeingUsed != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAdsBeforeMovieFound()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ScreenID = 1;
            //invoke the method
            Found = AnScreen.Find(ScreenID);
            //check the address no
            if (AnScreen.AdsBeforeMovie != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateBooked()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ScreenID = 1;
            //invoke the method
            Found = AnScreen.Find(ScreenID);
            //check the data booked
            if (AnScreen.DateBooked != Convert.ToDateTime("06/02/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ScreenNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string screenName = ""; //this should trigger an error
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ScreenNameMin()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string screenName = "a"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ScreenNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string screenName = "aa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ScreenNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string screenName = "aaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ScreenNameMax()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string screenName = "aaaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ScreenNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string screenName = "";
            screenName = screenName.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ScreenNameMid()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string screenName = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ScreenNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string screenName = "";
            screenName = screenName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CapacityMinLessOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string capacity = ""; //this should trigger an error
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CapacityMin()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string capacity = "a"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CapacityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string capacity = "aa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CapacityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string capacity = "aaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CapacityMax()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string capacity = "aaaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CapacityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string capacity = "";
            capacity = capacity.PadRight(301, 'a'); //this should fail
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CapacityMid()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string capacity = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CapacityExtremeMax()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string capacity = "";
            capacity = capacity.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void adsBeforemMovirMinLessOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string adsBeforeMovie = ""; //this should trigger an error
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void adsBeforeMovieMin()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string adsBeforeMovie = "a"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void adsBeforeMovieMinPlusOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string adsBeforeMovie = "aa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void adsBeforeMovieMaxLessOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string adsBeforeMovie = "aaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void adsBeforeMovieMax()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string adsBeforeMovie = "aaaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void adsBeforeMovieMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string adsBeforeMovie = "";
            adsBeforeMovie = adsBeforeMovie.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void adsBeforeMovieMid()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string adsBeforeMovie = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void adsBeforeMovieExtremeMax()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string adsBeforeMovie = "";
            adsBeforeMovie = adsBeforeMovie.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateBookedExtremeMin()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string dateBooked = TestDate.ToString();
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void DateBookedMinLessOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string dateBooked = TestDate.ToString();
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateBookedMin()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string dateBooked = TestDate.ToString();
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateBookedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //changfe the date to whatever the date is plus one
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string dateBooked = TestDate.ToString();
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateBookedExtremeMax()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //changfe the date to whatever the date is plus one
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable
            string dateBooked = TestDate.ToString();
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateBookedInvalidData()
        {
            //create an instance of the class we want to create
            clsScreen AnScreen = new clsScreen();
            //string variable to store any error message
            String Error = "";
            //set the DateBooked to a non date value
            string dateBooked = "this is not a date!";
            //invoke the method
            Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

