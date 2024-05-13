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
        /****** FIND METHOD ******/
        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPaymentDetails = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentDetails"]);
                mBookingId = Convert.ToInt32(DB.DataTable.Rows[0]["BookingId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
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
    }
   
}