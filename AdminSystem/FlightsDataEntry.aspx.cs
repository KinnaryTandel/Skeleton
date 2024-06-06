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
    //variable to store the primary key with page level scope
    Int32 FlightID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the flight to be processed
        FlightID = Convert.ToInt32(Session["FlightID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (FlightID != -1)
            {
                //display the current data for the record
                DisplayFlight();
            }
        }
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsFlight
        clsFlight AnFlight = new clsFlight();
        //capture the seat no 
        string SeatNo = txtSeatNo.Text;
        //capture the Departure
        string Departure = txtDeparture.Text;
        //capture the Arrival
        string Arrival = txtArrival.Text;
        //capture ticketprice
        string TicketPrice = txtTicketPrice.Text;
        //capture the DateandTime
        string DateandTime =  txtDateandTime.Text;
        //capture the Check Box
        string FlightStatus = chkFlightStatus.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
        if( Error == "")
        {
            //capture the flight id
            AnFlight.FlightID = FlightID;
            //capture the seatno
            AnFlight.SeatNo = SeatNo;
            //capture the Departure
            AnFlight.Departure = Departure;
            //capture the arrIval
            AnFlight.Arrival = Arrival; 
            //capture the DateandTime
            AnFlight.DateandTime = Convert.ToDateTime(DateandTime);
            //capture the ticketprice
            AnFlight.TicketPrice = Convert.ToDecimal(TicketPrice);
            //capture FlightStatus
            AnFlight.FlightStatus = chkFlightStatus.Checked;
           //create a new instance of the flight collection
           clsFlightCollection FlightList = new clsFlightCollection();
           //if this is a new record i.e FlightID = -1 then add the data
           if (FlightID == -1)
            {
                //SET the ThisFlight property
                FlightList.ThisFlight = AnFlight;
                //add the new record
                FlightList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                FlightList.ThisFlight.Find(FlightID);
                //set the this flight property
                FlightList.ThisFlight = AnFlight;
                //update the record
                FlightList.Update();
            }
            //redirect back to the list page
            Response.Redirect("FlightsList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text =Error;
        }
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

    void DisplayFlight()
    {
        //create an instance of the Flight book
        clsFlightCollection FlightBook = new clsFlightCollection();
        //find the record to update
        FlightBook.ThisFlight.Find(FlightID);
        //diplay the data for the record
        txtFlightID.Text = FlightBook.ThisFlight.FlightID.ToString();
        txtSeatNo.Text = FlightBook.ThisFlight.SeatNo.ToString();
        txtDeparture.Text = FlightBook.ThisFlight.Departure.ToString();
        txtArrival.Text = FlightBook.ThisFlight.Arrival.ToString();
        txtDateandTime.Text = FlightBook.ThisFlight.DateandTime.ToString();
        txtTicketPrice.Text = FlightBook.ThisFlight.TicketPrice.ToString();
        chkFlightStatus.Checked = FlightBook.ThisFlight.FlightStatus;
    }
}