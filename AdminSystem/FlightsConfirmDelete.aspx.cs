using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 FlightID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the flight to be deleted from the session object
        FlightID = Convert.ToInt32(Session["FlightID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the flight collection class
        clsFlightCollection FlightBook = new clsFlightCollection();

        //find the record to delete
        FlightBook.ThisFlight.Find(FlightID);
        //delete the record
        FlightBook.Delete();
        //redirect back to the main page
        Response.Redirect("FlightsList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("FlightsList.aspx");
    }
}