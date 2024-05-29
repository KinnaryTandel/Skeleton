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
    Int32 AirlineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the airline to be processed
        AirlineID = Convert.ToInt32(Session["AirlineID"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (AirlineID != -1)
            {
                //display the current data for the record
                DisplayAirline();

            }
        }
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

            //capture the airline ID
            //capture the airline name
            AnAirline.AirlineName = AirlineName;
            //capture the airline email
            AnAirline.AirlineEmail = AirlineEmail;
            //capture the airline phone number
            AnAirline.AirlinePhoneNumber = Convert.ToInt32(AirlinePhoneNumber);
            //capture the date added
            AnAirline.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the WiFi
            AnAirline.WiFi = chkWiFi.Checked;
            //capture the airline ID
            AnAirline.AirlineID = AirlineID;
            clsAirlineCollection AirlineList = new clsAirlineCollection();

            // if this is a new record i.e. Airline = -1 then add the data 
            if (AirlineID == -1)
            {


             //set the ThisAirline property
             AirlineList.ThisAirline = AnAirline;
             //add the neww record
             AirlineList.Add();
            }
            //otherwise it must be an update 
            else
            {
                //find the record to update
                AirlineList.ThisAirline.Find(AirlineID);
                //set the ThisAirline property
                AirlineList.ThisAirline = AnAirline;
                //update the new record
                AirlineList.Update();

            }
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

    void DisplayAirline()
    {
        //create an instance of the airline book
        clsAirlineCollection AirlineBook = new clsAirlineCollection();
        //find record to update 
        AirlineBook.ThisAirline.Find(AirlineID);
        //display the data for the record 
        txtAirlineID.Text = AirlineBook.ThisAirline.AirlineID.ToString();
        txtAirlineName.Text = AirlineBook.ThisAirline.AirlineName.ToString();
        txtAirlineEmail.Text = AirlineBook.ThisAirline.AirlineEmail.ToString();
        txtAirlinePhoneNumber.Text = AirlineBook.ThisAirline.AirlinePhoneNumber.ToString();
        txtAirlineResigistrationDate.Text = AirlineBook.ThisAirline.DateAdded.ToString();
        chkWiFi.Checked = AirlineBook.ThisAirline.WiFi;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
        
    }


    protected void btnMainMenu_Click(object sender, EventArgs e)
    {

    }
}



