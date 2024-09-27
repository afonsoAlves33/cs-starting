using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class BinaryNegation
    {
        static void main(string[] args)
        {
            
            int binNumber = 0b11001100;  // A binary number gotta start with 'Ob', the binary number comes after it.      
            int neagationResult = ~binNumber;
            Console.WriteLine($"The negation / inversion of {binNumber} is: {neagationResult}");
            Console.WriteLine(Convert.ToString(neagationResult));
            Console.ReadKey();

            // This didnt work as https://www.udemy.com/course/csharp-completo/learn/lecture/33803810#overview

        }
    }
}
