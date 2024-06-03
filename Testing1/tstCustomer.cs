using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string Name = "MarinaFr";
        string Email = "marinafr";
        string PaymentDetails = "59755698";
        string BookingId = "2365648";
        string DateAdded = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 44;
            //assign the data to the property
            aCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            aCustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            aCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Email, TestData);
        }

        [TestMethod]
        public void PaymentDetailsPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 44;
            //assign the data to the property
            aCustomer.PaymentDetails = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.PaymentDetails, TestData);
        }

        [TestMethod]
        public void BookingIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 44;
            //assign the data to the property
            aCustomer.BookingID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.BookingID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 44;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 44;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the address id property
            if (aCustomer.CustomerId != 44)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookingIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 44;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the booking id
            if (aCustomer.BookingID != 2365648)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 44;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the dateAdded property
            if (aCustomer.DateAdded != Convert.ToDateTime("22/05/2024"))
            {
                OK = false;
            }
            //tets to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentDetails()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 44;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the house no property
            if (aCustomer.PaymentDetails != 59755698)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestName()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 44;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the house no property
            if (aCustomer.Name != "MarinaFr")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmail()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 44;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the house no property
            if (aCustomer.Email != "marinafr")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 44;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the house no property
            if (aCustomer.Active != true)
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
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(100, 'a');//this should fail
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should fail
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaa"; //this should be ok 16 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(100, 'a');//this should fail
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentDetails = "aaaaa"; //this should fail 5 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentDetails = "aaaaaa"; //this should be ok 6 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentDetails = "aaaaaaa"; //this should be ok 7digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentDetails = "aaaaaaaa"; //this should be ok 8 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentDetails = "aaaaaaaaa"; //this should be ok 9 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentDetails = "aaaaaaaaaa"; //this should fail 10 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMid()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentDetails = "aaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookingIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookingId = "aaaaaa"; //this should fail - 6 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookingIdMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookingId = "aaaaaaa"; //this should be ok 7 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookingIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookingId = "aaaaaaaa"; //this should fail 8 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookingIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookingId = "aaaaaa"; //this should fail 6 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookingIdMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookingId = "aaaaaaa"; //this should be ok - 7 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookingIdPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookingId = "aaaaaaaa"; //this should fail 8 digits
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
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
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
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
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = aCustomer.Valid(Name, Email, PaymentDetails, BookingId, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
