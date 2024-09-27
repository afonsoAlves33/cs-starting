using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class PrintingStringsPart2
    {
        static void main(string[] args)
        {
            String lastName;
            String name;

            Console.WriteLine("You'r first name:");
            name = Console.ReadLine();
            Console.WriteLine("You'r last name:");
            lastName = Console.ReadLine();

            Console.WriteLine($"Good morning, {name} {lastName}");
            
            Console.ReadKey(); // Just for don't closing the window
        }
    }
}
