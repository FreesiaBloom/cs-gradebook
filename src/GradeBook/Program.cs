﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book();
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            var result = 0.0;

            book.AddGrade(86.1);


            foreach (double number in grades)
            {
                result += number;
            }

            result /= grades.Count;

            System.Console.WriteLine($"The average grade is {result:N1}!");
        }
    }
}
