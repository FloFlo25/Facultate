using System;

namespace Curs_8
{
    class Program
    {

        static void back(int k, int n, int[] sol, bool[] vis)
        {
            if (k >= n)
            {
                bool ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (sol[i] == sol[j])
                        {
                            ok = false;
                            break;

                        }

                    }
                }
                if (ok)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(sol[i]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        back(k + 1, n, sol, vis);

                    }
                }
            }
        }

        static void permutari(int k, int n, int[] sol, bool[] vis)
        {
            if (k >= n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(sol[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        permutari(k + 1, n, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }

        static void aranjamente(int k, int n, int p, int[] sol, bool[] vis)
        {
            if (k >= p)
            {
                for (int i = 0; i < p; i++)
                {
                    Console.Write(sol[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        aranjamente(k + 1, n, p, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }

        //combinari

        static void combinari()
        {

        }

        static void Main(string[] args)
        {
            /*for (int i1 = 1; i1 <= 6; i1++)
            {
                for (int i2 = 1; i2 <= 6; i2++)
                {
                    for (int i3 = 1; i3 <= 6; i3++)
                    {
                        for (int i4 = 1; i4 <= 6; i4++)
                        {
                            for (int i5 = 1; i5 <= 6; i5++)
                            {
                                for (int i6 = 1; i6 <= 6; i6++)
                                {
                                    if ((i1 != i2) && (i1 != i3) && (i1 != i4) && (i1 != i5) && (i1 != i6) &&
                                        (i2 != i3) && (i2 != i4) && (i2 != i5) && (i2 != i6) && (i3 != i4)
                                        && (i3 != i5) && (i3 != i6) && (i4 != i5) && (i4 != i6) && (i5 != i6))
                                    {

                                    }
                                    Console.WriteLine(i1.ToString() + i2 + i3 + i4 + i5 + i6);
                                }
                            }
                        }
                    }
                }
            }*/

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int[] sol = new int[n];
            bool[] vis = new bool[n];

            for (int i = 0; i < n; i++)
            {
                vis[i] = false;
            }
            aranjamente(0, n, p, sol, vis);
        }
    }
}
