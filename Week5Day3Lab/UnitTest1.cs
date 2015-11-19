using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week5Day3Lab
{
    [TestClass]
    public class LibraryManagerTest
    {
        //Arrange
        //Act
        //Assert

        [TestMethod]
        public void CalculateAge()
        {
            Student bob = new Student();
            //bob.Name = "Bob Anderson";
            bob.DoB = new DateTime(1981, 6, 6);
            //formulate a dob based off today's date
            bob.DoB = DateTime.Now.AddDays(-365 * 45);

            LibraryManager mgr = new LibraryManager();
            mgr.AddStudent(bob);

            Assert.AreEqual(45, bob.Age);
        }

        [TestMethod]
        public void CheckedOutBookDatesSetCorrectly()
        {
            LibraryManager mgr = new LibraryManager();
            var checkoutdate = new DateTime(2005, 5, 5);

            var book = new Book();
            var student = new Student();
            Library result = mgr.CheckOutBook(book, student, checkoutdate);

            Assert.AreEqual(checkoutdate, result.CheckOutDate);
            Assert.AreEqual(checkoutdate.AddMonths(1), result.ExpectedReturnDate);
        }

        [TestMethod]
        public void CheckedInBookDatesSetDates()
        {
            //Arrange
            LibraryManager mgr = new LibraryManager();
            DateTime droppedOffDate = new DateTime(2015, 5, 1);
            Book book = new Book();

            //Act
            Library result = mgr.CheckInBook(book, droppedOffDate);

            //Asserts
            Assert.IsNull(result.ExpectedReturnDate);
            Assert.AreEqual(droppedOffDate, result.ActualReturnDate);
        }
    }
}
