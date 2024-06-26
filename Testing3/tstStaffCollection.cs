﻿using ClassLibrary;
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create the item of test data
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
            //modify the test record 
            TestItem.IsAdmin = false;
            TestItem.Fullname = "Name Name";
            TestItem.Password = "name";
            TestItem.Email = "name@email.com";
            TestItem.StartDate = DateTime.Now;
            TestItem.PhoneNumber = "1111111111";
            //set the record based on the new test data
            allStaff.ThisStaff = TestItem;
            //update the record
            allStaff.Update();
            //find the record
            allStaff.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(allStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.IsAdmin = true;
            TestItem.StaffId = 1;
            TestItem.Fullname = "Name Name";
            TestItem.Password = "name";
            TestItem.Email = "name@email.com";
            TestItem.StartDate = DateTime.Now;
            TestItem.PhoneNumber = "1111111111";
            //set ThisStaff to the test data
            allStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = allStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            allStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            allStaff.Delete();
            //now find the record
            Boolean Found = allStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullnameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection allStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all record)
            FilteredStaff.ReportByFullname("");
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFullnameNoneFound()
        {
            //cretae an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a full name that doesn't exist
            FilteredStaff.ReportByFullname("xxxxxxxxxxxx xxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByFullnameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a full name that doesn't exist
            FilteredStaff.ReportByFullname("Jake Jake");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check to see that the first record is 68
                if (FilteredStaff.StaffList[0].StaffId != 68)
                {
                    OK = false;
                }
                //check to see that the first record is 69
                if (FilteredStaff.StaffList[1].StaffId != 69)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
