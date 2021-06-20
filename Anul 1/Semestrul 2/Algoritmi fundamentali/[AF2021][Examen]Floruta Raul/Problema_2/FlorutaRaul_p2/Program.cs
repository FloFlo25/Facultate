using System;
using System.Collections.Generic;

namespace FlorutaRaul_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 3, 3, 4, 4, 4, 3 };

            int[] output = puteriVector(input);

            foreach (int item in output)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static int[] puteriVector(int[] vector)
        {
            int length = vector.Length;
            int[] aparitii = new int[length];

            for (int i = 0; i < length; i++)
            {
                aparitii[vector[i]]++;
            }

            List<int> rezultat = new List<int>();
            for (int i = 0; i < length; i++)
            {
                if (aparitii[i] != 0)
                {
                    rezultat.Add(aparitii[i]);
                    
                }
            }

            int[] final = rezultat.ToArray();

            return final;
        }
    }
}
