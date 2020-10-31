using Microsoft.VisualBasic.CompilerServices;
using System;

namespace _1892
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,m;
            double nPow;
            int i, sum = 0;
            int x=1;

            n = int.Parse(Console.ReadLine());
            m = n;//3
            nPow = Math.Pow(n, 2); //9

            //Suma
            for (i = 1; i <= n; i++)
                sum = sum + i;

            //Verificare pow cu sum
            while(nPow!=sum && nPow>=sum)
            {
                sum = 0;
                for (i = x; i <= m; i++)
                    sum = sum + i;
                x++;
                m++;
            }
            if (nPow == sum)
            {
                Console.WriteLine($"Numarul {n} este norocos!");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este norocos!");
            }
            //mai trebuie doar afisat dar nu stiu cum :)


        }
    }
}
