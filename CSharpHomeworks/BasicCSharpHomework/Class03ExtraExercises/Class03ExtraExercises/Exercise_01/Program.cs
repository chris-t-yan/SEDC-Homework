using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to find the sum of first 10 natural numbers

            int result = 0;
            for (int i = 0; i <= 10; i++)
            {
                result += i;
            }
            Console.WriteLine("The sum of first 10 natural numbers is {0}", result);

            Console.ReadLine();
        }
    }
}
