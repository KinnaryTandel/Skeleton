using System;

namespace ClassLibrary
{
    public class clsFlightUser
    {
        //private data member for the user id propetry
        private Int32 fUserID;
        //private data member for the user name propetry
        private string fUserName;
        //private data member for the password propetry
        private string fPassword;
        //private data member for the department propetry
        private string fDeparment;
        public int UserID 
        { 
            get
            {
                //return the private data
                return fUserID;
            }
            set
            {
                //set the private data
                fUserID = value;

            }
        }
        public string UserName 
        {
            get
            {
                //return the private data
                return fUserName;
            }
            set
            {
                //set the private data
                fUserName = value;

            }
        }
        public string Password
        {
            get
            {
                //return the private data
                return fPassword;
            }
            set
            {
                //set the private data
                fPassword = value;

            }
        }
        public string Department 
        {
            get
            {
                //return the private data
                return fDeparment;
            }
            set
            {
                //set the private data
                fDeparment = value;

            }
        }

        public bool FindUser(string userName, string password)
        {
           //create an instance of the data connection
           clsDataConnection DB = new clsDataConnection();
            //add the parameter for the user username and password to search for
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            //execute the store procedure
            DB.Execute("sproc_tblUser_FindUserNamePW");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data form the database to the private data member
                fUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                fUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                fPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                fDeparment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}