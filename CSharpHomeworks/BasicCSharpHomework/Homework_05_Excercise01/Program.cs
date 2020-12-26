using System;

namespace Homewrok_05_Excercise01
{
   
    class Program
    {       
        static void Main(string[] args)
        {
            //*Print individual characters of the string in reverse order. *Example: we love c# *Expected Output : #c evol ew

          

            string testArr = "we love c#";
            
            string output = ReverseOrder(testArr);
            Console.WriteLine(output);


            Console.ReadLine();
        }
        public static string ReverseOrder(string someText)
        {
            char[] charArr = someText.ToCharArray();
            string reversedArr = "";

            for (int i = charArr.Length - 1; i >= 0; i--)
            {
                reversedArr += charArr[i];
            }
            return reversedArr;
        }
    }
}
