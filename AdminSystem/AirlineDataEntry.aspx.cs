using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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

        //capture the airline name
        string AirlineName = txtAirlineName.Text;
        //capture the airline email
        string AirlineEmail = txtAirlineEmail.Text;
        //capture the airline phone number
        string AirlinePhoneNumber = txtAirlinePhoneNumber.Text;
        //capture the airline resigistration date
        String DateAdded = txtAirlineResigistrationDate.Text;
        String Error = "";
        Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
        if (Error == "")
        {
            //capture the airline attributes

            //capture the airline name
            AnAirline.AirlineName = txtAirlineName.Text;
            //capture the airline email
            AnAirline.AirlineEmail = txtAirlineEmail.Text;
            //capture the airline phone number
            AnAirline.AirlinePhoneNumber = Convert.ToInt32(txtAirlinePhoneNumber.Text);
            //capture the date added
            AnAirline.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the WiFi
            AnAirline.WiFi = chkWiFi.Checked;
            //capture the airline ID
            AnAirline.AirlineID = Convert.ToInt32(txtAirlineID.Text);
            clsAirlineCollection AirlineList = new clsAirlineCollection();  
            //set the ThisAirline property
            AirlineList.ThisAirline = AnAirline;
            //add the neww record
            AirlineList.Add();
            //redirect back to the list page
            Response.Redirect("AirlineList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the airline class
        clsAirline AnAirline = new clsAirline();
        //create a variable to store the primary key
        Int32 AirlineID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AirlineID = Convert.ToInt32(txtAirlineID.Text);
        //find the record
        Found = AnAirline.Find(AirlineID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAirlineID.Text = AnAirline.AirlineID.ToString();
            txtAirlineName.Text = AnAirline.AirlineName;
            txtAirlineEmail.Text = AnAirline.AirlineEmail;
            txtAirlinePhoneNumber.Text = AnAirline.AirlinePhoneNumber.ToString();
            txtAirlineResigistrationDate.Text = AnAirline.DateAdded.ToString();
            chkWiFi.Checked = AnAirline.WiFi;

        }
    }
}
