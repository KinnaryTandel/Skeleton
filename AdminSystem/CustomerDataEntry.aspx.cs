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
        string CustomerId = txtCustomerId.Text;
        //capture the name
        string Name = txtName.Text;
        //capture the email
        string Email = txtEmail.Text;
        //capture the payment details
        string PaymentDetails = txtPaymentDetails.Text;
        //capture the booking id
        string BookingID = txtBookingId.Text;
        //capture the booking date
        string DateAdded = txtDateAdded.Text;
        //capture active check box
        string Active = chkActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingID, DateAdded);
        if (Error == "")
        {
            //capture the Name
            aCustomer.Name = Name;
            //capture the email
            aCustomer.Email = Email;
            //capture the payment details
            aCustomer.PaymentDetails = Convert.ToInt32(PaymentDetails);
            //capture the booking id
            aCustomer.BookingID = Convert.ToInt32(BookingID);
            //capture the date added
            aCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //capture active
            aCustomer.Active = chkActive.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the ThisCustomer property
            CustomerList.ThisCustomer = aCustomer;
            //add the new record
            CustomerList.Add();
            //redirect back to the list page
            Response.Redirect("Customerlist.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }
}