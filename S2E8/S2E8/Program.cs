using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int f1 = 0; int f2 = 1; int i = 2; 
            Console.WriteLine("Al catelea numar din sirul lui Fibonacci?");
            n = int.Parse(Console.ReadLine());

            int f3 = 0;

            if (n == 1)
                Console.WriteLine("Primul numar din sir este 0");

            
                while (i != n)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
                    f3 = 0;

                    i++;

                }
            
            Console.WriteLine($"Al {n}-lea numar din sir este {f2}");

            Console.ReadKey();
        }
    }
}
