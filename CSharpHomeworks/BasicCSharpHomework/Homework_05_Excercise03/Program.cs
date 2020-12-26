using System;

namespace Homework_05_Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Find maximum occurring character in a string* Example: "We want this situation with covid-19 to ends!" * Expected Output: The highest frequency of character 't' appears number of times : 6

            string testString = "We want this situation with covid-19 to ends!";
            Console.Write("Max occurring character is " + MostOccurringCharInString(testString));

            Console.ReadLine();

        }
        public static char MostOccurringCharInString(string charString)
        {
            int counter = 0;
            char mostOccurringChar = ' ';
            foreach (char currentChar in charString)
            {
                int foundCharOccreence = 0;
                foreach (char charToBeMatch in charString)
                {
                    if (currentChar == charToBeMatch && currentChar != ' ')
                        foundCharOccreence++;
                }
                if (counter < foundCharOccreence)
                {
                    counter = foundCharOccreence;
                    mostOccurringChar = currentChar;
                }
            }
            return mostOccurringChar;
        }
    }

}
