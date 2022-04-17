using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsScreenCollection
    {
        //private data member for the list
        List<clsScreen> mScreenList = new List<clsScreen>();
        public List<clsScreen> ScreenList
        {
            get
            {
                //return the private data
                return mScreenList;
            }
            set
            {
                //set the private data
                mScreenList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mScreenList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsScreen ThisScreen { get; set; }
        //constructor for the class
        public clsScreenCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblScreen_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsScreen AnScreen = new clsScreen();
                AnScreen.ScreenID = Convert.ToInt32(DB.DataTable.Rows[0]["ScreenID"]);
                AnScreen.ScreenName = Convert.ToString(DB.DataTable.Rows[0]["ScreenName"]);
                AnScreen.ScreenBeingUsed = Convert.ToBoolean(DB.DataTable.Rows[0]["ScreenBeingUsed"]);
                AnScreen.Capacity = Convert.ToString(DB.DataTable.Rows[0]["Capacity"]);
                AnScreen.AdsBeforeMovie = Convert.ToString(DB.DataTable.Rows[0]["AdsBeforeMovie"]);
                AnScreen.DateBooked = Convert.ToDateTime(DB.DataTable.Rows[0]["DateBooked"]);
                mScreenList.Add(AnScreen);
                Index++;
            }
        }
    }
}