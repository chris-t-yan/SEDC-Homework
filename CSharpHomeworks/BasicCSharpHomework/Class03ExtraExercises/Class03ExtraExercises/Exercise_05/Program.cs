using System;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays

            int[] oddEvenArray = new int[] { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            int[] oddArray = new int[] { };
            int[] evenArray = new int[] { };
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 0; i < oddEvenArray.Length; i++)
            {
                if (oddEvenArray[i] % 2 == 0)
                {
                    Array.Resize(ref evenArray, evenArray.Length + 1);
                    evenArray[evenIndex] = oddEvenArray[i];
                    evenIndex++;
                    continue;
                }
                else
                {
                    Array.Resize(ref oddArray, oddArray.Length + 1);
                    oddArray[oddIndex] = oddEvenArray[i];
                    oddIndex++;
                    continue;
                }
            }

            Console.WriteLine("Even numbers are: ");
            foreach (var item in evenArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Odd numbers are: ");
            foreach (var item in oddArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
