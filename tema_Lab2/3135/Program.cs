using System;

namespace _3135
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum;

            n = int.Parse(Console.ReadLine());

            sum = ((int)Math.Pow(n, 2)* ((int)Math.Pow(n, 2)+1))/2;

            Console.WriteLine(sum / n);
        }
    }
}
