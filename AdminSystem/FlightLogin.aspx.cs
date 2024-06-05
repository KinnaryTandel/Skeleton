using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FlightLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //creaet an instance of the flight user class
       clsFlightUser AnUser = new clsFlightUser();
        //create the variable to store the username and passsword
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        //create a variable to store  the result of the find user opertaion
        Boolean Found = false;
         
            //get the username entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        //add a session to capture the user name
        Session["AnUser"] = AnUser;
        //if username/password is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a UserName ";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Password ";
        }
        //if found
        else if (Found == true)
        {
            //redirect to the List Page
            Response.Redirect("FlightsList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}