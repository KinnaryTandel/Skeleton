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
            
            

            if (AirlineID == 1) 
            {
                
                mAirlineID = 1;
                mDateAdded = Convert.ToDateTime("2024-05-12"); 
                mAirlineName = "Blissful Travels";
                mAirlineEmail = "Blissfultravels@gmail.com";
                mAirlinePhoneNumber = 73061460;
                mWiFi = true;

                return true; 
            }
            else
            {
                return false; 
            }
        }

    }
}