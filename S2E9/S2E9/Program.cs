using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int p; int prev = 0;int i = 0;int num;
            Console.WriteLine("Cate numere va avea secventa");
            n = int.Parse(Console.ReadLine());

            num = n;

            while (n > 0)
            {
                Console.Write("Introdu numarul:");
                p = int.Parse(Console.ReadLine());



                if (prev <= p)
                {
                    i++;
                }
                else break;

                prev = p;



                n--;
            }

            if (i == num)
                Console.WriteLine("Secventa este monotona");
            else
                Console.WriteLine("Secventa nu este monotona");


            Console.ReadKey();  
        }
    }
}
