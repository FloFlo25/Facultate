using System;

namespace tema_lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            //problema1();
            //problema2();
            //problema3();
            //problema4();
            problema5();
        }

        private static void problema5()
        {
            /*
             * se da un sir cu n elemente numere naturale. Sa se determine valoarea maxima din sir si de cate ori apare.
             */

            int n, i, maxSir=0,contor=0;

            n = int.Parse(Console.ReadLine());
            int[] sir = new int[n];

            for (i = 0; i < n; i++)
                sir[i] = int.Parse(Console.ReadLine());
            maxSir = sir[0];

            for (i = 0; i < n; i++)
            {
                if (maxSir < sir[i])
                {
                    maxSir = sir[i];
                }
                
            }
            for (i = 0; i < n; i++)
            {
                if (maxSir == sir[i])
                    contor++;
            }

            Console.WriteLine($"Numarul maxim {maxSir} apare de {contor} in sir.");
        }

        private static void problema4()
        {
            /*
             * Se citeste un vector cu n elemente numere naturale distincte.
             * Sa se afiseze elemntele cuprinse intre elementul cu valoarea minima si cel cu valoarea maxima din vector inclusiv acestea.
             */
            int n, i, maxSir = 0, minSir = 0;
            int pozMin = 0, pozMax = 0;

            n = int.Parse(Console.ReadLine());
            int[] sir = new int[n];

            for (i = 0; i < n; i++)
                sir[i] = int.Parse(Console.ReadLine());
            maxSir = sir[0];
            minSir = sir[0];

            for (i = 0; i < n; i++)
            {
                if (minSir > sir[i])
                {
                    minSir = sir[i];
                    pozMin = i;
                }
                if (maxSir < sir[i])
                {
                    maxSir = sir[i];
                    pozMax = i;
                }
            }

            for (i = pozMin;i<=pozMax;i++)
            {
                Console.Write($"{sir[i]} ");
            }

        }

        private static void problema3()
        {
            /* Se citeste un vector cu n elemente numere naturale.
             * Sa se determine cate elemente ale vectorului sunt egale cu diferenta dintre cea mai mare si cea mai mica valoare din vector.
             */

            int n, i, maxSir = 0, minSir = 0;
            int dif, contor = 0 ;

            n = int.Parse(Console.ReadLine());
            int[] sir = new int[n];

            for (i = 0; i < n; i++)
                sir[i] = int.Parse(Console.ReadLine());
            maxSir = sir[0];
            minSir = sir[0];

            for (i = 0; i < n; i++)
            {
                if (minSir > sir[i])
                {
                    minSir = sir[i];
                }
                if (maxSir < sir[i])
                {
                    maxSir = sir[i];
                }
            }

            dif = maxSir - minSir;
            for (i = 0; i < n; i++)
            {
                if (sir[i] == dif)
                    contor++;
            }

            Console.WriteLine($"Numarul de elemente egale cu diferenta dintre {maxSir} si {minSir} (adica {dif}) este {contor}.");
        }

        private static void problema2()
        {
            //sa se determine indicele maximului si cel al minimului valorilor elementelor unui vector.

            int n, i,  maxSir = 0, minSir = 0;
            int pozMin=0,pozMax=0;
            
            n = int.Parse(Console.ReadLine());
            int[] sir = new int[n];

            for (i = 0; i < n; i++)
                sir[i] = int.Parse(Console.ReadLine());
            maxSir = sir[0];
            minSir = sir[0];

            for (i = 0; i < n; i++)
            {
                if (minSir > sir[i])
                {
                    minSir = sir[i];
                    pozMin = i;
                }
                if (maxSir < sir[i])
                {
                    maxSir = sir[i];
                    pozMax = i;
                }
            }

            Console.WriteLine($"Numarul minim este {minSir} pe pozitia {pozMin} si numarul maxim este {maxSir} pe pozitia {pozMax}.");
        }

        private static void problema1()
        {
            //se da un sir cu n elemente numere naturale. Sa se determine cate elemente din sir sunt egale cu ultimul elemnt al acestuia

            int n,i,contor=0;

            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            for (i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
                if (vector[i] == vector[n - 1])
                    contor++;

            Console.WriteLine(contor);
        }
    }
}
