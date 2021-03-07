using System;

namespace _3180
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, val3, m, n, p;

            val1 = int.Parse(Console.ReadLine());
            val2 = int.Parse(Console.ReadLine());
            val3 = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());

            Console.WriteLine(val1 * n + val2 * m + val3 * p);
        }
    }
}
