using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsFlight
        clsFlight AnFlight = new clsFlight();
         //capture the FlightID
        AnFlight.FlightID = Convert.ToInt32(txtFlightID.Text);
        //capture the seat no 
        AnFlight.SeatNo = txtSeatNo.Text;
        //capture the Departure
        AnFlight.Departure = txtDeparture.Text;
        //capture the Arrival
        AnFlight.Arrival = txtArrival.Text;

        AnFlight.TicketPrice = Convert.ToDecimal(txtTicketPrice.Text);
        //capture the DateandTime
        AnFlight.DateandTime = Convert.ToDateTime(DateTime.Now);
        //capture the Check Box
        AnFlight.FlightStatus = chkFlightStatus.Checked;
        //store the address in the session object
        Session["AnFlight"] = AnFlight;
        //navigate to th view page
        Response.Redirect("FlightsViewer.aspx");
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsFlight AnFlight = new clsFlight();
        //create a variable to store the primary key
        Int32 FlightID;
        //create a variable to sore the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        FlightID = Convert.ToInt32(txtFlightID.Text);
        //find the record
        Found = AnFlight.Find(FlightID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSeatNo.Text = AnFlight.SeatNo;
            txtDeparture.Text = AnFlight.Departure;
            txtArrival.Text = AnFlight.Arrival;
            txtDateandTime.Text = AnFlight.DateandTime.ToString();
            txtTicketPrice.Text = AnFlight.TicketPrice.ToString();
            chkFlightStatus.Checked = AnFlight.FlightStatus;
        }
    }
}