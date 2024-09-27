using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class Operators
    {
        static void main(string[] args)
        {
            // Logical AND (&&)
            // Both conditions must be true for the result to be true
            bool andExample1 = true && true;   // true
            bool andExample2 = true && false;  // false
            bool andExample3 = false && false; // false

            // Logical OR (||)
            // At least one condition must be true for the result to be true
            bool orExample1 = true || true;   // true
            bool orExample2 = true || false;  // true
            bool orExample3 = false || false; // false

            // Logical NOT (!)
            // Negates the boolean value
            bool notExample1 = !true;  // false
            bool notExample2 = !false; // true

            // Logical XOR (exclusive OR) using ^
            // Only one of the conditions must be true for the result to be true, but not both
            bool xorExample1 = true ^ true;   // false
            bool xorExample2 = true ^ false;  // true
            bool xorExample3 = false ^ false; // false

            // Combining logical operators
            bool combinedExample = (true && false) || (false ^ true); // true

            // Using logical operators with comparisons
            int x = 10;
            int y = 20;

            bool comparisonAnd = (x > 5) && (y > 15);    // true
            bool comparisonOr = (x < 5) || (y > 15);     // true
            bool comparisonNot = !(x == y);              // true
            bool comparisonXor = (x > 5) ^ (y > 25);     // true

            // Output to console
            Console.WriteLine($"AND true && true: {andExample1}");
            Console.WriteLine($"AND true && false: {andExample2}");
            Console.WriteLine($"AND false && false: {andExample3}");

            Console.WriteLine($"OR true || true: {orExample1}");
            Console.WriteLine($"OR true || false: {orExample2}");
            Console.WriteLine($"OR false || false: {orExample3}");

            Console.WriteLine($"NOT !true: {notExample1}");
            Console.WriteLine($"NOT !false: {notExample2}");

            Console.WriteLine($"XOR true ^ true: {xorExample1}");
            Console.WriteLine($"XOR true ^ false: {xorExample2}");
            Console.WriteLine($"XOR false ^ false: {xorExample3}");

            Console.WriteLine($"Combined (true && false) || (false ^ true): {combinedExample}");

            Console.WriteLine($"Comparison AND (x > 5) && (y > 15): {comparisonAnd}");
            Console.WriteLine($"Comparison OR (x < 5) || (y > 15): {comparisonOr}");
            Console.WriteLine($"Comparison NOT !(x == y): {comparisonNot}");
            Console.WriteLine($"Comparison XOR (x > 5) ^ (y > 25): {comparisonXor}");
        }
    }
}
