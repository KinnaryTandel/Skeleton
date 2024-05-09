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
        //create a new instance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //get the data from the session object
        aCustomer = (clsCustomer)Session["aCustomer"];
        //display the customer id
        Response.Write(aCustomer.CustomerId);
        //display the name for this entry
        Response.Write(aCustomer.Name);
        //display the email for this entry
        Response.Write(aCustomer.Email);
        //display the payment dettails
        Response.Write(aCustomer.PaymentDetails);
        //display the booking id 
        Response.Write(aCustomer.BookingID);
        //display the date the booking was added
        Response.Write(aCustomer.DateAdded);
        Response.Write(aCustomer.Active);
           }
}