using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the clas we want to create
            clsStaffUser anUser = new clsStaffUser();
            //test to see that it exist 
            Assert.IsNotNull(anUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we wan to create
            clsStaffUser anUser = new clsStaffUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            anUser.UserID = TestData;
            //test to see that the two vlaues are the same
            Assert.AreEqual(anUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser anUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Kinnary";
            //assign the data to the property
            anUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser anUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "kinnary";
            //assign the data to the property
            anUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser anUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Address Book";
            //assign the data to the property
            anUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethod()
        {
            //create an instance of the class we want to create
            clsStaffUser anUser = new clsStaffUser();
            //create a boolean variabl to store the results o the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Kinnary";
            string Password = "kinnary";
            //invoke the method
            Found = anUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsStaffUser anUser = new clsStaffUser();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean varaible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Kinnary";
            string Password = "kinnary";
            //invoke the method
            Found = anUser.FindUser(UserName, Password);
            //check the user id property
            if (anUser.UserName != UserName && anUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
