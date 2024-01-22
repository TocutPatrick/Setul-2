using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int i; int count = 0; int p;
            Console.Write("Cat de lunga sa fie secventa? n numere:");
            n = int.Parse(Console.ReadLine());

            for(i = 0; i < n; i++)
            {
                Console.Write("Introdu numarul:");
                p = int.Parse(Console.ReadLine());

                if (p == i) 
                    count++;

            }

            Console.WriteLine($"{count} numere au valoarea egala cu pozitia lor");
            Console.ReadKey();
        }
    }
}
