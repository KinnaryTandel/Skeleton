using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsFlight
        clsFlight ANFlight = new clsFlight();
        //get the data from the session object

        ANFlight = (clsFlight)Session["AnFlight"];
        //display the house number for this entry
        Response.Write(ANFlight.FlightID );
        Response.Write("<br>");
        Response.Write(ANFlight.SeatNo);
        Response.Write("<br>");
        Response.Write(ANFlight.Departure);
        Response.Write("<br>");
        Response.Write(ANFlight.Arrival);
        Response.Write("<br>");
        Response.Write(ANFlight.DateandTime);
        Response.Write("<br>");
        Response.Write(ANFlight.TicketPrice);
        Response.Write("<br>");
        Response.Write(ANFlight.FlightStatus);
    }
}