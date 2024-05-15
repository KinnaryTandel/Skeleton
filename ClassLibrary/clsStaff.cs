using System;
using System.IO;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff id property
        private Int32 mStaffId;
        private String mStaffFullName;
        private String mStaffEmail;
        private DateTime mStaffDate;
        private String mStaffPassword;
        private String mStaffPhoneNo;
        private Boolean mIsAdmin;

        public bool IsAdmin {
            get
            {
                return mIsAdmin;
            }
            set
            {
                mIsAdmin = value;
            } 
        }

        public DateTime StartDate {
            get
            {
                return mStaffDate;
            }
            set
            {
                mStaffDate = value;
            }
        }
        
        public Int32 StaffId {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }

            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        public string Fullname {
            get
            {
                return mStaffFullName;
            }
            set
            {
                mStaffFullName = value;
            } 
        
        }

        public string Email {
            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }
        }

        public string Password {
            get
            {
                return mStaffPassword;
            }
            set
            {
                mStaffPassword = value;
            }
        }

        public string PhoneNumber {
            get
            {
                return mStaffPhoneNo;
            }
            set
            {
                mStaffPhoneNo = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int StaffId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffFullName = Convert.ToString(DB.DataTable.Rows[0]["Fullname"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mStaffDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mStaffPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAdmin"]);
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

        public string Valid(string fullname, string email, string password, string startDate, string phoneNumber)
        {
            //create a string variable to store the error
            String Error = "";

            /******* FULL NAME ******/
            if (fullname.Length == 0) {
                //record the error
                Error = Error + "The Full name may not be blank : ";
            }
            //if the fullname is greater than 50 characters
            if (fullname.Length > 50)
            {
                //record the error
                Error = Error + "Full name must be less than 50 chracters : ";
            }

            /******* DATE ******/
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the startDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(startDate);

                //check to see if the date is less than today's date
                if (DateTemp < DateComp)
                {
                    Error = Error + "The Date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The Date was not a valid date : ";
            }

            /******* EMAIL ******/
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the street is too long
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 characters : ";
            }

            /******* PASSWORD ******/
            if (password.Length == 0)
            {
                //record the error
                Error = Error + "The Password may not be blank : ";
            }
            //if the street is too long
            if (password.Length > 16)
            {
                //record the error
                Error = Error + "The Password must be less than 16 characters : ";
            }

            /******* PHONE NUMBER ******/
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The Phone number may not be blank : ";
            }
            //if the street is too long
            if (phoneNumber.Length > 10)
            {
                //record the error
                Error = Error + "The Phone number must be less than 10 characters : ";
            }
            //return any error messages 
            return Error;
        }
    }
}