using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices.ComTypes;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        string Fullname = "Sam Smith";
        string Email = "sam@email.com";
        string Password = "sam";
        string PhoneNumber = "5678912340";
        string StartDate = DateTime.Now.ToShortDateString();

        /********** INSTANCE OF THE CLASS TEST*************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(aStaff);
        }

        /********** PROPERTY OK TESTS *************/
        [TestMethod]
        public void IsAdminPropertyOK() {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.IsAdmin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.IsAdmin, TestData);
        }

        [TestMethod]
        public void StartDatePropertyOK() { 
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStaff.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StartDate, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK() {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffId, TestData);
        }

        [TestMethod]
        public void FullnamePropertyOK() { 
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Firstname Lastname";
            //assign the data to the property
            aStaff.Fullname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Fullname, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK() {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "abc@email.com";
            //assign the data to the property
            aStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK() {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Password";
            //assign the data to the property
            aStaff.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Password, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK() {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "0123456789";
            //assign the data to the property
            aStaff.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.PhoneNumber, TestData);
        }

        /********** FIND METHOD TEST *************/
        [TestMethod]
        public void FindMethodOK() {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /********** PROPERTY DATA TESTS *************/
        [TestMethod]
        public void TestStaffIdFound() {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Staff id property
            if (aStaff.StaffId != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFullnameFound() { 
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the fullname property
            if (aStaff.Fullname != "Sam Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Email property
            if (aStaff.Email != "sam@email.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Pasowrd property
            if (aStaff.Password != "sam")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Phone Number property
            if (aStaff.PhoneNumber != "5678912340")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffStartDateFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Start date property
            if (aStaff.StartDate != Convert.ToDateTime("11/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        
        [TestMethod]
        public void TestStaffIsAdminFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the fullname property
            if (aStaff.IsAdmin != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /********** VALIDATION TESTS *************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /********** FULLNAME VALIDATION TESTS *************/
        [TestMethod]
        public void FullnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string fullname = ""; //this should trigger an error
            //invoke the method
            Error = aStaff.Valid(fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullnameMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string fullname = "a"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string fullname = "aa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string fullname = "";
            fullname = fullname.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = aStaff.Valid(fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void FullnameMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string fullname = "";
            fullname = fullname.PadRight(50, 'a');//this should be ok
            //invoke the method
            Error = aStaff.Valid(fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullnameMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string fullname = "";
            fullname = fullname.PadRight(25, 'a');//this should be ok
            //invoke the method
            Error = aStaff.Valid(fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullnameMaxPlusOne() 
        { 
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string fullname = "";
            fullname = fullname.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string fullname = "";
            fullname = fullname.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /********** DATE VALIDATION TESTS *************/
        [TestMethod]
        public void StartDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create  a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date varible to a string variable
            string startdate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, startdate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string startdate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, startdate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string startdate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, startdate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string startdate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, startdate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string startdate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, startdate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData() 
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //set the StartDate to a non date value
            string StartDate = "this is not a date!";
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /********** EMAIL VALIDATION TESTS *************/
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string email = ""; //this should trigger an error
            //invoke the method
            Error = aStaff.Valid(Fullname, email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string email = "a"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string email = "aa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string email = "";
            email = email.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string email = "";
            email = email.PadRight(50, 'a');//this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string email = "";
            email = email.PadRight(25, 'a');//this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string email = "";
            email = email.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(Fullname, email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string email = "";
            email = email.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(Fullname, email, Password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /********** PASSWORD VALIDATION TESTS *************/
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string password = ""; //this should trigger an error
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string password = "a"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string password = "aa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string password = "";
            password = password.PadRight(15, 'a'); //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string password = "";
            password = password.PadRight(16, 'a');//this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string password = "";
            password = password.PadRight(8, 'a');//this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string password = "";
            password = password.PadRight(17, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string password = "";
            password = password.PadRight(30, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, password, StartDate, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /********** PHONE NUMBER VALIDATION TESTS *************/
        [TestMethod]
        public void PhoneNumMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string phone = ""; //this should trigger an error
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string phone = "a"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string phone = "aa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string phone = "";
            phone = phone.PadRight(9, 'a'); //this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string phone = "";
            phone = phone.PadRight(10, 'a');//this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string phone = "";
            phone = phone.PadRight(5, 'a');//this should be ok
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string phone = "";
            phone = phone.PadRight(11, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string phone = "";
            phone = phone.PadRight(30, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(Fullname, Email, Password, StartDate, phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
