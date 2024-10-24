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
            int rok = 2024;
            Console.WriteLine("Npaíš rok narodenia");
            int narodenia = int.Parse(Console.ReadLine());
            int vek = rok - narodenia;
            Console.WriteLine("Máš " + vek + " rokov");

        }
    }
}
