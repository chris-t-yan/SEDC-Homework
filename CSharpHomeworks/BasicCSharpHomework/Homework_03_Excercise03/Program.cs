using System;

namespace Homework_03_Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            //            EXERCISE 03:

            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop

         
            string[] outputNames = new string[] { };
            int index = 0;
            string validation;

            for (int i = 0; ; i++)
            {
                Console.WriteLine("Do you want to enter name? Enter y/n ");
                validation = Console.ReadLine();
                

                if (validation == "y") {
                    Array.Resize(ref outputNames, outputNames.Length + 1);
                    Console.WriteLine("Enter next name");
                    string anotherName = Console.ReadLine();
                    outputNames[index] = anotherName;
                    index++;
                    continue;
                }

                else if (validation == "n")
                {
                    foreach (var item in outputNames)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                else
                    Console.WriteLine("Invalid input");
               }
            Console.ReadLine();
        }
    }
}
