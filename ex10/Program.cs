internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        int ant = 0;
        int count = 1;
        int prevcount = 1;

        Console.Write("Cat de lunga sa fie seventa de numere?");
        n = int.Parse(Console.ReadLine());

        int k = n;

        while (n > 0)
        {
            int p;
            Console.Write("Introdu numarul:");
            p = int.Parse(Console.ReadLine());

            if (ant != p)
            {
                count = 1;
                if (prevcount < count)
                    prevcount = count;

            }
            
            if (ant == p)
                count++;
            
                
            ant = p;
            n--;

        }

        if (prevcount > count)
            count = prevcount;

        Console.WriteLine(count);
        
        Console.ReadKey();

    }
}