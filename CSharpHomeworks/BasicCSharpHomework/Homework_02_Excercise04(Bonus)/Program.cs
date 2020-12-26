using System;

namespace Homework_02_Excercise04_Bonus_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number");
            var userInput = Console.ReadLine();
            int parsedValue;
            bool isParsed = int.TryParse(userInput, out parsedValue);
            if (isParsed)
            {
                if (parsedValue % 2 == 0)
                    Console.WriteLine("Number " + parsedValue + " is even");
                else 
                    Console.WriteLine("Number " + parsedValue + " is odd");
            }
            else 
                Console.WriteLine("Invalid input, please input valid number");

            Console.ReadLine();

        }

    }
    
}
