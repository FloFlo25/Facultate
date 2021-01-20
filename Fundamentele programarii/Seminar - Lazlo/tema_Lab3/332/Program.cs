using System;

namespace _332
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s=0;
            int i;

            n = int.Parse(Console.ReadLine());

            for(i=1;i<=n;i++)
            {
                s += i * (i + 1);
            }

            Console.WriteLine($"Suma este {s}.");
        }
    }
}
