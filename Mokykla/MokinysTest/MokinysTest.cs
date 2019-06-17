using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MokinysBL;

namespace MokinysTest
{
    [TestClass]
    public class MokinysTests
    {
        [TestMethod]
        public void PazymiuVidurkisShouldreturn0WhenNoGrades()
        {
            //Assign
            Mokinys mokinys = new Mokinys(9, "Petras", true);
            int actual = 0;
            int expected = 0;
            //Act
            actual = mokinys.PazymiuVidurkis();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PazymiuVidurkisShouldReturnOneGrade()
        {
            //Assign
            Mokinys mokinys = new Mokinys(9, "Petras", true);
            mokinys.PazymiuSarasas.Add(9);
            int actual = 9;
            int expected = 9;
            //Act
            actual = mokinys.PazymiuVidurkis();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PazymiuVidurkisShouldReturnTwoGrades()
        {
            //Assign
            Mokinys mokinys = new Mokinys(9, "Petras", true);
            mokinys.PazymiuSarasas.Add(10);
            mokinys.PazymiuSarasas.Add(8);
            int actual = 9;
            int expected = 9;
            //Act
            actual = mokinys.PazymiuVidurkis();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
