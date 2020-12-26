using System;

namespace Homework_02_Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int credits = 103;
            int smsCost = 5;

            var remainingSms = credits / smsCost;
            var remaningCredit = credits % smsCost;

            Console.WriteLine("You have " + remainingSms + " sms left, and " + remaningCredit + " credits left");
            Console.ReadLine();
        }
    }
}
