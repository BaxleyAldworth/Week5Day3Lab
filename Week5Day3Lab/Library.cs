using System;

namespace Week5Day3Lab
{
    public class Library
    {
        public int ID { get; set; }
        public int bookID { get; set; }
        public int studentID { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
    }
}