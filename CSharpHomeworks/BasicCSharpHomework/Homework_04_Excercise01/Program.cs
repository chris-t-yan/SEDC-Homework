using System;

namespace Homework_04_Excercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Refactor the calculator exercise from previous homework. Implement methods for every opertaion. 
            //Hint: All calculations ("+", "-", "/", "*") have to be in separate methods and called depending 
            //on user's input for operation that he/she wants to be performed.

            Console.WriteLine("Enter the operation you want to execute");
            var operation = Console.ReadLine();

            Console.WriteLine("Enter the first number");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            var secondNumber = Console.ReadLine();

            int numberOne;
            bool conversionFirst = int.TryParse(firstNumber, out numberOne);
            int numberTwo;
            bool conversionSecond = int.TryParse(secondNumber, out numberTwo);

            if (conversionFirst & conversionSecond)
            {
                switch (operation)
                {
                    case "+":
                        int resultSum = Sum(numberOne, numberTwo);
                        Console.WriteLine("The sum of the two numbers is {0} ", resultSum); 
                        break;
                    case "-":
                        int resultSub = Subtraction(numberOne, numberTwo);
                        Console.WriteLine("The subtraction of the two numbers is {0} ", resultSub);
                        break;
                    case "/":
                        if (numberTwo == 0)
                        {
                            Console.WriteLine("YOU CAN NOT DEVIDE WITH ZERO!!!");
                        } 
                        else 
                        {
                            float resultDiv = Division(numberOne, numberTwo);
                            Console.WriteLine("The devision of the two numbers is {0} ", resultDiv);
                        }
                       
                        break;
                    case "*":
                        int resultMult = Multiplication(numberOne, numberTwo);
                        Console.WriteLine("The multiplication of the two numbers is {0} ", resultMult);
                        break;

                    default:
                        Console.WriteLine("You entered invalid operation!!!");
                        break;
                }
            }
            else Console.WriteLine("Invalid input, please input valid numbers !!!");

        }

        public static int Sum(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }

        public static int Subtraction(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            return result;
        }

        public static float Division(float firstNum, float secondNum)
        {
            float result = firstNum / secondNum;
            return result;
        }

        public static int Multiplication(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            return result;
        }

       
    }
}
