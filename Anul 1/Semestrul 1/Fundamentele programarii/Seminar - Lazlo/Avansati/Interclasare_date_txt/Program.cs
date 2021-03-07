using System;
using System.IO;

namespace Interclasare_date_txt
{
    class Program
    {


        static int n, m;
        static int[] v1;
        static int[] v2;
        static int[] vTotal;

        static void load(string fileName)
        {
            TextReader Load = new StreamReader(@"E:\Visual Studio\Teme\FloFlo25\Teme\Fundamentele programarii\Seminar - Lazlo\Avansati\Interclasare_date_txt\Date.txt");
            string[] buffer;
            buffer = (Load.ReadLine()).Split(' ');

            n = int.Parse(buffer[0]);
            m = int.Parse(buffer[0]);
            v1 = new int[n];
            v2 = new int[m];
            vTotal = new int[n + m];

            buffer = (Load.ReadLine()).Split(' ');
            for (int i = 0; i < n; i++)
            {
                v1[i] = int.Parse(buffer[i]);
            }

            buffer = (Load.ReadLine()).Split(' ');
            for (int i = m - 1; i >= 0; i--)
            {
                v2[i] = int.Parse(buffer[i]);
            }
        }

        static void view(int[] tov)
        {
            for (int i = 0; i < tov.Length; i++)
            {
                Console.Write(tov[i] + " ");
            }
            Console.WriteLine();
        }

        static void interclasare()
        {
            load(@"E:\Visual Studio\Teme\FloFlo25\Teme\Fundamentele programarii\Seminar - Lazlo\Avansati\Interclasare_date_txt\Date.txt");
            bool pare1 = false;
            bool pare2 = false;
            int i, j, p;
            i = 0;
            j = m - 1;


            while (i < n && j < m)
            {
                if (v1[i] < v2[j])
                    vTotal[p++] = v1[i++];
                else
                    vTotal[p++] = v2[j++];
            }
            while (i < n)
            {
                vTotal[p++] = v1[i++];
            }
            while (j < m)
            {
                vTotal[p++] = v2[j++];
            }

            foreach (var item in vTotal)
            {
                Console.Write(item + " ");
            }

        }
    }

    static void Main(string[] args)
    {
    }

}
