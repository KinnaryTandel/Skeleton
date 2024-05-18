using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
       

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        
        public int Count
        {
            get
            {
                //retunr the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCustomer ThisCustomers { get; set; }

        
        //constructor for the class
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
                    {
                //create a blank customer
                clsCustomer aCustomer = new clsCustomer();
                //read in the fileds for the current record
                aCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                aCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                aCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                aCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                aCustomer.PaymentDetails = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentDetails"]);
                aCustomer.BookingID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingId"]);
                aCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mCustomerList.Add(aCustomer);
                //point to the next record
                Index++;
            }
        }
    }
}