using System;
using System.IO;
using WindowsFormsApplication2;

namespace Laborator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrice1 = new Matrix(@"E:\2.Visual Studio\FloFlo25\Facultate\Anul 1\Semestrul 2\Algoritmi fundamentali\Laborator 4\matrice1.txt",false);
            Matrix matrice2 = new Matrix(matrice1.n,matrice1.m);

            for (int i = 0; i < matrice1.n; i++)
                for (int j = 0; j < matrice1.m; j++)
                {
                    int nr = 0;
                    if (i - 1 >= 0 && j - 1 >= 0 && matrice1.values[i - 1, j - 1] == 0) nr++;
                    if (i - 1 >= 0 && matrice1.values[i - 1, j] == 0) nr++;
                    if (i - 1 >= 0 && j + 1 < matrice1.m && matrice1.values[i - 1, j + 1] == 0) nr++;

                    if (j - 1 >= 0 && matrice1.values[i, j - 1] == 0) nr++;
                    if (j + 1 < matrice1.m && j + 1 < matrice1.m && matrice1.values[i - 1, j + 1] == 0) nr++;

                    if (i + 1 < matrice1.n && j - 1 >= 0 && matrice1.values[i + 1, j - 1] == 0) nr++;
                    if (i + 1 < matrice1.n && matrice1.values[i - 1, j - 1] == 0) nr++;
                    if (i + 1 < matrice1.n && j+1<matrice1.m && matrice1.values[i + 1, j + 1] == 0) nr++;
                }




                    afisareMatrice(matrice1);
        }

        public static void afisareMatrice(Matrix matrice)
        {
            for (int i = 0; i < matrice.n; i++)
            {
                for (int j = 0; j < matrice.m; j++)
                {
                    Console.Write(matrice.values[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
