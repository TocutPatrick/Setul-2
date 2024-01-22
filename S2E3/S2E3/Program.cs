using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vom calcula suma primelor n numere");
            int n; int i = 0; int suma = 0;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                suma = suma + i;
            }

            Console.WriteLine($"Suma numerelor pana la {n} este {suma}");

            Console.ReadKey();  


        }
    }
}
