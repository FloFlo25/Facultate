using System;

namespace Laborator_3
{
    class Program
    {
        //idk daca era complet
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] numere = new int[] { 3, 6, 31, 104, 97, 1 };
            int[] numereNoi = new int[numere.Length * 2];
            int k = 0;

            //prin castig de memorie -> lucram pe vectorul numere[]
            //prin castig de viteza -> adaugam elementele in vectorul numereNoi[]

            
            for (int i = 0;  i < numere.Length; i++)
            {
                numereNoi[k] = numere[i];
                k++;
                if (IsPrime(numere[i]))
                {
                    numereNoi[k] = sumaCifrelor(numere[i]);
                    k++;
                }
            }

            for (int j = 0; j < numereNoi.Length; j++)
            {
                Console.Write($"{numereNoi[j]} ");
            }


            /*for (int i = 0; i < numere.Length; i++)
            {
                if (IsPrime(numere[i]))
                    Console.Write($"{numere[i]} {sumaCifrelor(numere[i])} ");
            }*/
        }

        private static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i+=2)
            {
                if (n % i == 0)
                    return false;
            }
                return true;
        }

        static int sumaCifrelor(int n)
        {
            int s = 0;
            while (n!=0)
            {
                s += n % 10;
                n /= 10;
            }
            return s;
        }
    }
}
