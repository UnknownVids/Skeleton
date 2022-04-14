﻿using System;
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
}