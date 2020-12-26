using System;

namespace Homework_RealCalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        int resultSum = numberOne + numberTwo;
                        Console.WriteLine("The sum of the two numbers is {0} ", resultSum);
                        break;
                    case "-":
                        int resultSub = numberOne - numberTwo;
                        Console.WriteLine("The subtraction of the two numbers is {0} ", resultSub);
                        break;
                    case "/":
                        if (numberTwo == 0)
                        {
                            Console.WriteLine("YOU CAN NOT DEVIDE WITH ZERO!!!");
                        }
                        else
                        {
                            double firstNum = Convert.ToDouble(numberOne);
                            double secondNum = Convert.ToDouble(numberTwo);
                            double resultDiv = firstNum / secondNum;
                            Console.WriteLine("The devision of the two numbers is {0} ", resultDiv);
                        }

                        break;
                    case "*":
                        int resultMult = numberOne * numberTwo;
                        Console.WriteLine("The multiplication of the two numbers is {0} ", resultMult);
                        break;

                    default:
                        Console.WriteLine("You entered invalid operation!!!");
                        break;
                }
            }
            else Console.WriteLine("Invalid input, please input valid numbers !!!");

        }
    }
    
}
