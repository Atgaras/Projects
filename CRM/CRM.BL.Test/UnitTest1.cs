using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM_BL;

namespace CRM.BL.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullNameShouldBeLastNameFirstName()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameWithoutLastName()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LastNameWithoutFirstName()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";

            string expected = "Baggins";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NoLastNameNoFirstName()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "";
            customer.LastName = "";

            string expected = "";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LastNameAndEmailAddress()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAdress = "elektroninis@past.as";
            bool expected = true;

            //--Act
            bool actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            //--Act
            bool actual = customerRepository.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}


