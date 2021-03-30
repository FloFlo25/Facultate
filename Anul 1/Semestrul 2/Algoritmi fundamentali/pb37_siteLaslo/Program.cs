using System;
using System.Collections.Generic;
using System.IO;

namespace pb37_siteLaslo
{
    class Program
    {

        static int n, m;
        static int[,] a;
        static bool[,] b;
        static int counter;
        static bool found1, found2;

        static void view()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void road(int i, int j)//parcurgere in adancime --->pa
        {
            if ((i >= 0) && (j >= 0) && (i < n) && (j < m) && !b[i, j])
            {
                if (a[i, j] == 0)
                {
                    counter++;
                    b[i, j] = true;
                    road(i - 1, j);//Nord
                    road(i, j + 1);//Est
                    road(i + 1, j);//South
                    road(i, j - 1);//West
                }
                else
                {
                    if (a[i,j]==1)
                    {
                        found1 = true;
                    }
                    if (a[i,j]==2)
                    {
                        found2 = true;
                    }
                }
            }
        }


        static void load(string file_name)
        {
            TextReader data_load = new StreamReader(file_name);
            List<string> data = new List<string>();
            string buffer;

            while ((buffer = data_load.ReadLine()) != null)
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


        static void Main(string[] args)
        {
            int nr1 = 0;
            int nr2 = 0;
            int nrn = 0;

            load(@"E:\2.Visual Studio\FloFlo25\Facultate\Anul 1\Semestrul 2\Algoritmi fundamentali\pb37_siteLaslo\data.txt");
            view();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] == 0 && !b[i, j])
                    {
                        counter = 0;
                        found1 = false;
                        found2 = false;
                        road(i, j);

                        if (found1 && !found2)
                        {
                            nr1 += counter;
                        }
                        if (found2 && !found1)
                        {
                            nr2 += counter;
                        }
                        if (found1 && found2)
                        {
                            nrn += counter;
                        }


                        Console.WriteLine($"Island_1: {nr1}   Island_2: {nr2}   Island_0: {nrn}");
                    }
                }
            }
        }
    }
}
