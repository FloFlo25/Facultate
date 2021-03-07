using System;

namespace _3178
{
    class Program
    {
        static void Main(string[] args)
        {
            int fete, baieti, zile;
            int paginiFete, paginiBaieti;

            fete = int.Parse(Console.ReadLine());
            baieti = int.Parse(Console.ReadLine());
            zile = int.Parse(Console.ReadLine());

            paginiFete = fete * 3;
            paginiBaieti = baieti * 2;

            Console.WriteLine((paginiFete + paginiBaieti) * zile);
        }
    }
}
