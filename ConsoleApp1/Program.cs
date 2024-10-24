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
           Random r = new Random();
            int znamka = r.Next(1,6);
            string slovne;
            switch (znamka)
            {
                case 1:
                    slovne = "výborný";
                    break;
                case 2:
                    slovne = "chvalitebny";
                    break;
                case 3:
                    slovne = "dobry";
                    break;
                case 4:
                    slovne = "dostatocny";
                    break;
                case 5:
                    slovne = "nedostatocny";
                    break;
                default:
                    slovne = "error";
                    break;
            }
                Console.WriteLine("peter dostal: " +znamka + " " + slovne); 



            
        }
    }
}
