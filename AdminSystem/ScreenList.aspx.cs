using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayScreens();
        }
    }
    void DisplayScreens()
    {
        //create an instance of the screen collection
        clsScreenCollection Screens = new clsScreenCollection();
        //set the data source to list of screens in the collection
        lstScreenList.DataSource = Screens.ScreenList;
        //set the name of the primary key
        lstScreenList.DataValueField = "ScreenID";
        //set the data field to display
        lstScreenList.DataTextField = "ScreenName";
        //bind the data to the list
        lstScreenList.DataBind();
    }

    protected void lstScreenList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}