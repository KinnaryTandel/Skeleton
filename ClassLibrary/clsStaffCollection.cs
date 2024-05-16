using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        //constructor for the class
        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record cound
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff aStaff = new clsStaff();
                //read in the fields for the current record
                aStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                aStaff.Fullname = Convert.ToString(DB.DataTable.Rows[Index]["Fullname"]);
                aStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                aStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                aStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                aStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                aStaff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAdmin"]);
                //add the record to the private data member
                mStaffList.Add(aStaff);
                //point at the next record
                Index++;
            }
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

        public clsStaff ThisStaff { get; set; }
    }
}