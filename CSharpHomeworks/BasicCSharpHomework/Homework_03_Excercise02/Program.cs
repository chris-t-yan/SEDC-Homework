using System;

namespace Homework_03_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //            EXERCISE 02:

            //Get an input number from the console
            //Print all even numbers starting from 2
            //Get another input number from the console
            //Print all odd numbers starting from 1

            Console.WriteLine("Insert number");
            var firstUserInput = Console.ReadLine();

            int firstNumber;
            bool firstConversion = int.TryParse(firstUserInput, out firstNumber);

            if (firstConversion)
            {
                Console.WriteLine("Even numbers are:");
                for (int i = 2; i <= firstNumber; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.WriteLine("Insert another number");
            var secondUserInput = Console.ReadLine();

            int secondNumber;
            bool secondConversion = int.TryParse(secondUserInput, out secondNumber);

            if (secondConversion)
            {
                Console.WriteLine("Odd numbers are:");
                for (int i = 1; i <= secondNumber; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
