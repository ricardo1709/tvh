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
            } while (!int.TryParse(input, out schijfs));

            for( amount = schijfs; amount > 0; amount -=1)
            {
                steps = steps * 2;
                
            }

            Write(schijfs, steps -1);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static public void Write(int schijf, ulong steps)
        {
            Console.WriteLine("{0}{1, 20}",schijf, steps);
        } 
    }
}
