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
        lstScreenList.DataTextField = "Capacity";
        //bind the data to the list
        lstScreenList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store  -1 into the session object to indicate this is a new record
        Session["ScreenID"] = -1;
        //response to the data entry page
        Response.Redirect("ScreenDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ScreenID;
        //if a record has been selected from the list
        if (lstScreenList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ScreenID = Convert.ToInt32(lstScreenList.SelectedValue);
            //store the data in the session object
            Session["ScreenID"] = ScreenID;
            //redirect to the edit page
            Response.Redirect("ScreenDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ScreenID;
        //if a record has been selected from the list
        if (lstScreenList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ScreenID = Convert.ToInt32(lstScreenList.SelectedValue);
            //store the data in the session object
            Session["ScreenID"] = ScreenID;
            //redirect to the edit page
            Response.Redirect("ScreenConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the screen collection
        clsScreenCollection Screens = new clsScreenCollection();
        Screens.ReportByCapacity("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstScreenList.DataSource = Screens.ScreenList;
        //set the name of the primary key
        lstScreenList.DataValueField = "ScreenID";
        //set the name of the field to display
        lstScreenList.DataTextField = "Capacity";
        //bind the data to the list
        lstScreenList.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the screen collection
        clsScreenCollection Screens = new clsScreenCollection();
        Screens.ReportByCapacity(txtFilter.Text);
        lstScreenList.DataSource = Screens.ScreenList;
        //set the name of the primary key
        lstScreenList.DataValueField = "ScreenID";
        //set the name of the field to display
        lstScreenList.DataTextField = "Capacity";
        //bind the data to the list
        lstScreenList.DataBind();
    }
}