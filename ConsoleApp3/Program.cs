using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FAZA 1
            StreamReader sr = new StreamReader("C:\\Users\\Peťo\\OneDrive\\Počítač\\skore.txt");

            List<int> body = new List<int>();
            List<string> mena = new List<string>();

            while (true)
            {
                string riadok = sr.ReadLine();
                if (riadok == null)
                    break;

                string[] tmp = riadok.Split('\t');
                body.Add(int.Parse(tmp[0]));
                mena.Add(tmp[1]);
            }

            Console.WriteLine("Zadaj meno:");
            string meno = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < mena.Count; i++)
            {
                if (mena[i] == meno)
                    index = i;
            }

            if (index == -1)
                Console.WriteLine("Toto meno nie je v databáze!");
            else
                Console.WriteLine("Hráč " + mena[index] + " má bodov: " + body[index]);

            // FAZA 2
            int pokusov = 0;
            Random r = new Random();
            int hladane = r.Next(0, 100);

            while (true)
            {
                Console.WriteLine("Zadaj číslo:");
                int zadane = int.Parse(Console.ReadLine());
                pokusov++;

                if (hladane > zadane)
                    Console.WriteLine("Zadal si menšie");
                else if (hladane < zadane)
                    Console.WriteLine("Zadal si väčšie");
                else
                    break;
            }

            Console.WriteLine("Uhádol si na: " + pokusov + "-krát.");

        }
    }
}
