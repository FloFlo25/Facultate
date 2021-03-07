using System;
using System.Text;
using System.IO;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            pbStreamReader();
        }

        private static void pbStreamReader()
        {
            
        }

        private static void pb2()
        {
            int n = int.Parse(Console.ReadLine());
            int[] vect = new int[n];
            int[] newVect = new int[2 * n];
            int k = 0;

            //citire vector
            for (int i = 0; i < n ; i++)
            {
                vect[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                newVect[k] = vect[i];
                k++;
                if (nrPrim(vect[i]))
                {
                    newVect[k] = sumCif(vect[i]);
                    k++;
                }

            }

            //afisare vector
            for (int i = 0; i < n; i++)
            {
                Console.Write(newVect[i] + " ");
            }
        }

        private static void pb1()
        {
            int[] vect = { 1, 2, 3, 4, 3, 2 };
            int i=0, j=vect.Length;
            bool palindrom = true;

            while (i<vect.Length/2+1)
            {
                if (vect[i] != vect[j-1])
                {
                    palindrom = false;
                    break;
                }
                i++;
                j--;
            }

            Console.WriteLine(palindrom);
        }

        private static bool nrPrim(int numar)
        {
            int d, n;

            for ( d = 2; d<=numar/2 ; d++)
            {
                if(numar%d==0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int sumCif(int numar)
        {
            int sum = 0;

            while (numar >0)
            {
                sum += numar % 10;
                numar /= 10;
            }

            return sum;
        }
    }
}
