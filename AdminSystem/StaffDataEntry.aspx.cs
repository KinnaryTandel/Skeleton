using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //capture the Full name
        string Fullname = txtFullname.Text;
        //capture the StaffId
        string StaffId = txtStaffId.Text;
        //capture the Email
        string Email = txtEmail.Text;
        //capture the Password
        string Password = txtPassword.Text;
        //capture the Phone number
        string PhoneNumber = txtPhoneNumber.Text;
        //capture the Date Added
        string StartDate = txtStartDate.Text;
        //capture Active check box
        string IsAdmin = chkIsAdmin.Text;

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aStaff.Valid(Fullname, Email, Password, StartDate, PhoneNumber);
        if (Error == "")
        {
            //capture the Fullname
            aStaff.Fullname = Fullname;
            //capture the Email
            aStaff.Email = Email;
            //capture the Password
            aStaff.Password = Password;
            //capture the Start Date
            aStaff.StartDate = Convert.ToDateTime(StartDate);
            //capture the Phone number
            aStaff.PhoneNumber = PhoneNumber;
            //capture IsAdmin
            aStaff.IsAdmin = chkIsAdmin.Checked;

            //create a new instance of the address collection 
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the ThisStaff property
            StaffList.ThisStaff = aStaff;
            //add the new record
            StaffList.Add();
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff class
        clsStaff aStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the field operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = aStaff.Find(StaffId);
        //it found
        if ( Found == true)
        {
            //display the vlaues of the properties in the form
            txtEmail.Text = aStaff.Email;
            txtPassword.Text = aStaff.Password;
            txtFullname.Text = aStaff.Fullname;
            txtPhoneNumber.Text = Convert.ToString(aStaff.PhoneNumber);
            txtStartDate.Text = aStaff.StartDate.ToString();
            chkIsAdmin.Checked = aStaff.IsAdmin;
        }
    }
}