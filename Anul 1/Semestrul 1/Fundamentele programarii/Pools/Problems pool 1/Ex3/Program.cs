using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} NU se divide cu {k}");
        }
    }
}
