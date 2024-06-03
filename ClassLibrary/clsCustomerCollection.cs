using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
       //private member data for thisCustomer
       clsCustomer mThisCustomer = new clsCustomer();

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
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }

        }
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
           //populate the array list with the data table
           PopulateArray(DB);
        }

        public int Add()
        {
            //set a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PaymentDetails", mThisCustomer.PaymentDetails);
            DB.AddParameter("@BookingId", mThisCustomer.BookingID);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Active", mThisCustomer.Active);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }
        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PaymentDetails", mThisCustomer.PaymentDetails);
            DB.AddParameter("@BookingId", mThisCustomer.BookingID);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByName(string Name)
        {
            //filter the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //sens the Name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the counts of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer object
                clsCustomer aCustomer = new clsCustomer();
                //read in the fields from the current record
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

        public void ReportByName(object text)
        {
            throw new NotImplementedException();
        }
    }
}