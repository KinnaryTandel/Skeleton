using System;
using System.CodeDom;

namespace ClassLibrary
{
    public class clsAirline
    {
        //private data member for the airline id property
        private Int32 mAirlineID;

        //AirlineID  public property
        public int AirlineID
        {
            get
            {
                //this line of code sends data out of property
                return mAirlineID;
            }
            set
            {
                //this code allows data into the property
                mAirlineID = value;
            }
        }

        //private data member for the date id property
        private DateTime mDateAdded;

        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of property
                return mDateAdded;
            }
            set
            {
                //this  line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the airline name id property
        private string mAirlineName;

        //AirlineName public property
        public string AirlineName
        {
            get
            {
                // this line of code sends data out of property
                return mAirlineName;
            }
            set
            {
                // this line of code allows data into the property
                mAirlineName = value;
            }
        }


        //private data member for the airline name id property
        private string mAirlineEmail;

        public string AirlineEmail
        {
            get
            {
                //this line of code sends data out of property
                return mAirlineEmail;
            }
            set
            {
                //this line of code allows data into the property
                mAirlineEmail = value;
            }
        }

        //private data member for airline email id property
        private int mAirlinePhoneNumber;

        public int AirlinePhoneNumber
        {
            get
            {
                //this line of code sends data out of property
                return mAirlinePhoneNumber;
            }
            set
            {
                //this line of code allows data into the property
                mAirlinePhoneNumber = value;
            }
        }

        //priate data member for WiFi id property
        private bool mWiFi;

        public bool WiFi
        {
            get
            {
                //this line of code sends data out of property
                return mWiFi;
            }
            set
            {
                //this line of code allows data into the property
                mWiFi = value;
            }
        }

        public bool Find(int AirlineID)
        {
            //create an instance from the database to the private data members
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the airline id to search for 
            DB.AddParameter("@AirlineID", AirlineID);
            //execure the stored procedure
            DB.Execute("sproc_tblAirline_FilterbyAirlineID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                mAirlineID = Convert.ToInt32(DB.DataTable.Rows[0]["AirlineID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["RegistrationDate"]);
                mAirlineName = Convert.ToString(DB.DataTable.Rows[0]["AirlineName"]);
                mAirlineEmail = Convert.ToString(DB.DataTable.Rows[0]["AirlineEmail"]);
                mAirlinePhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["AirlinePhoneNumber"]);
                mWiFi = Convert.ToBoolean(DB.DataTable.Rows[0]["HasWiFi"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indiacting there is a problem
                return false;
            }
        }

        public string Valid(string AirlineName, string AirlineEmail, string AirlinePhoneNumber, string DateAdded)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store data values 
            DateTime DateTemp;

            //if AirlineName is blank
            if (AirlineName.Length == 0)
            {
                //record the error
                Error = Error + "The airline name may be blank : ";
            }

            //if the Airline Name is greater than 50 characters
            if (AirlineName.Length > 50)
            {
                //record the error
                Error = Error + "The airline name must be less than 50 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {

                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a vaild date : ";
            }

            //is the email blank
            if(AirlineEmail.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";

            }

            //if email is too long
            if (AirlineEmail.Length > 50)
            {
                //record the error 
                Error = Error + "This email must be less than 50 characters";

            }

            //if the phone number is blank
            if(AirlinePhoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank : ";

            }

            //if the phone number is too long
            if (AirlinePhoneNumber.Length > 25)
            {
                //record the error
                Error = Error + "This phone number must be less than 25 characters :  ";
            }
            

            //return any error messages 
            return Error;
        }

    }
}





    
