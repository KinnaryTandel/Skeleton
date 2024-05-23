using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for thiStaff
        clsStaff mThisStaff = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public proprty for the Staff list
        public List<clsStaff> StaffList
        {
            get 
            { 
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        
        }

        public int Count 
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                // we shall worry about this later
            }

        }

        public clsStaff ThisStaff {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Fullname", mThisStaff.Fullname);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);

            //execute the query returning the Primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect tot the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@Fullname", mThisStaff.Fullname);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);

            //execute the query returning the Primary key value
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFullname(string Fullname)
        {
            //filters the record based ona full or partial full name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the fullname parameter to the database
            DB.AddParameter("@Fullname", Fullname);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFullname");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByFullnameNoneFound(string Fullname)
        {
            //filters the record based ona full or partial full name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the fullname parameter to the database
            DB.AddParameter("@Fullname", Fullname);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFullname");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a black staff object
                clsStaff aStaff = new clsStaff();
                //read in the fields from the current record
                aStaff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAdmin"]);
                aStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                aStaff.Fullname = Convert.ToString(DB.DataTable.Rows[Index]["Fullname"]);
                aStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                aStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                aStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                aStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                //add the record to the private data member
                mStaffList.Add(aStaff);
                //point at the next record
                Index++;
            }
        }
    }
}