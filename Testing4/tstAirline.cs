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
        public void AddressIDPropertyOK()
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

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with method
            Int32 AirlineID = 2;
            //invoke the method
            Found = AnAirline.Find(AirlineID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]

        public void TestAirlineIDFound()
        {
            //create an instance of the class we want to create 
            clsAirline AnAirline = new clsAirline();
            //create a boolean variable  to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 AirlineID = 2;
            //invoke the method
            Found = AnAirline.Find(AirlineID);
            //check the airline ID
            if (AnAirline.AirlineID != 2)
            {
                OK = false;
            }
            //test to see if the result is coreect
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AirlineID = 2;
            //invoke the method
            Found = AnAirline.Find(AirlineID);
            //check the date property
            if (AnAirline.DateAdded != Convert.ToDateTime("14/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAirlineNameFound()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AirlineID = 2;
            //invoke the method
            Found = AnAirline.Find(AirlineID);
            //check the airline name
            if (AnAirline.AirlineName != "Blissful_Travels")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAirlineEmailFound()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AirlineID = 2;
            //invoke the method
            Found = AnAirline.Find(AirlineID);
            //check the airline email property
            if (AnAirline.AirlineEmail != "Bliss@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAirlinePhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AirlineID = 2;
            //invoke the method
            Found = AnAirline.Find(AirlineID);
            //check the airline phone number property
            if (AnAirline.AirlinePhoneNumber != 73056015)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestWiFiFound()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AirlineID = 2;
            //invoke the method
            Found = AnAirline.Find(AirlineID);
            //check the WiFi property
            if (AnAirline.WiFi != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
