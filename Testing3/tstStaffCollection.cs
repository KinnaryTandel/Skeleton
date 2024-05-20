using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsAdmin = true;
            TestItem.StaffId = 6;
            TestItem.Fullname = "Sam Smith";
            TestItem.Email = "sam@email.com";
            TestItem.Password = "sam";
            TestItem.PhoneNumber = "5678912340";
            TestItem.StartDate = DateTime.Now;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            allStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object 
            TestStaff.IsAdmin = true;
            TestStaff.StaffId = 6;
            TestStaff.Fullname = "Sam Smith";
            TestStaff.Email = "sam@email.com";
            TestStaff.Password = "sam";
            TestStaff.PhoneNumber = "5678912340";
            TestStaff.StartDate = DateTime.Now;
            //assign the data to the property
            allStaff.ThisStaff = TestStaff;
            //test to see tha the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsAdmin = true;
            TestItem.StaffId = 6;
            TestItem.Fullname = "Sam Smith";
            TestItem.Email = "sam@email.com";
            TestItem.Password = "sam";
            TestItem.PhoneNumber = "5678912340";
            TestItem.StartDate = DateTime.Now;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            allStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsAdmin = true;
            TestItem.StaffId = 1;
            TestItem.Fullname = "Some Name";
            TestItem.Password = "Password";
            TestItem.Email = "some@email.com";
            TestItem.StartDate = DateTime.Now;
            TestItem.PhoneNumber = "0123456789";
            //set ThisAddress to the test data
            allStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = allStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            allStaff.ThisStaff.Find(PrimaryKey);
            //test to see tha the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, TestItem);
        }
    }
}
