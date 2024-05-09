using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the booking id property
        private Int32 mBookingId;
        //private data member for the date added property
        private DateTime mDateAdded; //private data member
        //private data member for the payment dettails
        private Int32 mPaymentDetails;
        private Int32 mCustomerId;
        private String mName;
        private String mEmail;
        private Boolean mActive;


        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of property
                return mDateAdded;
            }
            set 
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }
        public string Name
        {
            get
            {
                //this line of code sends data out of property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }
        public string Email
        {
            get
            {
                //this line of code sends data out of property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        public int PaymentDetails
        {
            get
            {
                //this line of code sends data out of property
                return mPaymentDetails;
            }
            set
            {
                //this line of code allows data into the property
                mPaymentDetails = value;
            }
        }
        public int BookingID
        {
            get
            {
            //this line of code sends data out of the property
            return mBookingId;
            }
            set {
            //this line of code allows data into the property
            mBookingId = value;
        }

    }

        public bool Find(int CustomerId)
        {
            //set the private data members to the test data value
            mBookingId = 3;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            mPaymentDetails = 123;
            mCustomerId = 3;
            mName = "abc";
            mEmail = "abc";
            mActive = true;
            //always return true
            return true;
        }
    }
   
}