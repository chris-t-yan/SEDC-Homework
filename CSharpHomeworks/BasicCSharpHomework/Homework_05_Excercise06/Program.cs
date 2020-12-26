using System;

namespace Homework_05_Excercise06
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //*Find the leap years between 2008 and 2020. * Expected output: *2008 is a leap year. * 2012 is a leap year. * 2016 is a leap year. * 2020 is a leap year.

            //* Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)

            IsLeapYear(2008, 2020);
           
            Console.WriteLine();

            //ANOTHER SOLUTION
            for (int i = 2008; i <= 2020; i++)
            {
                if (DateTime.DaysInMonth(i, 2) == 29)
                {
                    Console.WriteLine($"{i} is leap year");
                }
            }

        }
        public static void IsLeapYear(int startYear, int endYear)
        {
            for (int i = startYear; i <= endYear; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    Console.WriteLine($"{i} is leap year");
                }
            }
        }
    }

}
