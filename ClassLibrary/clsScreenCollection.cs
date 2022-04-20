using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsScreenCollection
    {
        //private data member thisScreen
        clsScreen mThisScreen = new clsScreen();
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
        public clsScreen ThisScreen
        {
            get
            {
                //return the private data
                return mThisScreen;
            }
            set
            {
                //set the private data
                mThisScreen = value;
            }
        }
        //constructor for the class
        public clsScreenCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblScreen_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisScreen
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@ScreenName", mThisScreen.ScreenName);
            DB.AddParameter("@ScreenBeingUsed", mThisScreen.ScreenBeingUsed);
            DB.AddParameter("@Capacity", mThisScreen.Capacity);
            DB.AddParameter("@AdsBeforeMovie", mThisScreen.AdsBeforeMovie);
            DB.AddParameter("@DateBooked", mThisScreen.DateBooked);
            //execute the query returing the primary key value
            return DB.Execute("sproc_tblScreen_Insert");
        }

        public void Update()
        {
            //adds an existing record based on the values of thisScreen
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@ScreenID", mThisScreen.ScreenID);
            DB.AddParameter("@ScreenName", mThisScreen.ScreenName);
            DB.AddParameter("@ScreenBeingUsed", mThisScreen.ScreenBeingUsed);
            DB.AddParameter("@Capacity", mThisScreen.Capacity);
            DB.AddParameter("@AdsBeforeMovie", mThisScreen.AdsBeforeMovie);
            DB.AddParameter("@DateBooked", mThisScreen.DateBooked);
            //execute the query returing the primary key value
            DB.Execute("sproc_tblScreen_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisScreen
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ScreenID", mThisScreen.ScreenID);
            //execute the stored procedure
            DB.Execute("sproc_tblScreen_Delete");
        }

        public void ReportByCapacity(string Capacity)
        {
            //filters the records based on a full or partial capacity
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Capacity parameter to the database
            DB.AddParameter("@Capacity", Capacity);
            //execute the stored procedure
            DB.Execute("sproc_tblScreen_FilterByCapacity");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mScreenList = new List<clsScreen>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsScreen AnScreen = new clsScreen();
                AnScreen.ScreenID = Convert.ToInt32(DB.DataTable.Rows[Index]["ScreenID"]);
                AnScreen.ScreenName = Convert.ToString(DB.DataTable.Rows[Index]["ScreenName"]);
                AnScreen.ScreenBeingUsed = Convert.ToBoolean(DB.DataTable.Rows[Index]["ScreenBeingUsed"]);
                AnScreen.Capacity = Convert.ToString(DB.DataTable.Rows[Index]["Capacity"]);
                AnScreen.AdsBeforeMovie = Convert.ToInt32(DB.DataTable.Rows[Index]["AdsBeforeMovie"]);
                AnScreen.DateBooked = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateBooked"]);
                mScreenList.Add(AnScreen);
                Index++;
            }

        }
    }
}