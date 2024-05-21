using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsAirlineCollection
    {
        //private data member for the list
        List<clsAirline> mAirlineList = new List<clsAirline>();

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
        public clsAirline ThisAirline { get; set; }


        //constructor for the class
        public clsAirlineCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAirline_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount) 
            { 
                //create a blank Airline
                clsAirline AnAirline = new clsAirline();
                //read in the fields for the current record
                AnAirline.WiFi = Convert.ToBoolean(DB.DataTable.Rows[Index]["HasWi-Fi"]);
                AnAirline.AirlineID = Convert.ToInt32(DB.DataTable.Rows[Index]["AirlineID"]);
                AnAirline.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegistrationDate"]);
                AnAirline.AirlineName = Convert.ToString(DB.DataTable.Rows[Index]["AirlineName"]);
                AnAirline.AirlineEmail = Convert.ToString(DB.DataTable.Rows[Index]["AirlineEmail"]);
                AnAirline.AirlinePhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["AirlinePhoneNumber"]);
                //add the record to the private data member
                mAirlineList.Add(AnAirline);
                //point at the next record
                Index++;
            }

            //create the items of test data
            clsAirline TestItem = new clsAirline();
            //set its properties
            TestItem.WiFi = true;
            TestItem.AirlineID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.AirlineName = "Blissful Travels";
            TestItem.AirlineEmail = "BlissfulTravels@gmail.com";
            TestItem.AirlinePhoneNumber = 75643576;
            //add the test item to the test list
            mAirlineList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsAirline();
            //set its properties
            TestItem.WiFi = true;
            TestItem.AirlineID = 2;
            TestItem.DateAdded = DateTime.Now;
            TestItem.AirlineName = "Blissful_Travels";
            TestItem.AirlineEmail = "Bliss@gmail.com";
            TestItem.AirlinePhoneNumber = 73053015;
            //add the item to the test list
            mAirlineList.Add(TestItem);
        }

        }
    }

