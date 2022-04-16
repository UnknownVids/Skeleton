using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Manages the screening rooms that are available at a venue, including the creation of new rooms, removal of old ones and the 
/// updating of the capacity of existing ones
/// </summary>
/// 
namespace ClassLibrary
{
    public class clsScreen
    {
        //private data member for ads before movie
        private Int32 mAdsBeforeMovie;
        //public property for ads before movie
        public int AdsBeforeMovie
        {
            get
            {
                //return the private data
                return mAdsBeforeMovie;
            }
            set

            {
                //set tje value of the private data member
                mAdsBeforeMovie = value;
            }
        }
        //private data member for screen being used
        private Boolean mScreenBeingUsed;
        //public property for screen being used
        public bool ScreenBeingUsed
        {
            get
            {
                //return the private data
                return mScreenBeingUsed;
            }
            set
            {
                //set the private data
                mScreenBeingUsed = value;
            }
        }
        //private data member for capacity
        private Int32 mCapacity;
        //public property for capacity
        public int Capacity
        {
            get

            {
                //return the private data
                return mCapacity;

            }
            set
            {
                //set the value of the private data member
                mCapacity = value;
            }
        }
        //private data member for the screen name
        private string mScreenName;
        //public property for the screen name
        public string ScreenName
        {
            get
            {
                return mScreenName;
            }
            set
            {
                //set the value of the private data member
                mScreenName = value;
            }
        }
        //private data member for the Screen ID
        private Int32 mScreenID;
        //ScreenID
        public int ScreenID
        {
            get
            {
                //this line of the code sends data out of the screen
                return mScreenID;
            }
            set
            {
                //this line of the code allows data into the screen
                mScreenID = value;
            }
        }
        //datebooked private member variable
        private DateTime mDateBooked;
        public DateTime DateBooked
        {
            get
            {
                return mDateBooked;
            }
            set
            {
                mDateBooked = value;
            }
        }

        public bool Find(int ScreenID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramter for the ScreenID to search for
            DB.AddParameter("@ScreenID", ScreenID);
            //execute the store procedure
            DB.Execute("sproc_tblScreen_FilterByScreenID");
            //if one of the record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mScreenID = Convert.ToInt32(DB.DataTable.Rows[0]["ScreenID"]);
                mScreenName = Convert.ToString(DB.DataTable.Rows[0]["ScreenName"]);
                mScreenBeingUsed = Convert.ToBoolean(DB.DataTable.Rows[0]["ScreenBeingUsed"]);
                mCapacity = Convert.ToInt32(DB.DataTable.Rows[0]["Capacity"]);
                mAdsBeforeMovie = Convert.ToInt32(DB.DataTable.Rows[0]["AdsBeforeMovie"]);
                mDateBooked = Convert.ToDateTime(DB.DataTable.Rows[0]["DateBooked"]);
                //always return true
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
        //function for the public validation method
        public string Valid(string screenName, string capacity, string adsBeforeMovie, string dateBooked)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the screen name is blank
            if (screenName.Length == 0)
            {
                Error = Error + "The Screen Name may not be blank :";
            }
            //if the screen name is greater thant 50 characters
            if (screenName.Length > 50)
            {
                Error = Error + "The Screen Name must be less than 50 characters :";
            }
            if (capacity.Length == 0)
            {
                Error = Error + "The capacity may not be blank :";
            }
            if (capacity.Length > 300)
            {
                Error = Error + "The capacity must be less than 300 characters :";
            }
            if (adsBeforeMovie.Length == 0)
            {
                Error = Error + "The capacity may not be blank :";
            }
            if (adsBeforeMovie.Length > 50)
            {
                Error = Error + "The capacity must be less than 300 characters :";
            }
        try
            {   //copy the dataBooked value to the DateTEMP VARIABLE
            DateTemp = Convert.ToDateTime(dateBooked);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The Date cannot be in the past :";
            }
            //check to see if the data is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future :";
            }
        }
        catch
        {
            //record the error
            Error = Error + "The date was not a valid date : ";
        }
            //return any error message
            return Error;
        }
        ///this fucntion accepts 3 parameters for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank stirng is returned 
    }
}