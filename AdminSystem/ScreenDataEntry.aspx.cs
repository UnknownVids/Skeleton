using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ScreenID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the screens to be processed
        ScreenID = Convert.ToInt32(Session["ScreenID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ScreenID != -1)
            {
                //display the current data for the record
                DisplayScreens();
            }
        }
    }
    void DisplayScreens()
    {
        //create an instance of the Screen
        clsScreenCollection Screens = new clsScreenCollection();
        //find the record to update
        Screens.ThisScreen.Find(ScreenID);
        //display the data for this record
        txtScreenID.Text = Screens.ThisScreen.ScreenID.ToString();
        txtScreenName.Text = Screens.ThisScreen.ScreenName;
        txtCapacity.Text = Screens.ThisScreen.Capacity;
        txtAdsBeforeMovie.Text = Screens.ThisScreen.AdsBeforeMovie;
        txtDateBooked.Text = Screens.ThisScreen.DateBooked.ToString();
        chkScreenBeingUsed.Checked = Screens.ThisScreen.ScreenBeingUsed;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsScreen
        clsScreen AnScreen = new clsScreen();
        //capture the screen name
        string screenName = txtScreenName.Text;
        string capacity = txtCapacity.Text;
        string adsBeforeMovie = txtAdsBeforeMovie.Text;
        string dateBooked = txtDateBooked.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnScreen.Valid(screenName, capacity, adsBeforeMovie, dateBooked);
        if (Error == "")
        {
            AnScreen.ScreenID = ScreenID;
            AnScreen.ScreenName = screenName;
            AnScreen.Capacity = capacity;
            AnScreen.AdsBeforeMovie = adsBeforeMovie;
            AnScreen.DateBooked = Convert.ToDateTime(dateBooked);
            AnScreen.ScreenBeingUsed = chkScreenBeingUsed.Checked;
            //create a new instance of the screen collection
            clsScreenCollection ScreenList = new clsScreenCollection();
            
            //if this is a new record i.e. ScreenID = -1 then add the data
            if(ScreenID == -1)
            {
                //set the ThisScreen property
                ScreenList.ThisScreen = AnScreen;
                //add the new record
                ScreenList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                ScreenList.ThisScreen.Find(ScreenID);
                //set the ThisScreen property
                ScreenList.ThisScreen = AnScreen;
                //update the record
                ScreenList.Update();
            }
            //navigate to the viewer page
            Response.Redirect("ScreenList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }
    protected void txtScreenID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the screen class
        clsScreen AnScreen = new clsScreen();
        //variable to store the primary key
        Int32 ScreenID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ScreenID = Convert.ToInt32( txtScreenID.Text);
        //find the record
        Found = AnScreen.Find(ScreenID);
        //if found
        if (Found==true)
        {
            //display the values of the properties in the form

            txtScreenName.Text = AnScreen.ScreenName;
            txtCapacity.Text = AnScreen.Capacity.ToString();
            txtAdsBeforeMovie.Text = AnScreen.AdsBeforeMovie.ToString();
            txtDateBooked.Text = AnScreen.DateBooked.ToString();
         
        }
    }
}