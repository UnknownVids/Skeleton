using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ScreenID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the screen to be deleted from the session object
        ScreenID = Convert.ToInt32(Session["ScreenID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the screen class
        clsScreenCollection Screen = new clsScreenCollection();
        //find the record to delete
        Screen.ThisScreen.Find(ScreenID);
        //delete the record
        Screen.Delete();
        //redirect back to the main page
        Response.Redirect("ScreenList.aspx");
    }
}