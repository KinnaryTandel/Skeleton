using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAirline
        clsAirline AnAirline = new clsAirline();
        //capture the airline attributes
        AnAirline.AirlineName = AirlineName.Text;
        AnAirline.AirlineEmail = AirlineEmail.Text;
        AnAirline.AirlinePhoneNumber = Convert.ToInt32(AirlinePhoneNumber.Text);
        AnAirline.DateAdded = Convert.ToDateTime(DateTime.Now);
        AnAirline.WiFi = chkWiFi.Checked;
        AnAirline.AirlineID = Convert.ToInt32(AirlineID.Text);
        //store the airline name in the session object
        Session["AnAirline"] = AnAirline;
        //navigate to the view page
        Response.Redirect("AirlineViewer.aspx");


    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void AirlineEmail_TextChanged(object sender, EventArgs e)
    {

    }
}