using System;
using System.Collections.Generic;

namespace Week5Day3Lab
{
    public  class LibraryManager
    {
        public void AddStudent(Student s)
        {
            s.Age = s.Age = (int)(DateTime.Now.Subtract(s.DoB).TotalDays / 365);
        }

        public Library CheckOutBook(Book book, Student student, DateTime checkedOutDate)
        {
            var result = new Library();
            result.ExpectedReturnDate = checkedOutDate.AddMonths(1);
            result.CheckOutDate = checkedOutDate;
            return result;
        }


        
        public Library CheckInBook(Book book, DateTime droppedOffDate)
        {
            var result = new Library();
            result.ExpectedReturnDate = null;
            result.ActualReturnDate = droppedOffDate;

                return result;
        }
    }
}