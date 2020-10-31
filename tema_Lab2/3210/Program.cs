using System;

namespace _3210
{
    class Program
    {
        static void Main(string[] args)
        {
            int pret, bani;

            pret = int.Parse(Console.ReadLine());
            bani = int.Parse(Console.ReadLine());

            Console.WriteLine(bani / pret);
            Console.WriteLine(pret - bani % pret);
        }
    }
}
