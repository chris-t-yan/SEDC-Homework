using System;

namespace Homework_02_Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberValue;
            string textValue;

            numberValue = 5;
            textValue = "stars";

            string toString = Convert.ToString(numberValue);

            string concatanation = toString + " " + textValue;
            Console.WriteLine(concatanation);
            Console.ReadLine();
        }
    }
}
