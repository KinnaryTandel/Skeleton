using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //capture the Full name
        string Fullname = txtFullname.Text;
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
            //capture the Staff Id
            aStaff.StaffId = StaffId;
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

            //if this is a new record i.e. StaffId = -1 then add the data
            if (StaffId == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = aStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the ThisStaff prooperty
                StaffList.ThisStaff = aStaff;
                //update the record
                StaffList.Update();
            }
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

    void DisplayStaff()
    {
        //create an instance of the Staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffId);
        //display the data for the record
        txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtFullname.Text = StaffBook.ThisStaff.Fullname.ToString();
        txtEmail.Text = StaffBook.ThisStaff.Email.ToString();
        txtPassword.Text = StaffBook.ThisStaff.Password.ToString();
        txtPhoneNumber.Text = StaffBook.ThisStaff.PhoneNumber.ToString();
        txtStartDate.Text = StaffBook.ThisStaff.StartDate.ToString();
        chkIsAdmin.Checked= StaffBook.ThisStaff.IsAdmin;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnReturnMM_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("TeamMainMenu.aspx");
    }
}