using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int p; int neg=0; int poz=0; int zero=0;

            Console.WriteLine("Cate numere?");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                Console.Write("Introdu numarul:");
                p  = int.Parse(Console.ReadLine());

                if(p > 0)
                {
                     poz++;
                }

                if(p < 0)
                {
                     neg++;
                }

                if(p == 0)
                {
                     zero++;
                }

                n--;
            }

            Console.WriteLine($"Ai introdus {poz} numere pozitive");
            Console.WriteLine($"Ai introdus {neg} numere negative");
            Console.WriteLine($"Ai introdus 0 de {zero} ori");

            Console.ReadKey();
        }
    }
}
