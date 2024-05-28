using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ClassLibrary
{
    [TestClass]
    public class tstAirlineCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we wan to create
            clsAirlineCollection AllAirlines = new clsAirlineCollection();
            //test to see if it exists
            Assert.IsNotNull(AllAirlines);
        }


        [TestMethod]
        public void AirlineListOK()
        {
            //create an instance of the class we want to create
            clsAirlineCollection AllAirlines = new clsAirlineCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsAirline> TestList = new List<clsAirline>();
            //add an item to the list 
            //create the item of test data 
            clsAirline TestItem = new clsAirline();
            //set its properties
            TestItem.WiFi = true;
            TestItem.AirlineID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.AirlineName = "Blissful Travels";
            TestItem.AirlineEmail = "BlissfulTravels@gmail.com";
            TestItem.AirlinePhoneNumber = 75643576;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAirlines.AirlineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAirlines.AirlineList, TestList);
        }


        [TestMethod]
        public void ThisAirlinePropertyOK()
        {
            //create an instance of the class we want to create
            clsAirlineCollection AllAirlines = new clsAirlineCollection();
            //create some test data to assign to the property 
            clsAirline TestAirline = new clsAirline();
            //set its properties of the test object 
            TestAirline.WiFi = true;
            TestAirline.AirlineID = 2;
            TestAirline.DateAdded = DateTime.Now;
            TestAirline.AirlineName = "Blissful Travels";
            TestAirline.AirlineEmail = "BlissfulTravels@gmail.com";
            TestAirline.AirlinePhoneNumber = 75643576;
            //assign the data to the property
            AllAirlines.ThisAirline = TestAirline;
            //test to see that the two values are the same
            Assert.AreEqual(AllAirlines.ThisAirline, TestAirline);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsAirlineCollection AllAirlines = new clsAirlineCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsAirline> TestList = new List<clsAirline>();
            //add an item to the list 
            //create the item of test data 
            clsAirline TestItem = new clsAirline();
            //set its properties
            TestItem.WiFi = true;
            TestItem.AirlineID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.AirlineName = "Blissful Travels";
            TestItem.AirlineEmail = "BlissfulTravels@gmail.com";
            TestItem.AirlinePhoneNumber = 75643576;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAirlines.AirlineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAirlines.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsAirlineCollection AllAirlines = new clsAirlineCollection();
            //create the item of test data
            clsAirline TestItem = new clsAirline();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.WiFi = true;
            TestItem.AirlineID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.AirlineName = "Blissful Travels";
            TestItem.AirlineEmail = "BlissfulTravels@gmail.com";
            TestItem.AirlinePhoneNumber = 75643576;
            //set this airline to the test data
            AllAirlines.ThisAirline = TestItem;
            //add the record
            PrimaryKey = AllAirlines.Add();
            //set the primary key of the test data 
            TestItem.AirlineID = PrimaryKey;
            //find the record 
            AllAirlines.ThisAirline.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllAirlines.ThisAirline, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsAirlineCollection AllAirlines = new clsAirlineCollection();
            //create the item of test data
            clsAirline TestItem = new clsAirline();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.WiFi = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.AirlineName = "Blissful Travels";
            TestItem.AirlineEmail = "BlissfulTravels@gmail.com";
            TestItem.AirlinePhoneNumber = 75643576;
            //set ThisAirline to the test data
            AllAirlines.ThisAirline = TestItem;
            //add the record
            PrimaryKey = AllAirlines.Add();
            //set the primary key of the test data 
            TestItem.AirlineID = PrimaryKey;
            //modify the test record
            TestItem.WiFi = false;
            TestItem.DateAdded = DateTime.Now;
            TestItem.AirlineName = "BlissfulTravels2";
            TestItem.AirlineEmail = "BlissfulTravels2@gmail.com";
            TestItem.AirlinePhoneNumber = 73096019;
            //set this record based on the new test data
            AllAirlines.ThisAirline = TestItem;
            //update the record
            AllAirlines.Update();
            //find the record 
            AllAirlines.ThisAirline.Find(PrimaryKey);
            //test to see if ThisAirline matches the test data
            Assert.AreEqual(AllAirlines.ThisAirline, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsAirlineCollection AllAirlines = new clsAirlineCollection();
            //create the item of test data
            clsAirline TestItem = new clsAirline();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AirlineID = 1;
            TestItem.WiFi = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.AirlineName = "Blissful Travels";
            TestItem.AirlineEmail = "BlissfulTravels@gmail.com";
            TestItem.AirlinePhoneNumber = 75643576;
            //set ThisAirline to the test data
            AllAirlines.ThisAirline = TestItem;
            //add the record
            PrimaryKey = AllAirlines.Add();
            //set the primary key of the test data
            TestItem.AirlineID = PrimaryKey;
            //find the record 
            AllAirlines.ThisAirline.Find(PrimaryKey);
            //delete the record
            AllAirlines.Delete();
            //now find the record
            Boolean Found = AllAirlines.ThisAirline.Find(PrimaryKey);
            //test to see if ThisAirline matches the test data
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByAirlineNameMethodOK()
        {
            //create an instance of the class containing unfiltered results 
            clsAirlineCollection AllAirlines = new clsAirlineCollection();
            //create an instance of the filtered data
            clsAirlineCollection FilteredAirlines = new clsAirlineCollection();
            //apply a blank string (should return all records);
            FilteredAirlines.ReportByAirlineName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAirlines.Count,  FilteredAirlines.Count);    
        }

        [TestMethod]
        public void ReportByAirlineNameNoneFound()
        {
            //create an instance of the class we want to create
            clsAirlineCollection FilteredAirlines = new clsAirlineCollection();
            //apply an airline name that doesn't exist
            FilteredAirlines.ReportByAirlineName("xxxxxxxxxxxxxxxxxxxxx");
            //test to see if there are no records 
            Assert.AreEqual(0, FilteredAirlines.Count);
        }

        [TestMethod]
        public void ReportByAirlineNameTestDataFound()
        {
            //create an instance of the filtered data 
            clsAirlineCollection FilteredAirlines = new clsAirlineCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply an airline name that doesn't exist
            FilteredAirlines.ReportByAirlineName("BlissfulTravels3");
            //check that the correct number of records are found
            if (FilteredAirlines.Count == 2) 
            {
                //check to see that the first record is 55
                if (FilteredAirlines.AirlineList[0].AirlineID != 55)
                {
                    OK = false;
                }
                //check to see that the first record is 56
                if (FilteredAirlines.AirlineList[1].AirlineID != 56)
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








