using System;

namespace ClassLibrary
{
    public class clsFlight
    {

       
        public string Departure { get; set; }
        public DateTime DateandTime { get; set; }
        public string Arrival { get; set; }
        
        public int FlightID { get; set; }

        public string SeatNo { get; set; }
        
        public bool FlightStatus { get; set; }
       
        public decimal TicketPrice { get; set; }
    }
}