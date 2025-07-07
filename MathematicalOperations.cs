using System;

namespace HelloWorld
{
    class MathematicalOperations
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

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            if (num2 != 0)
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
}
