using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        List<double> grades = new List<double>();
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }
    }
}