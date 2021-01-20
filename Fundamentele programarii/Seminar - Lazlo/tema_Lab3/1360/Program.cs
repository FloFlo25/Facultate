using System;

namespace _1360
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr, sum=0;
            int i;

            nr = int.Parse(Console.ReadLine());

            for (i = 1; i <= nr; i++)
                sum += i;

            Console.WriteLine(sum);
        }
    }
}
