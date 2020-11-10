using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = -b / a;

            Console.WriteLine(x);
        }
    }
}
