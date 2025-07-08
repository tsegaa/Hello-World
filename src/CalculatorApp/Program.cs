using System;

using MathLib;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.WriteLine($"{num1} + {num2} = {MathOperations.Add(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {MathOperations.Subtract(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {MathOperations.Multiply(num1, num2)}");
            double? result = MathOperations.Divide(num1, num2);
            if (result.HasValue)
            {
                Console.WriteLine($"{num1} / {num2} = {result.Value}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
}
