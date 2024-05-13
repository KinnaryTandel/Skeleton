using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAirline
        clsAirline AnAirline = new clsAirline();
        //get the data from the session object
        AnAirline = (clsAirline)Session["AnAirline"];
        //display the airline name  for this entry
        Response.Write(AnAirline.AirlineName);
        Response.Write(AnAirline.AirlineID);
        Response.Write(AnAirline.AirlineEmail);
        Response.Write(AnAirline.AirlinePhoneNumber);
        Response.Write(AnAirline.DateAdded);
        Response.Write(AnAirline.WiFi);
    } 
}