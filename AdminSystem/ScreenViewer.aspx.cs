using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsScreen
        clsScreen AnScreen = new clsScreen();
        //get the data from the session object
        AnScreen = (clsScreen) Session["AnScreen"];
        //display the screen name foe this entry
        Response.Write(AnScreen.ScreenName + "<br />"); 
        Response.Write(AnScreen.Capacity + "<br />");
        Response.Write(AnScreen.AdsBeforeMovie + "<br />");
        Response.Write(AnScreen.DateBooked + "<br /?");

    }
}