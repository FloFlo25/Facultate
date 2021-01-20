using System;

namespace _2201
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            Console.WriteLine(n * (n - 1) / 2);
        }
    }
}
