using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson07_03;

namespace Lesson07_03.tax.test
{
    [TestClass]
    public class TaxTests
    {
        [TestMethod]
        public void TaxShouldCalculate5PercentWhenIncomeIs40000()
        {
            //Arrange
            decimal income = 1000;
            decimal tax = 50;
            decimal calculatedTax = 0;

            //Act
            calculatedTax = Program.Tax(income);

            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }
        [TestMethod]
        public void TaxShouldCalculate15PercentWhenIncomeIsEqual100000()
        {
            //Arrange
            decimal income = 100000;
            decimal tax = 15000;
            decimal calculatedTax = 0;

            //Act
            calculatedTax = Program.Tax(income);

            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }
        [TestMethod]
        public void TaxShouldCalculate25PercentWhenIncomeIsMoreThan1000000()
        {
            //Arrange
            decimal income = 1000000;
            decimal tax = 250000;
            decimal calculatedTax = 0;

            //Act
            calculatedTax = Program.Tax(income);

            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }
        [TestMethod]
        public void TaxShouldReturn0WhenIncomeIs0()
        {
            //Arrange
            decimal income = 0;
            decimal tax = 0;
            decimal calculatedTax = 0;

            //Act
            calculatedTax = Program.Tax(income);

            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }
        [TestMethod]
        public void TaxShouldReturn0PercentWhenIncomeIsLessThan0()
        {
            //Arrange
            decimal income = -10;
            decimal tax = 0;
            decimal calculatedTax = 0;

            //Act
            calculatedTax = Program.Tax(income);

            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }
    }
}
