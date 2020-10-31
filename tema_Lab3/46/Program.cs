using System;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr, sum=0;

            nr = int.Parse(Console.ReadLine());

            sum = nr * (nr + 1);

            Console.WriteLine($"Suma este {sum}");
        }
    }
}
