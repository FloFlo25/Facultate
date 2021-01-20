using System;
using System.Runtime.CompilerServices;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string line = Console.ReadLine();
            char[] seps = { ' ' };
            string[] numere = line.Split(seps,StringSplitOptions.RemoveEmptyEntries); //sterge toate spatiile empty

            a = int.Parse(numere[0]);
            b = int.Parse(numere[1]);

            cmmdc(a,b);
            cmmmc(a, b);

        }

        private static void cmmmc(int a, int b)
        {
            int n, m;
            n = a;
            m = b;

            while (m != n)
            {
                if (m < n)
                    m += a;
                if (m > n)
                    n += b;
            }
            Console.WriteLine($"Cmmmc dintre a si b este: {n}");
        }

        private static void cmmdc(int a,int b)
        {
            int r;

            while(a!=0)
            {
                r = b % a;
                b = a;
                a = r;
            }
            Console.WriteLine($"Cmmdc dintre a si b este: {b}");
        }
    }
}
