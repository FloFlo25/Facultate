using System;

namespace _3181
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, y;
            int ani, zile, ore;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            zile = n / y;
            ore = n % y;
            ani = zile / x;
            zile = zile % x;

            Console.WriteLine(ani);
            Console.WriteLine(zile);
            Console.WriteLine(ore);
        }
    }
}
