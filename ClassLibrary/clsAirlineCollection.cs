using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace ClassLibrary
{
    public class clsAirlineCollection
    {
        //private data member for the list
        List<clsAirline> mAirlineList = new List<clsAirline>();
        //private member for ThisAirline
        clsAirline mThisAirline = new clsAirline();



        //public property for the address list
        public List<clsAirline> AirlineList
        {
            get
            {
                //return the private data
                return mAirlineList;
            }
            set
            {
                //set the private data
                mAirlineList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAirlineList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsAirline ThisAirline
        {
            get
            {
                //return the private data
                return mThisAirline;
            }
            set
            {
                //set the private data
                mThisAirline = value;

            }
        }


        //Constructor for the class
        public clsAirlineCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //xxecute the stored procedure
            DB.Execute("sproc_tblAirline_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        
        public int Add()
        {
           
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //connect to the database
            DB.AddParameter("@AirlineName", mThisAirline.AirlineName);
            DB.AddParameter("@AirlineEmail", mThisAirline.AirlineEmail);
            DB.AddParameter("@AirlinePhoneNumber", mThisAirline.AirlinePhoneNumber);
            DB.AddParameter("@RegistrationDate", mThisAirline.DateAdded);
            DB.AddParameter("@HasWiFi", mThisAirline.WiFi);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAirline_Insert");
        }

        
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //connect to the database
            DB.AddParameter("@AirlineID", mThisAirline.AirlineID);
            DB.AddParameter("@AirlineName", mThisAirline.AirlineName);
            DB.AddParameter("@AirlineEmail", mThisAirline.AirlineEmail);
            DB.AddParameter("@AirlinePhoneNumber", mThisAirline.AirlinePhoneNumber);
            DB.AddParameter("@RegistrationDate", mThisAirline.DateAdded);
            DB.AddParameter("@HasWiFi", mThisAirline.WiFi);
            //execute the stored procedure
            DB.Execute("sproc_tblAirline_Update");
        }

        public void Delete()
        {
            //set the parameters for the stored procedure
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AirlineID", mThisAirline.AirlineID);
            //execute the stored procedure
            DB.Execute("sproc_tblAirline_Delete");
        }

        public void ReportByAirlineName(string AirlineName)
        {
            //filters the records based on full or partial airline name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the AirlineName parameter to the database
            DB.AddParameter("@AirlineName", AirlineName);
            //execute the stored procedure
            DB.Execute("sproc_tblAirline_FilterByAirlineName");
            //populate the array list with the filtered data
            PopulateArray(DB);
        }

        
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable to store the record count
            Int32 RecordCount = DB.Count;
            //variable for the index
            Int32 Index = 0;
            //clear the private array list
            mAirlineList = new List<clsAirline>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank airline
                clsAirline AnAirline = new clsAirline();
                //read in the fields from the current record
                AnAirline.AirlineID = Convert.ToInt32(DB.DataTable.Rows[Index]["AirlineID"]);
                AnAirline.AirlineName = Convert.ToString(DB.DataTable.Rows[Index]["AirlineName"]);
                AnAirline.AirlineEmail = Convert.ToString(DB.DataTable.Rows[Index]["AirlineEmail"]);
                AnAirline.AirlinePhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["AirlinePhoneNumber"]);
                AnAirline.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegistrationDate"]);
                AnAirline.WiFi = Convert.ToBoolean(DB.DataTable.Rows[Index]["HasWiFi"]);
                // Add the record to the private data member
                mAirlineList.Add(AnAirline);
                // Point at the next record
                Index++;
            }
        }
    }
}



        