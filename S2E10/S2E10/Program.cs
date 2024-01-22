using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int prev = 0; int num = 0; int k = 0; int  max = 0;
            Console.WriteLine("De cate numere sa fie secventa?");
            n = int.Parse(Console.ReadLine());
            num = n;

            while(n > 0) {

                int p;
                Console.Write("Dati un numar:");
                p = int.Parse(Console.ReadLine());

                if (n == num)
                    k++;

                if (p == prev)
                {
                    k++;                 
                }
                else
                {
                    k = 0;


                }
                    
                

                



                prev = p;
                n--;
            }


            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este de {max}");
            Console.ReadKey();
        }
    }
}
