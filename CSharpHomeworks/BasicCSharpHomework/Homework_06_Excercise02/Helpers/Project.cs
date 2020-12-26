using System;
using System.Collections.Generic;
using System.Text;
using Homework_06_Excercise02.Entities;

namespace Homework_06_Excercise02.Helpers
{
    public class Project
    {
        public FirstCourse firstCourse1;
        public FirstCourse firstCourse2;
        public SecondCourse secondCourse1;
        public SecondCourse secondCourse2;

        public void Passed(bool project1, bool project2, bool project3, bool project4)
        {
            bool[] allCourses = new bool[4] { project1, project2, project3, project4 };
            int counter = 0;
            foreach (var course in allCourses)
            {
                if (course)
                {
                    counter++;
                }
            }
            if (counter >= 3)
            {
                Console.WriteLine($"You have passed the project with {counter} courses passed ");
            }
            else
            {
                Console.WriteLine($"Sorry, you have failed the project with {4 - counter} failed courses");
            }
        }
    }
}
