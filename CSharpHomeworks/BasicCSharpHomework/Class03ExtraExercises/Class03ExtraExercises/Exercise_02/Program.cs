using System;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            

            int[] numbers = new int[10];
           
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("enter the next number:");
                var userInput = Console.ReadLine();
                
                int number;
                bool conversion = int.TryParse(userInput, out number);

                if (conversion)
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input, please input valid numbers !!!");
                    return;
                }
                
            }

            int sum = 0;
            foreach (var element in numbers)
            {
               sum += element;
            }
            Console.WriteLine("Sum of the numbers is {0} ", sum);

            double sumDouble = Convert.ToDouble(sum);
            double avg = sumDouble / numbers.Length;
            Console.WriteLine("Average of the numbers is {0}", avg);

            Console.ReadLine();
        }
    }
}
