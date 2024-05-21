using System;

namespace ClassLibrary
{
    public class clsFlight
    {
        public bool reschedule;

        public int AirlineID { get; set; }
        public int Departure { get; set; }
        public DateTime DateAdded { get; set; }
        public int Arrival { get; set; }
        public decimal Price { get; set; }
    }
}