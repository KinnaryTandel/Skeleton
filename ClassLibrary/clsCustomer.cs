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


        //function for the public validation method
        public string Valid(string Name,
                            string Email,
                            string PaymentDetails,
                            string BookingId,
                            DateTime DataAdded)
        ///this function accepts 5 parameters for validation
        ///the function returns a string containing any error message
        ///if no error found than a blank string is returned
        {
            //create a string variable to store the error
            String Error = "";
            //if the name is blank
            if(Name.Length == 0)
            {
                //record the error
                Error = Error + "The Name may not be blank : ";
            }
            //return any error messages
            return Error;
        }

        public string Valid(string name, string email, string paymentDetails, string bookingId, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;

            //if the Name is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The Name may not be blank : ";
            }
            //if the Name is greater than 30 characters
            if (name.Length > 30)
            {
                //record the error
                Error = Error + "The Name must be less than 30 characters : ";
            }

            //if the Email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the Email is blank
            if (email.Length < 3)
            {
                //record the error
                Error = Error + "The Email field is incomplete : ";
            }
            //if the Email is greater than 30 characters
            if (email.Length > 30)
            {
                //record the error
                Error = Error + "The Email must be less than 30 characters : ";
            }

            if (paymentDetails.Length == 0)
            {
                //record the error
                Error = Error + "The Payment Details may not be blank : ";
            }
            //if the PaymentDetails lenght is less than 6 digits
            if (paymentDetails.Length < 6)
            {
                //record the error
                Error = Error + "The Payment Details field is incomplete : ";
            }
            //if the PaymentDetails lenght is greater than 10 characters
            if (paymentDetails.Length > 10)
            {
                //record the error
                Error = Error + "The Payment Details must be less than 10 characters : ";
            }

            if ( bookingId.Length == 0)
            {
                Error = Error + "The BookingId may not be blank : ";
            }

            if (bookingId.Length != 7 )
            {
                Error = Error + "The BookingId should contain 7 digits : ";
            }







            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch (FormatException)
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            
           
            //return any error messages
            return Error;
        }
    }
   
}