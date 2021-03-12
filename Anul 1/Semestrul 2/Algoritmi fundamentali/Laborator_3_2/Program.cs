using System;

namespace Laborator_3_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int idx = 2;
            int n = 2, m = 5, nr = 0;
            int lc = 0, cc = 0; //linie curenta, coloana curenta
            int[,] a = new int[n,m];

            do
            {
                if (isPrime(idx))
                {
                    a[lc, cc] = idx;
                    cc++;

                    if (cc == m)
                    {
                        cc = 0;
                        lc++;
                    }
                    nr++;
                }
                idx++;

            } while (nr<n*m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Verifica 'primalitatea' numerelor
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static bool isPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 2; i*i <=n; i++)
            {
                if ((n%i)==0)
                    return false;
            }
            return true;
        }
    }
}
