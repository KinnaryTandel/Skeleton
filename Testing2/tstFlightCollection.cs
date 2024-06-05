using ClassLibrary;
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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FlightID = 1;
            TestItem.SeatNo = "2b";
            TestItem.Departure = "London";
            TestItem.Arrival = "Birmingham";
            TestItem.DateandTime = DateTime.Now;
            TestItem.TicketPrice = 200;
            TestItem.FlightStatus = false;

            //set thisflight to the test data
            AllFlights.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestItem.FlightID = PrimaryKey;
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.ThisFlight, TestItem);

        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FlightID = 1;
            TestItem.SeatNo = "2b";
            TestItem.Departure = "London";
            TestItem.Arrival = "Birmingham";
            TestItem.DateandTime = DateTime.Now;
            TestItem.TicketPrice = 200;
            TestItem.FlightStatus = false;
            //set thisflight to the test data
            AllFlights.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestItem.FlightID = PrimaryKey;
            //modify the test record
            TestItem.SeatNo = "3h";
            TestItem.Departure = "America";
            TestItem.Arrival = "ThaiLand";
            TestItem.DateandTime = DateTime.Now;
            TestItem.TicketPrice = 700;
            TestItem.FlightStatus = false;
            //set the record bases on new test data
            AllFlights.ThisFlight = TestItem;
            //update the record
            AllFlights.Update();
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see of if thisflight matches the test data
            Assert.AreEqual(AllFlights.ThisFlight, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FlightID = 1;
            TestItem.SeatNo = "2b";
            TestItem.Departure = "London";
            TestItem.Arrival = "Birmingham";
            TestItem.DateandTime = DateTime.Now;
            TestItem.TicketPrice = 200;
            TestItem.FlightStatus = false;
            //set thisflight to the test data
            AllFlights.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestItem.FlightID = PrimaryKey;
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //delete the record
            AllFlights.Delete();
            //now find the record 
            Boolean Found = AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void ReportBySeatNoMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create an intance of the filteres data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //apply a blank string (should return all record)
            FilteredFlights.ReportBySeatNo("");
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.Count, FilteredFlights.Count);
        }

        [TestMethod]

        public void ReportBySeatNoNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create an intance of the filteres data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //apply a seat no that doesn't exist
            FilteredFlights.ReportBySeatNo("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredFlights.Count);
        }

        [TestMethod]

        public void ReportBySeatNoTestDataFound()
        {
            //create an intance of the filteres data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //variable to store the outcome
            Boolean OK = true;

            //apply a seat no that doesn't exist
            FilteredFlights.ReportBySeatNo("3h");
            //check that the correct number of records are found
            if (FilteredFlights.Count == 2)
            {
                //check to see that the first record is 1016
                if (FilteredFlights.FlightList[0].FlightID != 1016)
                {
                    OK = false;
                }

                //CHECK to see that the first record is 1019
                if (FilteredFlights.FlightList[1].FlightID != 1019)
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
