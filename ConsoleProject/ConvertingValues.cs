using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class ConvertingValues
    {
        static void main(string[] args)
        {
            string number = "23";
            Console.WriteLine($"var: {number}, type: {number.GetType()}");

            Console.WriteLine();

            int trueNumber = Convert.ToInt32(number);
            Console.WriteLine($"var: {trueNumber}, type: {trueNumber.GetType()}" );


            Console.WriteLine();

            byte b = 50;
            char c = Convert.ToChar(b); // This converts to the correspondent ASCII value
            Console.WriteLine($"{b} in ASCII -> {c} \r\nC type -> {c.GetType()}");
            int charC = Convert.ToInt32(c); // This function does the opposite path of the previous one
            Console.WriteLine($"{c} in ASCII to Real Number -> {charC}"); 



            Console.ReadKey(); // Just for don't closing the window
        }
    }
}
