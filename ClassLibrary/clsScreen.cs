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
    // The amount of seats in a screening room
    private int mScreenCapacity = 0;

    public int ScreenCapacity
    {
        get
        {
            return mScreenCapacity;
        }
        set
        {
            mScreenCapacity = value;
        }
    }

    public int ScreenID
    {
        get
        {
            return mScreenID;
        }
        set
        {
            mScreenID = value;
        }
    }


    // The unique ID of the screen referenced in orders
    private int mScreenID = -1;


    // The name of the screen that acts as a description for the room eg. IMAX Screen
    private String mScreenName = "Screen #";

    public String ScreenName
    {
        get
        {
            return mScreenName;
        }
        set
        {
            mScreenName = value;
        }
    }

    /* Set to true when this screen is no longer used for whatever reason
    *  This prevents this unique ID being used again which could possibly break backwards compatibility
    *  Cleanup function may be required in the future to resuffle the ID in all the records, but this is fine for now */
    private bool bDeprecated = false;

    public clsScreen()
    {

    }

    public clsScreen(int Capacity)
    {
        ScreenCapacity = Capacity;
    }

    public clsScreen(int Capacity, String Name)
    {
        ScreenCapacity = Capacity;
        ScreenName = Name;
    }
}


    public class clsScreenManagement
    {
        //create a connection to the database
        clsDataConnection Database = new clsDataConnection();

        int MaxIDs = 100;

        private List<clsScreen> mScreenList = new List<clsScreen>();

        public List<clsScreen> ScreenList
        {
            get
            {
                return mScreenList;
            }
            set
            {
                mScreenList = value;
            }
        }


        private clsScreen mSelectedScreen = new clsScreen();

        public clsScreen SelectedScreen
        {
            get
            {
                return mSelectedScreen;
            }
            set
            {
                mSelectedScreen = value;
            }
        }

        public clsScreen GetScreenByID(int ID)
        {
            foreach (clsScreen Screen in ScreenList)
            {
                if (Screen.ScreenID == ID)
                {
                    return Screen;
                }
            }

            return null;
        }



        public clsScreenManagement()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblScreen_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        // Initalises the local array
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
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
                //create a blank address
                clsScreen Screen = new clsScreen();
                //read in the fields from the current record
                Screen.ScreenID = Convert.ToInt16(DB.DataTable.Rows[Index]["ScreenID"]);
                Screen.ScreenName = Convert.ToString(DB.DataTable.Rows[Index]["ScreenName"]);
                Screen.ScreenCapacity = Convert.ToInt16(DB.DataTable.Rows[Index]["Capacity"]);

                //add the record to the private data mamber
                mScreenList.Add(Screen);
                //point at the next record
                Index++;
            }
        }

        private bool DoesScreenIDExist(int ID)
        {
            foreach (clsScreen Screen in ScreenList)
            {
                if (Screen.ScreenID == ID)
                {
                    return true;
                }
            }

            return false;
        }

        private int GetNewScreenID()
        {
            for (int i = 0; i < MaxIDs; i++)
            {
                if (!DoesScreenIDExist(i))
                {
                    return i;
                }
            }

            return -1;
        }

        // Adds a new screening room to the database, and returns the key that assigned
        public int AddScreen(clsScreen NewScreen)
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            int ScreenID = GetNewScreenID();

            if (ScreenID == -1)
            {
                return -1;
            }

            //set the parameters for the stored procedure
            DB.AddParameter("@ScreenID", ScreenID);
            DB.AddParameter("@ScreenName", NewScreen.ScreenName);
            DB.AddParameter("@RoomCapacity", NewScreen.ScreenCapacity);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblScreen_Create");
        }

        public void RemoveScreen(clsScreen Screen)
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ScreenID", Screen.ScreenID);

            //@TODO add in removal verification here to prevent unauthorised removal

            //removes the parameter
            DB.Execute("sproc_tblScreen_Delete");
        }

        // Updates an existing screen if the Screen ID matches
        public void UpdateScreen(clsScreen ScreenUpdate)
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();


            //set the parameters for the stored procedure
            DB.AddParameter("@ScreenID", ScreenUpdate.ScreenID);
            DB.AddParameter("@ScreenName", ScreenUpdate.ScreenName);
            DB.AddParameter("@Capacity", ScreenUpdate.ScreenCapacity);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblScreen_Update");
        }


    }
}