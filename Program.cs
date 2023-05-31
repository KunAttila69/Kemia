using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Felfedezes> felfedezesek = new List<Felfedezes>();
            StreamReader sr = new StreamReader("felfedezesek.csv");

            while (!sr.EndOfStream)
            {
                string[] data = sr.ReadLine().Split(';');
                if (data[1]!= "Elem")
                {

                    felfedezesek.Add(new Felfedezes(data[0], data[1], data[2], Convert.ToInt32(data[3]), data[4]));
                }
            }
            Console.WriteLine($"3.feladat: Elemek száma: {felfedezesek.Count}");

            int x = 0;
            foreach (var felfedezes in felfedezesek)
            {
                if (felfedezes.Ev == "?kor")
                {
                    x += 1;
                }
            }
            Console.WriteLine($"4.feladat: Felfedezések száma az ókorban: {x}");

            Console.ReadKey();
        }
    }
}
