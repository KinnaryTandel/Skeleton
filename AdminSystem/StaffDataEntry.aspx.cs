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



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //capture the Full name
        aStaff.Fullname = txtFullname.Text;
        //capture the StaffId
        aStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the Email
        aStaff.Email = txtEmail.Text;
        //capture the Password
        aStaff.Password = txtPassword.Text;
        //capture the Phone number
        aStaff.PhoneNumber = txtPhoneNumber.Text;
        //capture the Date Added
        aStaff.StartDate = Convert.ToDateTime(DateTime.Now);
        //capture Active check box
        aStaff.IsAdmin = chkIsAdmin.Checked;



        //store the Staff Detail in the session object
        Session["AStaff"] = aStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}