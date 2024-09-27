using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class PrintingStringsPart1
    {
        static void main(string[] args)
        {
            // Like it is in C, single quotes are for char type, and double quotes for strings
            Console.WriteLine('a');
            Console.WriteLine("Hello World");

            Console.Write("This method prints something ");
            Console.Write("with not breaking a line.");

            // To do break a line in a String, use <\r\n>
            Console.Write("\r\n" + 1 + "\r\n");
            Console.Write(2 + "\r\n");


            // This line has the role of making the console tab still open, because of it's characteristic of closing if there's nothing running anymore.  
            Console.ReadKey();
        }
    }
}
