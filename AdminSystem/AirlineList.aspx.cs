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
        //get the number of the airline to be processed
        AirlineID = Convert.ToInt32(Session["AirlineID"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (AirlineID != -1)
            {
                //display the current data for the record
                DisplayAirlines();
            }
        }
    }

    void DisplayAirlines()
    {
        //create an instance of the airline collection
        clsAirlineCollection Airlines = new clsAirlineCollection();
        //set the data source to list of airlines in the collection
        lstAirlineList.DataSource = Airlines.AirlineList;
        //set the name of the primary key
        lstAirlineList.DataValueField = "AirlineEmail";
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
            //store the dta in the session object
            Session["AirlineID"] = AirlineID;
            //redirect to the edit page
            Response.Redirect("AirlineConfirmDelete.aspx");
        }
        else  //if no record has been selected 
        {
            lblError.Text = "please select a record from the list to delete";
        }
      }
     }
