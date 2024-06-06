using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that is exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create an item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 11;
            TestItem.Name = "MarinaFr";
            TestItem.Email = "marinafr";
            TestItem.PaymentDetails = 59755698;
            TestItem.BookingID = 2365648;
            TestItem.DateAdded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerId = 11;
            TestCustomer.Name = "MarinaFr";
            TestCustomer.Email = "marinafr";
            TestCustomer.PaymentDetails = 59755698;
            TestCustomer.BookingID = 2365648;
            TestCustomer.DateAdded = DateTime.Now;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 11;
            TestItem.Name = "MarinaFr";
            TestItem.Email = "marinafr";
            TestItem.PaymentDetails = 59755698;
            TestItem.BookingID = 2365648;
            TestItem.DateAdded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 11;
            TestItem.Name = "MarinaFr";
            TestItem.Email = "marinafr";
            TestItem.PaymentDetails = 59755698;
            TestItem.BookingID = 2365648;
            TestItem.DateAdded = DateTime.Now;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 11;
            TestItem.Name = "MarinaFr";
            TestItem.Email = "marinafr";
            TestItem.PaymentDetails = 59755698;
            TestItem.BookingID = 2365648;
            TestItem.DateAdded = DateTime.Now;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test record
            TestItem.Active = false;
            TestItem.CustomerId = 15;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Name = "MarinaNext";
            TestItem.Email = "marinanext";
            TestItem.BookingID = 2398148;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 11;
            TestItem.Name = "MarinaFr";
            TestItem.Email = "marinafr";
            TestItem.PaymentDetails = 59755698;
            TestItem.BookingID = 2365648;
            TestItem.DateAdded = DateTime.Now;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByNameMethodOk()
        {
            //create an instance of the class containing unfiltered results 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string ( should return all records )
            FilteredCustomers.ReportByName("");
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a name that doesn't exist
            FilteredCustomers.ReportByName("xxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store the outcome

            Boolean OK = true;

            //apply a name that doesn't exist
            FilteredCustomers.ReportByName("MarinaFr");
            //check that the correct number of records are found
            if (FilteredCustomers.Count != 2)
            {
                //check to see that the first record is 44
                if (FilteredCustomers.CustomerList[0].CustomerId != 44)
                {
                    OK = false;
                }
                //check to see that the first record is 45
                if (FilteredCustomers.CustomerList[1].CustomerId != 45)
                {
                    OK = false;
                }
            }
            else 
            {
                OK = false ; 
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
    }

