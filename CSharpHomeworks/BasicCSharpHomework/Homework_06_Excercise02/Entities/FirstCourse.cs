using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_06_Excercise02.Entities
{
    public class FirstCourse
    {
        public FirstCourse(string nameOfCourse, bool isPassed)
        {
            CourseName = nameOfCourse;
            IsPassed = isPassed;
        }

        public string CourseName;
        public bool IsPassed;

        public bool Passed(bool passed)
        {
            if (passed)
            {
                IsPassed = true;
            }
            else
            {
                IsPassed = false;
            }
            return IsPassed;
        }
    }
}
