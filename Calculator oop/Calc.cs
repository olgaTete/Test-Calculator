using System;

namespace Calculator_OOP
{
    public class Calc
    {
        // Method to add two numbers
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        // Overloaded method to add an array of numbers
        public double Add(double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        // Method to subtract two numbers
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        // Overloaded method to subtract an array of numbers
        public double Subtract(double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        // Multiply method
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        // Divide method
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Error: Division by zero!");
            }
            return num1 / num2;
        }
    }
}