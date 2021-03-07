using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_FP_Floruta_Raul
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine($"~~~~~~~~~Examen - Fundamentele programarii - Floruta Raul~~~~~~~~~");

            while (true)
            {
                Console.Write("Alegeti problema dorita:");
                n = int.Parse(Console.ReadLine());
                Console.Write("\n");
                #region Case_switch
                switch (n)
                {
                    case 1:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb1();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;

                    case 2:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb2();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;

                    case 3:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb3();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 4:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb4();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 5:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb5();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 6:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb6();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 7:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb7();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;
                }
                #endregion

                static void pb7()
                {
                    Console.WriteLine("Incomplete");
                }

                static void pb6()
                {
                    Console.WriteLine("Incomplete");
                }

                static void pb5()
                {
                    Console.WriteLine("Incomplete");
                }

                static void pb4()
                {
                    int n = int.Parse(Console.ReadLine());
                    int sum = 0;
                    int[,] vect = new int[n, n];

                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                        {
                            vect[i, j] = int.Parse(Console.ReadLine());

                            if (i + j > n - 1)
                            {
                                if (IsPrim(vect[i, j]))
                                {
                                    sum = sum + vect[i, j];
                                }
                            }
                        }

                    Console.WriteLine(sum);


                }//gata

                static void pb3()
                {
                    int x = 100, max1 = 0, max2 = 0, max3 = 0, aux;
                    List<int> numbers = new List<int>();

                    Console.Write("x = ");
                    x = int.Parse(Console.ReadLine());
                    numbers.Add(x);

                    while (x != 0)
                    {
                        x = int.Parse(Console.ReadLine());
                        if (x != 0)
                            numbers.Add(x);
                        else
                            break;
                    }

                    foreach (var item in numbers)
                    {
                        x = item;
                        if (x != 0)
                        {
                            int xAux = x;


                            if (x >= max1)
                            {
                                aux = max1;
                                max1 = xAux;
                                xAux = aux;
                            }

                            if (x >= max2 && x <= max1)
                            {
                                aux = max2;
                                max2 = xAux;
                                xAux = aux;
                            }

                            if (x >= max3)
                            {
                                aux = max3;
                                max3 = xAux;
                                xAux = aux;
                            }

                            if (max2 >= max1)
                            {
                                aux = max1;
                                max1 = max2;
                                max2 = aux;
                            }

                            if (max3 >= max2)
                            {
                                aux = max2;
                                max2 = max3;
                                max3 = aux;
                            }
                        }
                        else
                            break;
                    }

                    Console.Write($"Max1 = {max1}     Max2 = {max2}       Max3 = {max3}");
                }//gata

                static void pb2()
                {
                    int[] vect = citireVector();
                    int lungime = vect.Length;
                    int t = int.Parse(Console.ReadLine());

                    for (int i = 0; i < lungime; i++)
                    {
                        if (vect[i] <= t)
                        {
                            int difference = t - vect[i];
                            for (int j = i + 1; j < lungime; j++)
                            {
                                if (vect[j] == difference)
                                {
                                    Console.WriteLine(i + " " + j);
                                }
                            }
                        }
                    }
                }//gata

                static void pb1()
                {
                    int n, m, x, rez;
                    m = 1;
                    rez = 0;
                    n = Convert.ToInt32(Console.ReadLine());

                    while (n != 0)
                    {
                        x = n % 10;
                        x = 9 - x;
                        n = n / 10;
                        rez = x * m + rez;
                        m = m * 10;
                    }

                    Console.WriteLine(rez);
                }//gata


                //Fucntii auxiliare
                static int[] citireVector()
                {
                    int[] x = Array.ConvertAll(Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                    return x;
                }
                static bool IsPrim(int nmb)
                {
                    if (nmb % 2 == 0)
                        return false;
                    int max = (int)Math.Floor(Math.Sqrt(nmb));

                    for (int i = 3; i <= max; i += 2)
                        if (nmb % i == 0)
                            return false;

                    return true;
                }
            }
        }
    }
}
