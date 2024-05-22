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
    }
}







