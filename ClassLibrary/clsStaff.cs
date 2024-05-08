using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool IsAdmin { get; set; }
        public DateTime StartDate { get; set; }
        public int StaffId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}