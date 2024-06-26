﻿using System;
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
        //if this is the fisrt time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }

        //create a new insatnce of clsStaffUser
        clsStaffUser anUser = new clsStaffUser();
        //get data from the session object
        anUser = (clsStaffUser)Session["anUser"];
        //display the user name
        Response.Write("Logged in as: " + anUser.UserName);
    }

    void DisplayStaffs()
    {
        //create an instance of the staff collection 
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of staffs in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display 
        lstStaffList.DataTextField = "Fullname";
        //bind the data to the list 
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
           StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else    //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else   //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection aStaff = new clsStaffCollection();
        //retrive the value of fullname from the presentation layer
        aStaff.ReportByFullname(txtSearch.Text);
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = aStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "Fullname";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection aStaff = new clsStaffCollection();
        //set an empty string
        aStaff.ReportByFullname("");
        //clear any existing filter to tidy up the interface
        txtSearch.Text = "";
        //set the data source to the list of staffs in the collection
        lstStaffList.DataSource = aStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "Fullname";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnReturnMM_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("TeamMainMenu.aspx");
    }
}