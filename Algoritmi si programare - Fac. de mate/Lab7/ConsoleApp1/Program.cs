using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            factorial();
        }

        private static void factorial()
        {
            int n;
            int fact = 0;

            n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                fact = fact + i;
            }

            Console.WriteLine($"Numarul triunghi al numarului {n} este {fact}.");
        }
    }
}
