// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // an instance of Calc class
            Calc calculator = new Calc();

            while (true)
            {
                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operator (+, -, *, /):");
                char op = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double[] numbers = { num1, num2 };
                double result = 0;

                switch (op)
                {
                    case '+':
                        //result = calculator.Add(num1, num2);
                        result = calculator.Add(numbers);
                        break;
                    case '-':
                        //result = calculator.Subtract(num1, num2);
                        result = calculator.Subtract(numbers);
                        break;
                    case '*':
                        result = calculator.Multiply(num1, num2);
                        break;
                    case '/':
                        result = calculator.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operator!");
                        continue;
                }
                Console.WriteLine($"Result: {result}");
                Console.WriteLine("Press 'Q' to quit or any other key to continue.");
                if (Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }
    }
}