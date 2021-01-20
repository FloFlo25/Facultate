using System;

namespace Sem_lab6
{
    class Program
    {
        static int n;
        static int[] vect;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Prob2();
        }

        private static void swap(int a,int b)
        {
            int aux;
            aux = a;
            a = b;
            b = aux;
        }

        private static void citire()
        {
            n = int.Parse(Console.ReadLine());
            vect = new int[n];

            for (int i = 0; i < n; i++)
                vect[i] = rnd.Next(-100, 101);
        }

        private static void afisare()
        {
            for (int i = 0; i < n; i++)
                Console.Write($"{vect[i]} ");
            Console.WriteLine();
        }

        private static void Prob2()
        {
            citire();
            afisare();

            int aux,i,j;

            for(i=0;i<n-1;i++)
                for (j = i+1; j < n; j++)
                {
                    if(vect[i]<vect[j])
                    {
                        swap(vect[i], vect[j]);
                    }
                }
            afisare();

            Console.WriteLine($"{vect[0] + vect[1] + vect[2]}");
        }
    }
}
