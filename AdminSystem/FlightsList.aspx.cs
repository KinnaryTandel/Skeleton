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
}