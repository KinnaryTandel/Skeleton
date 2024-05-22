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
            AnFlight.Deperture = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Deperture, TestData);

        }
        [TestMethod]
        public void FlightDateandtimePropertyOk()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnFlight.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.DateAdded, TestData);
        }
        [TestMethod]
        public void FlightArrivalPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            string TestData = "Error";
            //create some test data to assign to the property
            AnFlight.Deperture = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Deperture, TestData);

        }
        [TestMethod]
        public void FlightPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            Decimal TestData = 1;
            //assign the data to the property
            AnFlight.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Price, TestData);
        }
        [TestMethod]
        public void FlightStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property 
            bool TestData = true;
            //assign the data to the property
            AnFlight.reschedule = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnFlight.reschedule, TestData);
        }
    }
}
