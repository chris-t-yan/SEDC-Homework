using System;

namespace Homework_05_Excercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Display the Day properties(year, month, day, hour, minute, second) from the today's date. 
            //*Expected Output : *year = 2020
            //* month = 3
            //* day = 26
            //* hour = 23
            //* minute = 12
            //* second = 22
            

            Console.WriteLine($"Year: {DateTime.Now.Year} \nMonth: {DateTime.Now.Month} \nDay: {DateTime.Now.Day} \nHour: {DateTime.Now.Hour} \nMinute: {DateTime.Now.Minute} \nSecond: {DateTime.Now.Second}");

            Console.ReadLine();
            
        }
    }
    
}
