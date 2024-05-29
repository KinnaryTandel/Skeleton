using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 AirlineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is first time the page is displayed
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (AirlineID != -1)
            {
                //display the current data for the record
                DisplayAirlines();
            }

            //create an new instance of the clsAirlineUser
            clsAirlineUser AnUser = new clsAirlineUser();
            //get data from the session object
            AnUser = (clsAirlineUser)Session["AnUser"];
            //display the user name
            Response.Write("Logged in as: " + AnUser.UserName);
        }
    }

    void DisplayAirlines()
    {
        //create an instance of the airline collection
        clsAirlineCollection Airlines = new clsAirlineCollection();
        //set the data source to list of airlines in the collection
        lstAirlineList.DataSource = Airlines.AirlineList;
        //set the name of the primary key
        lstAirlineList.DataValueField = "AirlineID";
        //set the data field to display
        lstAirlineList.DataTextField = "AirlineName";
        //bind the data to the list
        lstAirlineList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 session object to indicate this 
        Session["AirlineID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AirlineDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 AirlineID;
        //if a record has been selected from the list
        if (lstAirlineList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            AirlineID = Convert.ToInt32(lstAirlineList.SelectedIndex);
            //store the dta in the session object
            Session["AirlineID"] = AirlineID;
            //redirect to the edit page
            Response.Redirect("AirlineDataEntry.aspx");
        }
        else  //if no record has been selected 
        {
            lblError.Text = "please select a record from the list to edit";
        }





    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 AirlineID;
        //if a record has been selected from the list
        if (lstAirlineList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            AirlineID = Convert.ToInt32(lstAirlineList.SelectedValue);
            //store the data in the session object
            Session["AirlineID"] = AirlineID;
            //redirect to the edit page
            Response.Redirect("AirlineConfirmDelete.aspx");
        }
        else  //if no record has been selected 
        {
            lblError.Text = "please select a record from the list to delete";
        }
      }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the airline object
        clsAirlineCollection AnAirline = new clsAirlineCollection();
        //retrieve the value of airline name from the presentation layer
        AnAirline.ReportByAirlineName(txtFilter.Text);
        //set the data source to the list of airlines in the collection
        lstAirlineList.DataSource = AnAirline.AirlineList;
        //set the name of the primary key
        lstAirlineList.DataValueField = "AirlineID";
        //set the name of the field to display
        lstAirlineList.DataTextField = "AirlineName";
        //bind the data to the list
        lstAirlineList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the airline object
        clsAirlineCollection AnAirline = new clsAirlineCollection();
        //set an empty string
        AnAirline.ReportByAirlineName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of airlines in the collection
        lstAirlineList.DataSource = AnAirline.AirlineList;
        //set the name of the primary key
        lstAirlineList.DataValueField = "AirlineID";
        //set the name of the field to display
        lstAirlineList.DataTextField = "AirlineName";
        //bind the data to the list
        lstAirlineList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
