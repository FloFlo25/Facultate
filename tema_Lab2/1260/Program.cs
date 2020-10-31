using System;

namespace _1260
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            Console.WriteLine(m + n);
            if(n<m)
            {
                Console.WriteLine(m - n);
                Console.WriteLine(m * n);
                Console.WriteLine(m / n);
            }
            else
            {
                Console.WriteLine(n - m);
                Console.WriteLine(m * n);
                Console.WriteLine(n / m);
            }
        }
    }
}
