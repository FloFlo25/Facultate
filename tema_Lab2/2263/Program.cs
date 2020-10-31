using System;

namespace _2263
{
    class Program
    {
        static void Main(string[] args)
        {
            int tir1, tir2, tone1, tone2, zile;

            tone1 = int.Parse(Console.ReadLine());
            tone2 = int.Parse(Console.ReadLine());
            tir1 = int.Parse(Console.ReadLine());
            tir2 = int.Parse(Console.ReadLine());
            zile = int.Parse(Console.ReadLine());

            Console.WriteLine(((tir1 * tone1) + (tir2 * tone2)) * zile);
        }
    }
}
