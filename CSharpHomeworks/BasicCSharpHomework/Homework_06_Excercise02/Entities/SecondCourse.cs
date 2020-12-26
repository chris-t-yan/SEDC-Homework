using System;
using System.Collections.Generic;
using System.Text;
using Homework_06_Excercise02.Enums;

namespace Homework_06_Excercise02.Entities
{
    public class SecondCourse
    {
        public SecondCourse(string nameOfCourse, Grade grade)
        {
            CourseName = nameOfCourse;
            StudentGrade = grade;
        }

        public string CourseName;
        public Grade StudentGrade;

        public bool Passed(int studentGrade)
        {
            if ((int)studentGrade > 5 && (int)studentGrade <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
