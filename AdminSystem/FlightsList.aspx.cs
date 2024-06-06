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
            DisplayFlight();
        }
    }

    void DisplayFlight()

    {
        //create an instance of the Flight collection
        clsFlightCollection Flights = new clsFlightCollection();
        //set the data source to list of flight in the collection
        lstFlightList.DataSource = Flights.FlightList;
        //set the name of the primary key
        lstFlightList.DataValueField = "FlightID";
        //set the data field to display
        lstFlightList.DataTextField = "SeatNo";
        //bind the data to the list
        lstFlightList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is new record
        Session["FlightID"] = -1;
        //redirect to the data entry page
        Response.Redirect("FlightsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 FlightID;
        //if a record has been selected from the list
        if(lstFlightList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            FlightID = Convert.ToInt32(lstFlightList.SelectedValue);
            //stored the data in the sessison object
            Session["FlightID"] = FlightID;
            //redirect to the edit page
            Response.Redirect("FlightsDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 FlightID;
        //if a record has been selected from the list
        if (lstFlightList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            FlightID = Convert.ToInt32(lstFlightList.SelectedValue);
            //stored the data in the sessison object
            Session["FlightID"] = FlightID;
            //redirect to the edit page
            Response.Redirect("FlightsConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the flight object
        clsFlightCollection AnFlight = new clsFlightCollection();
        //retrieve the value of post code from the presentation layer
        AnFlight.ReportBySeatNo(txtFilter.Text);
        //set the data source to the list of Flights in the collection
        lstFlightList.DataSource = AnFlight.FlightList;
        //set the name of the primary key
        lstFlightList.DataValueField = "FlightID";
        //set the name of the field to display
        lstFlightList.DataTextField = "SeatNo";
        //bind the data to the list
        lstFlightList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the flight object
        clsFlightCollection AnFlight = new clsFlightCollection();
        //set an empty string
        AnFlight.ReportBySeatNo("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of flight in the collection
        lstFlightList.DataSource = AnFlight.FlightList;
        //set the name of the primary key
        lstFlightList.DataValueField = "FlightID";
        //set the name of the field to display
        lstFlightList.DataTextField = "SeatNo";
        //bind the data to the list
        lstFlightList.DataBind();
    }
}
