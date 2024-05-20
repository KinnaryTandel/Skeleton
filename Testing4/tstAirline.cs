using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing4
{
    [TestClass]
    public class tstAirline
    {

        //good data test
        //create some test data to pass the method
        string AirlineName = "Blissful_Travels";
        string AirlineEmail = "Bliss@gmail.com";
        string AirlinePhoneNumber = "75643576";
        string DateAdded = DateTime.Now.ToShortDateString();


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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string varible to store any error message
            String Error = "";
            //invoke the method 
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AirlineNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsAirline AnAirline = new clsAirline();
            //string c=variable to store any error message 
            String Error = "";
            //this should fail
            string AirlineName = "";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirlineNameMin()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlineName = "a";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlineNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlineName = "aa";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlineNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlineName = "";
            AirlineName = AirlineName.PadRight(49, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AirlineNameMax()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlineName = "";
            AirlineName = AirlineName.PadRight(50, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlineNameMid()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            string AirlineName = "";
            AirlineName = AirlineName.PadRight(25, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AirlineNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string AirlineName = "";
            AirlineName = AirlineName.PadRight(51, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The airline name must be less than 50 characters : ");
        }

        [TestMethod]
        public void AirlineNameExtremeMax()
        {
            //create a instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AirlineName = "";
            AirlineName = AirlineName.PadRight(8000, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirlineEmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clsAirline AnAirline = new clsAirline();
            //string c=variable to store any error message 
            String Error = "";
            //this should fail
            string AirlineEmail = "";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirlineEmailMin()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AirlineEmail = "a";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlineEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlineEmail = "aa";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlineEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlineEmail = "";
            AirlineEmail = AirlineEmail.PadRight(49, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AirlineEmailMax()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlineEmail = "";
            AirlineEmail = AirlineEmail.PadRight(50, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlineEmailMid()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            string AirlineEmail = "";
            AirlineEmail = AirlineEmail.PadRight(25, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AirlineEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string AirlineEmail = "";
            AirlineEmail = AirlineEmail.PadRight(51, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "This email must be less than 50 characters");
        }

        [TestMethod]
        public void AirlineEmailExtremeMax()
        {
            //create a instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AirlineEmail = "";
            AirlineEmail = AirlineEmail.PadRight(8000, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirlinePhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create 
            clsAirline AnAirline = new clsAirline();
            //string c=variable to store any error message 
            String Error = "";
            //this should fail
            string AirlinePhoneNumber = "";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirlinePhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlinePhoneNumber = "a";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlinePhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlinePhoneNumber = "aa";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlinePhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlinePhoneNumber = "";
            AirlinePhoneNumber = AirlinePhoneNumber.PadRight(24, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AirlinePhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlinePhoneNumber = "";
            AirlinePhoneNumber = AirlinePhoneNumber.PadRight(25, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AirlinePhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string AirlinePhoneNumber = "";
            AirlinePhoneNumber = AirlinePhoneNumber.PadRight(13, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AirlinePhoneNumberExtremeMax()
        {
            //create a instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AirlinePhoneNumber = "";
            AirlinePhoneNumber = AirlinePhoneNumber.PadRight(1000, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirlinePhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string AirlinePhoneNumber = "";
            AirlinePhoneNumber = AirlinePhoneNumber.PadRight(26, 'a');
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "This phone number must be less than 25 characters :  ");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {

            //create an instance of the class we want to create
            clsAirline AnAirline = new clsAirline();
            //string variable to store any error
            String Error = "";
            //set the DateAdded to a non value date 
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnAirline.Valid(AirlineName, AirlineEmail, AirlinePhoneNumber, DateAdded);
            //test to see that the result is correcr
            Assert.AreNotEqual(Error, "");

        }
    }
}



         