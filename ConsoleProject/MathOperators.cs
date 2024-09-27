using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class MathOperators
    {
        public void DemonstrateOperators()
        {
            int a = 10; // Initialize variable 'a' with value 10
            int b = 5;  // Initialize variable 'b' with value 5

            // Addition
            int sum = a + b;
            Console.WriteLine("Addition: " + a + " + " + b + " = " + sum);

            // Subtraction
            int difference = a - b;
            Console.WriteLine("Subtraction: " + a + " - " + b + " = " + difference);

            // Multiplication
            int product = a * b;
            Console.WriteLine("Multiplication: " + a + " * " + b + " = " + product);

            // Division
            int quotient = a / b;
            Console.WriteLine("Division: " + a + " / " + b + " = " + quotient);

            // Modulus (Remainder)
            int remainder = a % b;
            Console.WriteLine("Modulus: " + a + " % " + b + " = " + remainder);
        }

        static void Main(string[] args)
        {
            MathOperators mathOps = new MathOperators(); // Create an instance of the MathOperators class
            mathOps.DemonstrateOperators(); // Call the method to demonstrate operators
            Console.ReadKey();
        }
    }
}
