using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int a; int i = 0; int p; int j = -1;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("La ce numar se va afla pozitia?");
            a = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Introdu numarul:");
                p = int.Parse(Console.ReadLine());

                if (p == a)
                    j = i;

                if (j < 0)
                    j = -1;
                       
            }

            Console.WriteLine($"Numarul {a} se afla pe pozitia {j}");

            Console.ReadKey();  
        }
    }
}
