using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingFlights
{
    [TestClass]
    public class tstFlight
    {

        string SeatNo = "77h";
        string Departure = "norway";
        string Arrival = "london";
        string DateandTime = DateTime.Now.ToShortDateString();
        string TicketPrice = "400";
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //test to see that it exists
            Assert.IsNotNull(AnFlight);
        }
        [TestMethod]
        public void FlightIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnFlight.FlightID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightID, TestData);
        }

        [TestMethod]
        public void FlightSeatNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property

            string TestData = "Error";

            AnFlight.SeatNo = TestData;

            Assert.AreEqual(AnFlight.SeatNo, TestData);
        }
        [TestMethod]
        public void FlightDeperturePropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            string TestData = "Error";
            //create some test data to assign to the property
            AnFlight.Departure = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Departure, TestData);

        }
        [TestMethod]
        public void FlightDateandtimePropertyOk()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnFlight.DateandTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.DateandTime, TestData);
        }
        [TestMethod]
        public void FlightArrivalPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            string TestData = "Error";
            //create some test data to assign to the property
            AnFlight.Arrival = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Arrival, TestData);

        }
        [TestMethod]
        public void FlightTicketPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            Decimal TestData = 1;
            //assign the data to the property
            AnFlight.TicketPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.TicketPrice, TestData);
        }
        [TestMethod]
        public void FlightStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AnFlight.FlightStatus = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnFlight.FlightStatus, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 FlightID = 4;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //test to see if the result is true
            Assert.IsTrue( Found );
        }

        [TestMethod]

        public void TestFlightIDFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;

            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 4;
            //invoke the method
            Found = AnFlight.Find(FlightID);

            if(AnFlight.FlightID !=4)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestSeatNoFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;

            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 4;
            //invoke the method
            Found = AnFlight.Find(FlightID);

            if (AnFlight.SeatNo != "2a")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDepartureFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;

            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 4;
            //invoke the method
            Found = AnFlight.Find(FlightID);

            if (AnFlight.Departure != "Leicester")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestArrivalFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;

            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 4;
            //invoke the method
            Found = AnFlight.Find(FlightID);

            if (AnFlight.Arrival != "Nottingham")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateandTimeFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;

            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 4;
            //invoke the method
            Found = AnFlight.Find(FlightID);

            if (AnFlight.DateandTime != Convert.ToDateTime("30/05/2024 00:00:00"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestTicketPriceFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;

            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 4;
            //invoke the method
            Found = AnFlight.Find(FlightID);

            if (AnFlight.TicketPrice != Convert.ToDecimal(150))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestFlightStatusFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;

            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 4;
            //invoke the method
            Found = AnFlight.Find(FlightID);

            if (AnFlight.FlightStatus != false)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidOK()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SeatNoMinLessOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime,TicketPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void SeatNoMin()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "s";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SeatNoMinPlusOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "ss";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SeatNoMaxLessOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "sssssssssssssssssssssssssssssssssssssssssssssssss";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SeatNoMax()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "ssssssssssssssssssssssssssssssssssssssssssssssssss";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SeatNoMid()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "sssssssssssssssssssssssss";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SeatNoMaxPlusOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "sssssssssssssssssssssssssssssssssssssssssssssssssss";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void SeatNoExtremeMax()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "";
            SeatNo = SeatNo.PadRight(100, 's');
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DepartureMinLessOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DepartureMin()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "d";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DeparturePlusOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "dd";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DepartureMaxLessOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "ddddddddddddddddddddddddddddddddddddddddddddddddd";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DeapartureMax()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "dddddddddddddddddddddddddddddddddddddddddddddddddd";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DepartureMid()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "dddddddddddddddddddddddd";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DepartureMaxPlusOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "ddddddddddddddddddddddddddddddddddddddddddddddddddd";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DepartureExtremeMax()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "";
            SeatNo = SeatNo.PadRight(100, 'd');
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void ArrivalMinLessOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArrivalMin()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "a";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArrivalPlusOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "aa";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArrivalMaxLessOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArrivalMax()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArrivalMid()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArrivalMaxPlusOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArrivalExtremeMax()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string SeatNo = "";
            SeatNo = SeatNo.PadRight(100, 'a');
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateandTimeExtremeMin()
        {
            clsFlight AnFlight = new clsFlight();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string DateandTime = TestDate.ToString();

            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DateandTimeMinLessOne()
        {
            clsFlight AnFlight = new clsFlight();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string DateandTime = TestDate.ToString();

            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DateandTimeMin()
        {
            clsFlight AnFlight = new clsFlight();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

           

            string DateandTime = TestDate.ToString();

            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateandTimeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateandTime = TestDate.ToString();
            //invoke the method
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        
        public void DateandTimeExtremeMax()
        {
            clsFlight AnFlight = new clsFlight();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);



            string DateandTime = TestDate.ToString();

            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);

            Assert.AreNotEqual(Error, "");

        }
        

        [TestMethod]

        public void DateandTimeInvalidData()
        {
            clsFlight AnFlight = new clsFlight();

            String Error = "";

            string DateandTime = "this is not a date";

            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);

            Assert.AreNotEqual(Error, "");

        }
        
        [TestMethod]
        public void TicketPriceMinLessOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string TicketPrice = "";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]

        public void TicketPriceMin()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string TicketPrice = "0.00";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void TicketPriceMinPlusOne()
        {
            clsFlight AnFlight = new clsFlight();
            string Error = "";
            string TicketPrice = "0.01";
            Error = AnFlight.Valid(SeatNo, Departure, Arrival, DateandTime, TicketPrice);
            Assert.AreEqual(Error, "");
        }


    }
}
