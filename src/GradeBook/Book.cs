using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades = new List<double>();
        
        public Book(string name)
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (double number in this.grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;

            System.Console.WriteLine($"The average grade is {result:N1}, the lowest grade is {lowGrade}, and the highest is {highGrade}");
        }
    }
}