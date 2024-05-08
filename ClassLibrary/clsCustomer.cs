using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PaymentDetails { get; set; }
        public int BookingID { get; set; }
    }
}