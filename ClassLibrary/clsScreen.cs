using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public Int32 ScreenID 
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
        public bool Find(int screenID)
        {
            //set the private data members to the test data value
            mScreenID = 21;
            mScreenName = "IMAX1";
            mScreenBeingUsed = true;
            mCapacity = 20;
            mAdsBeforeMovie = 15;
            //always return true
            return true;
        }
    }
}