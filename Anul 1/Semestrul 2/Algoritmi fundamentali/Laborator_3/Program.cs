using System;

namespace Laborator_3_1
{
    class Program
    {


        static void Main(string[] args)
        {
            int n = 5;
            int[,] a = new int[n,n];
            int k = n;


            //atribuire
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = n - Math.Abs(n - (i + j + 1));
                }
            }


            //afisare matrice
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
