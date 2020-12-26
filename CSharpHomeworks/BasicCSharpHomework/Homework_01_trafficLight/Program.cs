using System;

namespace Homework_01_trafficLight
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("STOP");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("READY");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("GO");
            Console.ResetColor();
                        
        }
    }
}
