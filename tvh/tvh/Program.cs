﻿using System;
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
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static public void Write(int schijf, ulong steps)
        {
            Console.WriteLine("{0, 2}{1, 20}",schijf, steps);
        } 
    }
}
