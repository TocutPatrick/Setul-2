using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int p; int prev = -1000000000; int count = 0; int i = 0;

            Console.WriteLine("Cate numare se introduc?");
            n = int.Parse(Console.ReadLine());

            int num;
            num = n;

            while (n > 0)
            {
                Console.WriteLine("Introdu numarul:");
                p = int.Parse(Console.ReadLine());

                   if(prev <= p )
                    count++;
             

                prev = p;

                n--;

            }

            if (count == num)
                Console.WriteLine("Numerele sunt in ordine crecatoare");
            else
                Console.WriteLine("Numerele nu sunt in ordine crescatoare");

            Console.ReadKey();
        }
    }
}
