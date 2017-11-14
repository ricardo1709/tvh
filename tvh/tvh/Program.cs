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
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static string Table(string schijfs, string steps)
        {
            return string.Format("{0, 20}{1}", schijfs, steps);
        }
    }
}
