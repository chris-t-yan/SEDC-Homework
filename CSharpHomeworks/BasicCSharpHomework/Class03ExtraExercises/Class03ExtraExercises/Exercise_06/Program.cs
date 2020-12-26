using System;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //the day with strings.Example: user enters 1, you should print Monday.

            Console.WriteLine("Enter number form 1 - 7");
            var userInput = Console.ReadLine();
            
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Monday");
                        break;
                    case "2":
                        Console.WriteLine("Tuesday");
                        break;
                    case "3":
                        Console.WriteLine("Wednesday");
                        break;
                    case "4":
                        Console.WriteLine("Thursday");
                        break;
                    case "5":
                        Console.WriteLine("Friday");
                        break;
                    case "6":
                        Console.WriteLine("Saturday");
                        break;
                    case "7":
                        Console.WriteLine("Sunday");
                        break;

                    default:
                    Console.WriteLine("Invalid input, please input number 1-7");
                        break;
                }
        }
    }
}
