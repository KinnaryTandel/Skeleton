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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //capture the customer id
        aCustomer.CustomerID = Convert.ToInt32(txtCustomerId.Text);
        //capture the name
        aCustomer.Name = txtName.Text;
        //capture the email
        aCustomer.Email = txtEmail.Text;
        //capture the payment details
        aCustomer.PaymentDetails = Convert.ToInt32(txtPaymentDetails.Text);
        //capture the booking id
        aCustomer.BookingID = Convert.ToInt32(txtBookingId.Text);
        //capture the booking date
        aCustomer.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture active check box
        aCustomer.Active = chkActive.Checked;
        //store the customer in the session object
        Session["aCustomer"] = aCustomer;
        //navidate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}