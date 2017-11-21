using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvhMachtsverheffing
{
    class Program
    {
        static void Main(string[] args)
        {
            int schijfs;
            string input;
            ulong steps;
            int amount = 2;

            do
            {
                Console.WriteLine("Voer het nummer van het aantal schijven in, waarvan je het minimale aantal zetten wilt weten.");
                Console.WriteLine("Het getal dat je invoerd mag niet groter zijn dan 63.");
                input = Console.ReadLine();

                if (int.TryParse(input, out schijfs))
                {
                    Console.WriteLine("Het minimale aantal zetten voor {0} schijven is: {2}.", input, (steps = (ulong)Math.Pow(amount, schijfs)), steps - 1);
                    Console.WriteLine("Druk op ENTER om nog een cijfer in te voeren of,");
                    Console.WriteLine("Druk op SPATIE om aftesluiten.");
                }
                else
                {
                    Console.WriteLine("Je hebt geen nummer ingevoerd, probeer het opnieuw.");
                    continue;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar); ;

        }
    }
}

