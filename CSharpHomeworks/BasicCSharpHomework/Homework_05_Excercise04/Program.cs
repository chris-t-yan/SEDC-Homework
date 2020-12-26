using System;

namespace Homework_05_Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            //"The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!"
            //* Print the whole text after "," in the console. *Bonus - Try to do that without counting the characters till "," by yourself :)

            string testString = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";

           
            Console.WriteLine(testString.Substring(testString.IndexOf(",") + 2));

            Console.ReadLine();
        }
    }
}
