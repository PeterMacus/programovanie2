using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static Random r = new Random(); // globálne, aby sa generovalo nové vždy iné

        static void Main(string[] args)
        {
           List<string> mená = new List<string>();
            
            bool vykonaj = false;
            while (vykonaj = true)
            {
                Console.WriteLine("Zadaj úpravu mien(z/v/p/vymaz)");
                string akcia = Console.ReadLine();
                if (akcia == "z")
                {
                    Console.WriteLine("Zapíš meno ktoré chceš zadať: ");
                    string pridanemeno = Console.ReadLine();
                    mená.Add(pridanemeno);
                }
                else if (akcia == "vymaz")
                {
                    Console.WriteLine("Zadaj meno ktoré chceš vymazať: ");
                    string zmazanemeno = Console.ReadLine();
                    mená.Remove(zmazanemeno);
                }
                else if (akcia == "p")
                {
                    Console.WriteLine("Zadaj meno ktoré chces prepísať: ");
                    string prepismeno = Console.ReadLine();
                    Console.WriteLine("Zadaj meno ktorým ho chceš nahradiť: ");
                    string nahradamena = Console.ReadLine();
                    mená.Remove(prepismeno);
                    mená.Add(nahradamena);
                }
                else if (akcia == "v")
                {

                    foreach (string i in mená)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            
        }
    }
}