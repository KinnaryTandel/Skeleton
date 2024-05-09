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
        //create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //get the data from the session object
        aStaff = (clsStaff)Session["AStaff"];

        
        //display the Staff Id
        Response.Write(aStaff.StaffId);
        //display the full name for this entry
        Response.Write(aStaff.Fullname);
        //display the email
        Response.Write(aStaff.Email);
        //display the Password
        Response.Write(aStaff.Password);
        //display the Phone no.
        Response.Write(aStaff.PhoneNumber);
        //display the Start Date
        Response.Write(aStaff.StartDate);
        //display the check box
        Response.Write(aStaff.IsAdmin);



    }
}