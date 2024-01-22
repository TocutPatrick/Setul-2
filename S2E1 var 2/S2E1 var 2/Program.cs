using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E1_var_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int p; int count = 0;
            Console.WriteLine("Cate numere?");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                Console.WriteLine("Introdu numarul");
                p = int.Parse(Console.ReadLine());

                if (p % 2 == 0)
                {
                    count++;
                }

                n--;
            }

            Console.WriteLine($"Ai introdus {count} numere pare");

            Console.ReadKey();
        }
    }
}
