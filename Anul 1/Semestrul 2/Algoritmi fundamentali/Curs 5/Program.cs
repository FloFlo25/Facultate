using System;

namespace Curs_5
{
    class Program
    {

        static int Fibonnaci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonnaci(n - 1) + Fibonnaci(n - 2);
        }

        static int FibonnaciNoRecurs(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            else
            {
                int nr = 40;
                int[] v = new int[n + 1];
                v[0] = 0;
                v[1] = 1;
                for (int i = 2; i < nr; i++)
                {
                    v[i] = v[i - 1] + v[i - 2];
                }
                return v[n];
            }
        }

        static void Main(string[] args)
        {
            int nr = 20;

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine(Fibonnaci(i));
            }

            Console.WriteLine();

            for (int i = 1; i < nr; i++)
            {
                Console.WriteLine(((float)Fibonnaci(i) / (float)Fibonnaci(i-1)));
            }
        }
    }
}
