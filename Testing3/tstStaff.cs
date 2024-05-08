using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(aStaff);
        }

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
    }
}
