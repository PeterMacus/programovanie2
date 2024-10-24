using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hpbatman = 100;
            int hpsuperman = 100;
            Random hit = new Random();
            while (hpbatman > 0 && hpsuperman > 0) 
            {
                int hitbatman = hit.Next(1, 10);
                int hitsupeman = hit.Next(1, 10);
                hpbatman -= hitsupeman;
                hpsuperman -= hitbatman;
                if (hpbatman <= 0)
                    Console.WriteLine("Superman vyhral");
                else
                    Console.WriteLine("Batmanhp: " + hpbatman);
                if (hpsuperman <= 0)
                    Console.WriteLine("Batman vyhral");
                else
                    Console.WriteLine("Hpsuperman: " + hpsuperman); 



            }
        }
    }
}
