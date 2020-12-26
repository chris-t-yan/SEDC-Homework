using System;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and init array of 10 integers by your choise. 
            //Find maximum and minimum element in that array and their indexes.

            int[] numbers = new int[] { 10, 2, 13, 9, 4, 7, 20, 14, 8, 3 };

            int biggest = numbers[0];
            int indexOfBiggest = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];
                    indexOfBiggest = Array.IndexOf(numbers, numbers[i]);
                }
            }
            Console.WriteLine("Biggest number in the array is {0} and it's on array index No {1}" , biggest, indexOfBiggest);

            var smallest = numbers[0];
            var indexOfSmallest = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                    indexOfSmallest = Array.IndexOf(numbers, numbers[i]);
                }
            }
            Console.WriteLine("Smallest number in the array is {0} and it's on array index No {1}", smallest, indexOfSmallest);

            Console.ReadLine();
        } 
    }
}
