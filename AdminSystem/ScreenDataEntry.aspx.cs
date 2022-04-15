using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsScreen
        clsScreen AnScreen = new clsScreen();
        //capture the screen name
        AnScreen.ScreenName = txtScreenName.Text;
        AnScreen.Capacity = Convert.ToInt32(txtCapacity.Text);
        AnScreen.AdsBeforeMovie = Convert.ToInt32(txtAdsBeforeMovie.Text);
        //store the address in the session object
        Session["AnScreen"] = AnScreen;
        //navigate to the viewer page
        Response.Redirect("ScreenViewer.aspx");


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
         
        }
    }
}