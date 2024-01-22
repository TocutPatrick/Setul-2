using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n; int minim = 0; int maxim = 0; int p; int prev = 0; int num;
            Console.WriteLine("De cate numere va fi secventa?");
            n = int.Parse(Console.ReadLine());

            num = n;

            while (n > 0)
            {
                Console.Write("Introdu numarul:");
                p = int.Parse(Console.ReadLine());

                if (prev <= p)
                {
                    if(minim >= prev )
                    {
                        minim = prev;
                    }

                    if(maxim <= p)
                    {
                        maxim = p;
                    }
                    
                }
                else
                {
                    if (minim >= p)
                    {
                        minim = p;
                        
                    }

                    if(maxim <= prev)
                    {
                        maxim = prev;
                    }

                }

                prev = p;
                n--;
            }

            Console.WriteLine($"Minim = {minim}");
            Console.WriteLine($"Maxim = {maxim}");

            Console.ReadKey();

        }
    }
}
