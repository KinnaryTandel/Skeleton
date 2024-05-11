using System;

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
    }
}