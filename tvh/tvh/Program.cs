using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvh
{
    class Program
    {
        static void Main(string[] args)
        {
            int schijfs;
            string input;
            ulong steps = 1;
            int amount = 1;
            do {
                Console.WriteLine("Voer het nummer van het aantal schijven in, waarvan je het minimale aantal zetten wilt weten");
                input = Console.ReadLine();
                if (int.TryParse(input, out schijfs))
                {
                    for (; amount <= schijfs; amount += 1)
                    {
                        steps *= 2;
                        Write(schijfs, steps -1);
                    }
                }
                else
                {
                    Console.WriteLine("Je hebt geen nummer ingevoerd tussen de 0 en 65 of je hebt überhaupt geen nummer ingevoerd, probeer het opnieuw.");
                    continue;
                }

            } while (!int.TryParse(input, out schijfs));

            Console.WriteLine("Het minimale aantal stappen voor {0} schijven is: {1}", input, steps - 1);

            ulong sec = steps;
            ulong min = sec / 60;
            ulong hours = min / 60;
            ulong days = hours / 24;
            ulong years = days / 365;
            ulong mill = years / 1000000;

            sec = steps % 60;
            min %= 60;
            hours %= 24;
            days %= 365;
            years %= 1000000;

            Console.WriteLine("Het duurt je {0}milleniums, {1}jaren, {2}dagen, {3}uren, {4}minuten, {5}seconden, om dit op te lossen", mill, years, days, hours, min, sec);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static public void Write(int schijf, ulong steps)
        {
            Console.WriteLine("{0, 3}{1, 26}", schijf, steps);
        }
    }
}
