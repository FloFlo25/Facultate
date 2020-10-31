using System;

namespace _1258
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            if (n < m)
                Console.WriteLine(m - n);
            else
                Console.WriteLine(n - m);
        }
    }
}
