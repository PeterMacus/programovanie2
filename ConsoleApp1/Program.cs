using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mena = { "jozo", "fero", "majo" };
            Random cislo = new Random();
            foreach (string meno in mena)
            {
                int znamka = cislo.Next(1, 6);
                Console.WriteLine(meno + znamka);


            }
        }
    }
}
