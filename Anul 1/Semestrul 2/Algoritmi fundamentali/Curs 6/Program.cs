using System;
using System.Collections.Generic;
using System.IO;

namespace Curs_6
{
    class Program
    {
        static int n, m;
        static int[,] a;
        static bool[,] b;
        static bool ok;
            

        static void load(string file_name)
        {
            TextReader data_load = new StreamReader(file_name);
            List<string> data = new List<string>();
            string buffer;

            while((buffer=data_load.ReadLine())!=null)
            {
                data.Add(buffer);//introducere text in List<string>data
            }

            n = data.Count;
            m = data[0].Length;

            a = new int[n, m];
            b = new bool[n, m];

            //transformare din string in int
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {//          [0/1 in ASCII]
                    a[i, j] = (data[i])[j] - '0';// 0 in ASCII = 48
                }
            }
        }

        static void road(int i, int j)//parcurgere in adancime --->pa
        {
            if ((i >= 0) && (j >= 0) && (i < n) && (j < m) && !b[i,j] && a[i,j]==1)
            {
                Console.WriteLine($"i:{i} j:{j} value:{a[i, j]}");

                if (j==m-1)
                {
                    ok = true;
                }

                b[i, j] = true;
                road(i - 1, j);//Nord
                road(i, j + 1);//Est
                road(i + 1, j);//South
                road(i, j - 1);//West
            }
        }

        static void view()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            load(@"E:\2.Visual Studio\FloFlo25\Facultate\Anul 1\Semestrul 2\Algoritmi fundamentali\Curs 6\matrice.txt");
            view();
            ok = false;
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (a[i, 0] == 1)
                    road(i, 0);
            }

            if (ok)
            {
                Console.WriteLine("Good good very good");
            }

            
        }
    }
}
