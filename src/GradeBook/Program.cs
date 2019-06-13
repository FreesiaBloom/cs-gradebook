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
            book.AddGrade(77.3);

            var stats = book.GetStatistics();


            System.Console.WriteLine($"The average grade is {stats.Average:N1}, the lowest grade is {stats.Low}, and the highest is {stats.High}");
        }
    }
}
