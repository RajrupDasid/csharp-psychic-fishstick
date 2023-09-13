using System;
namespace Multiply
{
    class Multi
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Calculate the product
            double product = num1 * num2;

            // Display the result
            Console.WriteLine($"The product of {num1} and {num2} is {product}");
        }
    }
}