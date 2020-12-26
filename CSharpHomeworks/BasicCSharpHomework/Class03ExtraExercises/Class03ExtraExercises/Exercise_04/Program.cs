using System;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            //Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            int[] numbers = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length-1; j++)
                {
                    if (numbers[i] == numbers[j + 1])
                    {
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements in array is {0}", counter);

            Console.ReadLine();
        }
    }
}
