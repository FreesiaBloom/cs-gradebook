using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades = new List<double>();
        public string Name;
        
        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var number in this.grades)
            {
                result.High = Math.Max(number, result.High);
                result.Low = Math.Min(number, result.Low);
                result.Average += number;
            }

            result.Average /= grades.Count;

            return result;
        }
    }
}