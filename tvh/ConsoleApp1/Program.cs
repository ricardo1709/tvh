using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
                Console.WriteLine("Het getal dat je invoerd mag niet groter zijn dan 64.");
                input = Console.ReadLine();

                if (int.TryParse(input, out schijfs))
                {
                    Console.WriteLine("Het minimale aantal zetten voor {0} schijven is: {2}.", input, (steps = (ulong)Math.Pow(amount, schijfs )), steps -1);

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

        static public void Time()
        {

        }





    }
}

