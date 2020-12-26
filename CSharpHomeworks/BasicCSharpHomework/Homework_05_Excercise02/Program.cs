using System;

namespace Homewrok_05_Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Count the total number of words in a string entered by the user. *Example: user enters "I love C#" *Expected output: "I love c#" contains 3 words

            Console.WriteLine("Enter some senttence");
            string userInput = Console.ReadLine();
            int counter = 1;
            for (int i = 0; i <= userInput.Length-1; i++)
            {
                if (userInput[i] == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine($"{userInput} has {counter} words");
          

            //  ANOTHER SOLUTION
            string[] splitCounter = userInput.Split(" ");
            Console.WriteLine($"{userInput} has {splitCounter.Length} words");


            Console.ReadLine();

        }
    }
}
