using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 AirlineID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the airline to be deleted from the session object
        AirlineID = Convert.ToInt32(Session["AirlineID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the airline collection class
        clsAirlineCollection AirlineBook = new clsAirlineCollection();
        //find the record to delete 
        AirlineBook.ThisAirline.Find(AirlineID);
        //delete the record 
        AirlineBook.Delete();
        //redirect back to the main menu
        Response.Redirect("AirlineList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main menu
        Response.Redirect("AirlineList.aspx");
    }
}