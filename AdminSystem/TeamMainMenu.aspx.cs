using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("StaffLogin.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("CustomerLogin.aspx");
    }


    protected void btnAirline_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("AirlineLogin.aspx");
    }



    protected void btnFlight_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("FlightLogin.aspx");
    }
}