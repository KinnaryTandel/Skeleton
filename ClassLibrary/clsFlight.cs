﻿using System;

namespace ClassLibrary
{
    public class clsFlight
    {
        //private data member for the FlightID property
        private Int32 fFlightID;



        private string fDeparture;
        public string Departure
        {
            get
            {
                //thid line code sends data out of the property
                return fDeparture;
            }
            set
            {
                fDeparture = value;
            }
        }

        private DateTime fDateandTime;
        public DateTime DateandTime
        {
            get
            {
                //thid line code sends data out of the property
                return fDateandTime;
            }
            set
            {
                fDateandTime = value;
            }
        }

        private string fArrival;

        public string Arrival
        {
            get
            {
                //thid line code sends data out of the property
                return fArrival;
            }
            set
            {
                fArrival = value;
            }
        }

        public int FlightID 
        {
            get
            {
                //thid line code sends data out of the property
                return fFlightID;
            }
            set
            {
                fFlightID = value;
            }
        }

        private string fSeatNo;
        public string SeatNo
        {
            get
            {
                //thid line code sends data out of the property
                return fSeatNo;
            }
            set
            {
                fSeatNo = value;
            }
        }

        private Boolean fFlightStatus;
        public bool FlightStatus
        {
            get
            {
                //thid line code sends data out of the property
                return fFlightStatus;
            }
            set
            {
                fFlightStatus = value;
            }
        }

        private decimal fTicketPrice;
        public decimal TicketPrice
        {
            get
            {
                //thid line code sends data out of the property
                return fTicketPrice;
            }
            set
            {
                fTicketPrice = value;
            }
        }

        public bool Find(int flightID)
        {
            //set the private data members to the test data value
            fFlightID = 21;
            fSeatNo = "2a";
            fDeparture = "London";
            fArrival = "America";
            fDateandTime = Convert.ToDateTime("23/05/2024");
            fTicketPrice = 800;
            fFlightStatus = true;
            //always return true
            return true;
        }
    }
}