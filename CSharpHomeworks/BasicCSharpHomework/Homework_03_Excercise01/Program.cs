using System;

namespace Homework_03_Excercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //            EXERCISE 01:

            //Get an input number from the console
            //Print all numbers from 1 to that number
            //Get another input number from the console
            //Print all numbers from that number to 1

            Console.WriteLine("Insert number to print all numbers from 1 to that number");
            var firstUserInput = Console.ReadLine();

            int firstNumber;
            bool firstConversion = int.TryParse(firstUserInput, out firstNumber);

            if (firstConversion) 
            {
                for (int i=1; i <= firstNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Insert another number to print all numbers from that number to 1");
            var secondUserInput = Console.ReadLine();
            int secondNumber;
            bool secondConversion = int.TryParse(secondUserInput, out secondNumber);

            if (secondConversion)
            {
                for (int i = secondNumber; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            

        }
    }
}
