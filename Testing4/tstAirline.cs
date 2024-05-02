using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstAirline
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsAirline AnAirline = new clsAirline();
            //test to see that it exists
            Assert.IsNotNull(AnAirline);
        }
    }
}
