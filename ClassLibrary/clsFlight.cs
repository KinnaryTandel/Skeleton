using System;
using System.Xml.Linq;

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

        public bool Find(int FlightID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@FlightID", FlightID);
            //execute the stored procedure
            DB.Execute("sproc_TblFlights_FilterByFlightID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                fFlightID = Convert.ToInt32(DB.DataTable.Rows[0]["FlightID"]);
                fSeatNo = Convert.ToString(DB.DataTable.Rows[0]["SeatNo"]);
                fDeparture = Convert.ToString(DB.DataTable.Rows[0]["Departure"]);
                fArrival = Convert.ToString(DB.DataTable.Rows[0]["Arrival"]);
                fDateandTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DateandTime"]);
                fTicketPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TicketPrice"]);
                fFlightStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["FlightStatus"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }

        public string Valid(string seatNo, string departure, string arrival, string dateandTime, string ticketPrice)
        {
            String Error = "";

           
            DateTime DateTemp;

            if(seatNo.Length == 0) 
            {
                Error = Error + "the seatno may not be blank <br>";
            }

            if(seatNo.Length > 50)
            {
                Error = Error + "The seat no must be less than 50 characters <br>";
            }

            if (departure.Length == 0)
            {
                Error = Error + "the Daparture may not be blank <br>";
            }

            if (departure.Length > 50)
            {
                Error = Error + "The Deaparture must be less than 50 characters <br>";
            }

            if (arrival.Length == 0)
            {
                Error = Error + "the arrival may not be blank <br>";
            }

            if (arrival.Length > 50)
            {
                Error = Error + "The arrival must be less than 50 characters <br>";
            }

            DateTime DateComp = DateTime.Now.Date;

            try
            {
                DateTemp = Convert.ToDateTime(dateandTime);
                if(DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past <br>";
                }
                
                if(DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future <br>";
                }
                
            }
            catch
            {
                Error = Error + "The date was not a valid date <br>";
            }
          
            if(ticketPrice.Length == 0)
            {
                Error = Error + "The TicketPrice may not be blank";
            }
            
            
            
            return Error;
        }
    }
}