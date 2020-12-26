using System;

namespace Homework_02_Excercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString;
            string secondString;
            firstString = "SEDC";
            secondString = "Academy";
            string firstConcatanation = firstString + " " + secondString;

            string thirdString;
            string forthString;
            thirdString = "9";
            forthString = "3";
            string secondConcatanation = thirdString + forthString;

            Console.WriteLine(firstConcatanation);
            Console.WriteLine(secondConcatanation);

            Console.ReadLine();
        }
    }
}
