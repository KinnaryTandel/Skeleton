using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAirlines();
        }
    }

    void DisplayAirlines()
    {
        //create an instance of the airline collection
        clsAirlineCollection Airlines = new clsAirlineCollection();
        //set the data source to list of airlines in the collection
        lstAirlineList.DataSource = Airlines.AirlineList;
        //set the name of the primary key
        lstAirlineList.DataValueField = "AirlineEmail";
        //set the data field to display
        lstAirlineList.DataTextField = "AirlineName";
        //bind the data to the list
        lstAirlineList.DataBind();
      }
    }
