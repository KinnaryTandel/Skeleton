using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
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
            Int32 StaffId = 3;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /********** PROPERTY DATA TESTS*************/
        [TestMethod]
        public void TestStaffIdFound() {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Staff id
            if (aStaff.StaffId != 4)
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
            Int32 StaffId = 4;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the fullname property
            if (aStaff.Fullname != "Kinnary Tandel")
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
            Int32 StaffId = 4;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Email property
            if (aStaff.Email != "abc@email.com")
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
            Int32 StaffId = 4;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Pasowrd property
            if (aStaff.Password != "123")
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
            Int32 StaffId = 4;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Phone Number property
            if (aStaff.PhoneNumber != "0123456789")
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
            Int32 StaffId = 4;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //check the Start date property
            if (aStaff.StartDate != Convert.ToDateTime("09/05/2024"))
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
            Int32 StaffId = 4;
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
        

    }
}
