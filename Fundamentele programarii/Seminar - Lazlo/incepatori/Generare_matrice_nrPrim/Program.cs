using System;

namespace Generare_matrice_nrPrim
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; //citireInt();
            int m = 7; //citireInt();
            int[,] vect = new int[n, m];

            GenMatrix(n, m);
            GenPrimeNMB();

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {

                }
            }
        }

        static private bool isPrim(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i*i <= n; i+=2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        private static void GenPrimeNMB()
        {
            int[] prim = new int[];


        }

        private static void GenMatrix(int n, int m)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {

                }
            }
        }

        private static int citireInt()
        {
            int x = int.Parse(Console.ReadLine());
            return x;
        }
    }
}
