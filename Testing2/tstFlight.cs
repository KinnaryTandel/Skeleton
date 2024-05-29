using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingFlights
{
    [TestClass]
    public class tstFlight
    {
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

            if (AnFlight.DateandTime != Convert.ToDateTime("27/05/2024"))
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



    }
}
