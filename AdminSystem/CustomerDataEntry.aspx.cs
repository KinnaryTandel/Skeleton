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
        aCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer aCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to sore the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = aCustomer.Find(CustomerId);
        //if found
        if ( Found == true )
        {
            //display the values of the properties in the form
            txtName.Text = aCustomer.Name;
            txtEmail.Text = aCustomer.Email;
            txtPaymentDetails.Text = aCustomer.PaymentDetails.ToString();
            txtBookingId.Text = aCustomer.BookingID.ToString();
            txtDateAdded.Text = aCustomer.DateAdded.ToString();
            chkActive.Checked = aCustomer.Active;
        }
    }
}