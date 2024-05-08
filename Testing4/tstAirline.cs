using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstAirline
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //test to see that it exists
            Assert.IsNotNull(AnAirline);
        }

        [TestMethod]
        public void HasWiFiPropertyOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AnAirline.WiFi = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAirline.WiFi, TestData);
        }

        [TestMethod]
        public void RegistrationDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAirline.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAirline.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAirline.AirlineID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAirline.AirlineID, TestData);
        }

        [TestMethod]
        public void AirlineNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create some test data to assign to the property
            string TestData = "Blissful Travels";
            //assign the data to the property
            AnAirline.AirlineName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAirline.AirlineName, TestData);
        }

        [TestMethod]
        public void AirlineEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create some test data to assign to the property
            string TestData = "Blissfulltravels@gmail.com";
            //assign the data to the property
            AnAirline.AirlineEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAirline.AirlineEmail, TestData);
        }

        [TestMethod]
        public void AirlinePhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAirline.AirlinePhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAirline.AirlinePhoneNumber, TestData);

    }

  }
}
