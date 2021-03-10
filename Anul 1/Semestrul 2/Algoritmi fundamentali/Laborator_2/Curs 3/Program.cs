using System;

namespace Curs_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //task_1();
            task_2();
        }

        private static void task_2()
        {
            //Console.Write("n = "); int n = int.Parse(Console.ReadLine());
            int m = 5;
            int n = 5;
            int[,] a = new int[n, m];
            int i, j,k=1;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    a[i, j] = k;
                    k++;
                    if (k == 10)
                        k=1;
                }
            }
            afisareMatrice(a, n,m);

            for (i = 0; i < m-1; i++)
                Console.Write(a[0,i]+ " ");
            for (i = 0; i < n-1; i++)
                Console.Write(a[0, i] + " ");
            for (i = m-1; i >=1; i--)
                Console.Write(a[n-1, i] + " ");
            for (i = n-1; i >=1 ; i--)
                Console.Write (a[i, 0] + " ");

        }

        private static void task_1()
        {
            Console.Write("n = "); int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int i, j;

            //generare matrice
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    //NORD
                    if (i < j && i + j < n - 1)
                    {
                        a[i, j] = 1;
                    }
                    //EST
                    if (i < j && i + j > n - 1)
                    {
                        a[i, j] = 2;
                    }
                    //SUD
                    if (i > j && i + j < n - 1)
                    {
                        a[i, j] = 3;
                    }
                    //VEST
                    if (i > j && i + j > n - 1)
                    {
                        a[i, j] = 4;
                    }

                }
            }

            afisareMatrice(a,n);
            /*//afisare matrice
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();*/
            }

        private static void afisareMatrice(int[,] a, int n)
        {
            
            int i, j;
            //afisare matrice
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }   
        }

        private static void afisareMatrice(int[,] a, int n , int m)
        {

            int i, j;
            //afisare matrice
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
