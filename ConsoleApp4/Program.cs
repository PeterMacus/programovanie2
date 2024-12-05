using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader subor0 = new StreamReader("C:\\Users\\Peťo\\OneDrive\\Počítač\\subor0.srt");
            List<string> riadky = new List<string>();
            List<string[]> pole = new List<string[]>();
            Console.WriteLine("Zadaj časovú hodnotu o ktorú bude čas posunutý(h:m:s,m): ");
            string čas_zadany = Console.ReadLine();
            int hodiny = int.Parse(čas_zadany.Split(':')[0]);
            int minuty = int.Parse(čas_zadany.Split(':')[1]);
            int sekundy = int.Parse(čas_zadany.Split(':')[2].Split(',')[0]);
            int milisekundy = int.Parse(čas_zadany.Split(',')[1]);

            while (true)
            {
                string riadok = subor0.ReadLine();
                if (riadok == null)
                    break;
                riadky.Add(riadok);
                if (riadok.Contains(" --> "))
                {
                    pole.Add(riadok.Split(' '));
                }
            }
            subor0.Close();

            for (int i = 0; i < pole.Count; i++)
            {
                int zakl_hodiny = int.Parse(pole[i][0].Split(':')[0]) + hodiny;
                int zakl_minuty = int.Parse(pole[i][0].Split(':')[1]) + minuty;
                int zakl_sekundy = int.Parse(pole[i][0].Split(':')[2].Split(',')[0]) + sekundy;
                int zakl_milisekundy = int.Parse(pole[i][0].Split(',')[1]) + milisekundy;

                zakl_sekundy += zakl_milisekundy / 1000;
                zakl_milisekundy %= 1000;
                zakl_minuty += zakl_sekundy / 60;
                zakl_sekundy %= 60;
                zakl_hodiny += zakl_minuty / 60;
                zakl_minuty %= 60;

                int konec_hodiny = int.Parse(pole[i][2].Split(':')[0]) + hodiny;
                int konec_minuty = int.Parse(pole[i][2].Split(':')[1]) + minuty;
                int konec_sekundy = int.Parse(pole[i][2].Split(':')[2].Split(',')[0]) + sekundy;
                int konec_milisekundy = int.Parse(pole[i][2].Split(',')[1]) + milisekundy;

                konec_sekundy += konec_milisekundy / 1000;
                konec_milisekundy %= 1000;
                konec_minuty += konec_sekundy / 60;
                konec_sekundy %= 60;
                konec_hodiny += konec_minuty / 60;
                konec_minuty %= 60;

                for (int j = 0; j < riadky.Count; j++)
                {
                    if (riadky[j] == Convert.ToString(i + 1))
                    {
                        riadky[j + 1] = $"{zakl_hodiny:D2}:{zakl_minuty:D2}:{zakl_sekundy:D2},{zakl_milisekundy:D3} --> " +
                                        $"{konec_hodiny:D2}:{konec_minuty:D2}:{konec_sekundy:D2},{konec_milisekundy:D3}";
                    }
                }
            }

            foreach (var i in riadky)
                Console.WriteLine(i);

            StreamWriter streamwriter = new StreamWriter("C:\\Users\\Peťo\\OneDrive\\Počítač\\novySubor0.srt");
            foreach (var i in riadky)
                streamwriter.WriteLine(i);



            streamwriter.Close();
        }
    }
}