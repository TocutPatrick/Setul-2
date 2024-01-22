using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int i = 0;
            Console.WriteLine("de cate numere sa fie secventa?");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                int p;
                Console.Write("Dati numarul");
                p = int.Parse(Console.ReadLine());

                if (p % 2 == 0)
                    i++;

                n--;

            }

            Console.WriteLine($"In secventa sunt {i} numere pare");
            Console.ReadKey();
        }
    }
}
