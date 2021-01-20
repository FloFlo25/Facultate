using System;

namespace _1273
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, s;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            s = x + y;

            Console.WriteLine(s % 10);
        }
    }
}
