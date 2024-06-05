﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ClassLibrary

{
    public class clsFlightCollection
    {
        


        //private data member for the list
        List<clsFlight> fFlightList = new List<clsFlight>();
        //private member data for thisflight
        clsFlight fThisFlight = new clsFlight();
        //public property for the flight list
        public List<clsFlight> FlightList
        {
            get
            {
                //return the private data
                return fFlightList;
            }
            set
            {
                //set the private data
                fFlightList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return FlightList.Count;

            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsFlight ThisFlight
        {
            get
            {
                //return the private data
                return fThisFlight;
            } 
            set
            {

                //set the private data
                fThisFlight = value;

            }
        }

        //constructor for the class
        public clsFlightCollection()
        {
            //variabel for the index
            Int32 Index = 0;

            //variable to store the record count 
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_TblFlights_SelectAll");
            //get the count of record
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank flight
                clsFlight AnFlight = new clsFlight();
                //read in the fields for the current record
                AnFlight.FlightID = Convert.ToInt32(DB.DataTable.Rows[Index]["FlightID"]);
                AnFlight.SeatNo = Convert.ToString(DB.DataTable.Rows[Index]["SeatNo"]);
                AnFlight.Departure = Convert.ToString(DB.DataTable.Rows[Index]["Departure"]);
                AnFlight.Arrival = Convert.ToString(DB.DataTable.Rows[Index]["Arrival"]);
                AnFlight.DateandTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateandTime"]);
                AnFlight.TicketPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TicketPrice"]);
                AnFlight.FlightStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["FlightStatus"]);
                //add the record to the private data member
                fFlightList.Add( AnFlight );
                //point at the next record
                Index++;

            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of fthisflight
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SeatNo", fThisFlight.SeatNo);
            DB.AddParameter("@Departure", fThisFlight.Departure);
            DB.AddParameter("@Arrival", fThisFlight.Arrival);
            DB.AddParameter("@DateandTime", fThisFlight.DateandTime);
            DB.AddParameter("@TicketPrice", fThisFlight.TicketPrice);
            DB.AddParameter("@FlightStatus", fThisFlight.FlightStatus);

            //execute the query returning the primary key value
            return DB.Execute("sproc_TblFlights_Insert");
        }
    }
}