using System;

namespace _24.nov
{
    class Program
    {
        static void Main(string[] args)
        {
            //subctA();
            subctB();
        }

        private static void subctB()
        {
            //int n1 = 10000;
            int i,j,maxLength;
            bool ok = true;


            int[] v1 = { 1, 2, 3, 4 };
            int[] v2 = { 1, 3, 5, 6, 7 };
            int[] vault = new int[100];

            int length;

            /*maxLength = v1.Length;
            if (v2.Length > v1.Length)
                maxLength = v2.Length;*/

            //intersectie:
            Console.Write("Intersectie: ");
            for (i = 0; i < v1.Length; i++)
            {
                for (j = 0; j < v2.Length; j++)
                if (v1[i] == v2[j])
                    Console.Write($"{v1[i]} ");
            }

            Console.WriteLine();

            //reuniune:
            Console.Write("Reuniune: ");
            for (i = 0; i < v1.Length; i++)
            {
                vault[i] = v1[i];
            }

            length = v1.Length;

            for (i = 0; i < v2.Length; i++)
            {
                ok = true;
                for (j = 0; j < length; j++)
                    if (v2[i] == vault[j])
                        ok = false;
                if(ok)
                {
                    vault[length]=v2[i];
                    length++;
                }
            }
            for (j = 0; j < length; j++)
                Console.Write($"{vault[j]} ");
        }
         
        private static void subctA()
        {
            int n1=10000;
            int i;


            int[] v1 = { 1, 13, 1, 12, 1, 1, 13 };
            int[] v2 = new int[n1];

            for (i = 0; i < v1.Length; i++)
            {
                v2[v1[i]]++;
                if (v2[v1[i]] == 1)
                    Console.Write($"{v1[i]} ");
            }
        }
    }
}
