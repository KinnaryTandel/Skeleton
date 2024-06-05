﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstFlightCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //test to see that is exists
            Assert.IsNotNull(AllFlights);
        }

        [TestMethod]
        public void FlightListOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsFlight>TestList = new List<clsFlight>();
            //Add an item to the list
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //set its properties
            TestItem.FlightID = 1;
            TestItem.SeatNo = "2b";
            TestItem.Departure = "London";
            TestItem.Arrival = "Birmingham";
            TestItem.DateandTime = DateTime.Now;
            TestItem.TicketPrice = 200;
            TestItem.FlightStatus = false;

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllFlights.FlightList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.FlightList, TestList);
        }

       

        [TestMethod]

        public void ThisFlightPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            clsFlight TestFlight = new clsFlight();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //set its properties
            TestItem.FlightID = 1;
            TestItem.SeatNo = "2b";
            TestItem.Departure = "London";
            TestItem.Arrival = "Birmingham";
            TestItem.DateandTime = DateTime.Now;
            TestItem.TicketPrice = 200;
            TestItem.FlightStatus = false;
            //assign the data to the proprty
            AllFlights.ThisFlight = TestFlight;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.ThisFlight, TestFlight);

        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsFlight> TestList = new List<clsFlight>();
            //Add an item to the list
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //set its properties
            TestItem.FlightID = 1;
            TestItem.SeatNo = "2b";
            TestItem.Departure = "London";
            TestItem.Arrival = "Birmingham";
            TestItem.DateandTime = DateTime.Now;
            TestItem.TicketPrice = 200;
            TestItem.FlightStatus = false;

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllFlights.FlightList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.Count, TestList.Count);
        }

        
    }
}
