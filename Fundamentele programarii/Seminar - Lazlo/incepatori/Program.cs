using System;

namespace incepatori
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercitiile de la clasa
            //_______________________
            //inserare_prime();
            //vectorFaraZero1();
            //vectorFaraZero2();

            //Probleme PbInfo
            //_______________
            //Stergere_Element();
            //Stergere();
            //Stergere1();
            Elim_rep();

        }

        private static void Elim_rep()
        {
            int n, i, j;

            n = int.Parse(Console.ReadLine());
            int[] vector1 = new int[n];

            for (i = 0; i < n; i++)
            {
                vector1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (IsPrim(vector1[i]))
                {
                    n = n - 1;
                    for (j = i; j < n; j++)
                    {
                        vector1[j] = vector1[j + 1];
                    }
                }
            }

            Console.Clear();

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{vector1[i]} ");
            }

        }

        private static void Stergere1()
        {
            int n, i, j;

            n = int.Parse(Console.ReadLine());
            int[] vector1 = new int[n];

            for (i = 0; i < n; i++)
            {
                vector1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (vector1[i]%2==0)
                {
                    n = n - 1;
                    for (j = i; j < n; j++)
                    {
                        vector1[j] = vector1[j + 1];
                    }
                }
            }

            Console.Clear();

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{vector1[i]} ");
            }

        }

        private static void Stergere()
        {
            int n, i,j;

            n = int.Parse(Console.ReadLine());
            int[] vector1 = new int[n];

            for(i = 0;i<n;i++)
            {
                vector1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if(IsPrim(vector1[i]))
                {
                    n = n - 1;
                    for (j = i; j < n; j++)
                    {
                        vector1[j] = vector1[j + 1];
                    }
                }
            }

            Console.Clear();

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{vector1[i]} ");
            }

        }

        private static void Stergere_Element()
        {
            int n, i,k=0,p;

            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] vector1 = new int[n];
            int[] vector2 = new int[n];

            for (i=0;i<n;i++)
            {
                vector1[i] = int.Parse(Console.ReadLine());
            }

            n = n - 1;
            for(i=p;i<n;i++)
            {
                vector1[i] = vector1[i + 1];
            }
            

            Console.Clear();

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{vector1[i]} ");
            }

        }

        private static void vectorFaraZero2()
        {
            int n, i,j;

            n = int.Parse(Console.ReadLine());
            int[] vector1 = new int[n];

            for (i = 0; i < n; i++)
            {
                vector1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (vector1[i] == 0)
                {
                    for (j = i + 1; j < n; j++)
                        vector1[j - 1] = vector1[j];
                    n--;
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{vector1[i]} ");
            }
        }

        private static void vectorFaraZero1()
        {
            int n, i,k=0;

            n = int.Parse(Console.ReadLine());
            int[] vector1 = new int[n];
            int[] vector2= new int[n];

            for(i=0;i<n;i++)
            {
                vector1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (vector1[i] != 0)
                {
                    vector2[k] = vector1[i];
                    k++;
                }
            }
            n = k;
            vector1 = vector2;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{vector1[i]} ");
            }
        }


        /// <summary>
        /// Se da un vector si se cere inserarea dupa fiecare valoare prima, suma cifrelor acesteia.
        /// IN: 1 12 31 45 51 6
        /// OUT: 1 12 31 4 45 51 6 6
        /// </summary>
        private static void inserare_prime()
        {
            int n, i,k=0;
            
            n = int.Parse(Console.ReadLine());
            int[] vector1 = new int[n];
            int[] vector2 = new int[n];

            for (i=0;i<n;i++)
            {
                vector1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                vector2[k] = vector1[i];
                k++;
                if (IsPrim(vector1[i]))
                {
                    vector2[k] = SumCifre(vector1[i]);
                    k++;
                }
            }

            Console.Clear();

            for (i = 0; i < n; i++)
            {
                //Console.WriteLine($"{vec}");
            }
        }

        private static int SumCifre(int n)
        {
            int s=0;
            while(n!=0)
            {
                s = s * 10 + n % 10;
                n /= 10;
            }
            return s;
        }

        private static bool IsPrim(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            for (int i = 3; i*i <=n; i+=2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
            
        }
    }
}
