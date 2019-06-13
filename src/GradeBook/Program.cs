using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Bartek's Grade Book");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.6);
            book.AddGrade(86.1);
            book.AddGrade(76.2);
            book.AddGrade(92.3);
            book.AddGrade(75.4);
            book.AddGrade(53.7);
            book.ShowStatistics();

            
        }
    }
}
