using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class Conditionals
    {
        static void main(string[] args) {
            char a = 'b'; // Theres also >, <, ==, >=, <=, etc.


;           if (a == 'a')
            {
                Console.WriteLine("TRUE");
            }
            else if(a == 'b') {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            Console.WriteLine("Choose beetwen Neymar, Pele or Rodrygo:");
            String option = Console.ReadLine();
            switch (option)
            {
                case "Neymar":
                    Console.WriteLine("Neymar is a great player who won a Libertadores, a Copa do Brasil, three Paulistas and a Recopa Sul Americana.");
                    break;
                case "Pele":
                    Console.WriteLine("Pelé is the king of football, for Santos, he won two Copa Libertadores, two Intercontinental Cups, six Brasileirões, four Rio-São Paulo tournaments, and ten Campeonato Paulista titles.\r\nAlso, he was the only player in the world to won 3 World Cups.");
                    break;
                case "Rodrygo":
                    Console.WriteLine("Rodrygo Goes is a talented player who won the Campeonato Paulista in 2019 and the Copa do Brasil in 2020 for Santos FC.");
                    break;
            }


            Console.ReadKey();
            }

    }
}
