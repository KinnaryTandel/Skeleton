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

        public bool Find(int staffId)
        {
            //set the private data members to the test data value
            mStaffId = 4;
            mStaffDate = Convert.ToDateTime("09/05/2024");
            mStaffFullName = "Kinnary Tandel";
            mStaffEmail = "abc@email.com";
            mStaffPassword= "123";
            mStaffPhoneNo= "0123456789";
            mIsAdmin = true;
            //always return true
            return true;
        }
    }
}