using System;

namespace _175
{
    class Program
    {
        static void Main(string[] args)
        {
            int g, o, p, c;

            g = int.Parse(Console.ReadLine());
            o = int.Parse(Console.ReadLine());

            c = g + o;
            p = g * 2 + o * 4;

            Console.WriteLine(c);
            Console.WriteLine(p);
        }
    }
}
