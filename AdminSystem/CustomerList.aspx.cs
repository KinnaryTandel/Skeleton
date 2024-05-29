﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
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
            DisplayCustomers();
        }

    }
    void DisplayCustomers()
    {
        //create an instance of the Customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customer in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "Name";
        //set the data field to display
        lstCustomerList.DataTextField = "Email";
        //bind the data to the list
        lstCustomerList.DataBind();
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 CustomerId;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 CustomerId;
        //if a record had been deleted from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}


    

