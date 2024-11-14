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
            List<string> Januar = new List<string>();
            List<string> Marec = new List<string>();
            List<string> Februar = new List<string>();

            Januar.Add("Peter");
            Januar.Add("Jozef");
            Januar.Add("Marián");
            Januar.Add("Marta");
            Januar.Add("Miloš");
            Januar.Add("Kmetka");
            Januar.Add("Sofia");
            Februar.Add("Mária");
            Februar.Add("Júlia");
            Februar.Add("Sabína");
            Februar.Add("Roman");
            Februar.Add("Filip");
            Februar.Add("Janka");
            Februar.Add("Ján");
            Marec.Add("Julius");
            Marec.Add("Filip");
            Marec.Add("Matúš");
            Marec.Add("Beata");
            Marec.Add("Erika");
            Marec.Add("Štefan");
            Marec.Add("Patrik");

            Console.WriteLine("Napíš mesiac ktorý chceš vybrať(j/f/m):");
            string mesiac = Console.ReadLine();


            if (mesiac == "j")
            {
                Console.WriteLine("Zadaj deň(1-7): ");
                int den = int.Parse(Console.ReadLine());
                Console.WriteLine(Januar[den - 1]);

            }
            else if (mesiac == "f")
            {
                Console.WriteLine("Zadaj deň(1-7): ");
                int den = int.Parse(Console.ReadLine());
                Console.WriteLine(Februar[den - 1]);
            }
            else if (mesiac == "m")
            {
                Console.WriteLine("Zadaj deň(1-7): ");
                int den = int.Parse(Console.ReadLine());
                Console.WriteLine(Marec[den - 1]);
            }
            else
            {
                foreach (string i in Januar)
                { Console.Write(i + " "); }

                foreach (string i in Februar)
                { Console.Write(i + " "); }

                foreach (string i in Marec)//ahoj
                { Console.Write(i + " "); }



            }
        }
    }
}
