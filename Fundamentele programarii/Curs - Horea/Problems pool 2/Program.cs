using System;

namespace Problem_pool_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Text_indicatii
            int n;
            Console.WriteLine("----------------[Problem pool 1]----------------\n");
            Console.WriteLine(
                "1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. \n" +
                 "2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.\n" +
                 "3. Calculati suma si produsul numerelor de la 1 la n.\n" +
                 "4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.\n" +
                 "5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. \n" +
                 "6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. \n" +
                 "7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. \n" +
                 "8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...\n" +
                 "9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. \n" +
                 "10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. \n" +
                 "11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. \n" +
                 "12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. \n" +
                 "13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. \n" +
                 "14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. \n" +
                 "15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. \n" +
                 "16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. \n" +
                 "17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta."

                );
            Console.Write("\n");
            #endregion

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


                    case 8:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb8();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 9:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb9();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 10:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb10();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");

                        break;
                    case 11:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb11();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;

                    case 12:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb12();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;

                    case 13:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb13();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 14:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb14();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 15:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb15();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 16:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb16();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 17:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb17();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;
                        #endregion
                }

            }

            static void pb13()
            {
                Console.WriteLine("Incomplete.");
            }

            static void pb12()
            {
                int n, x1, x2, cont = 0;

                n = int.Parse(Console.ReadLine());

                x1 = int.Parse(Console.ReadLine());
                n--;

                while (n != 0)
                {
                    x2 = x1;
                    x1 = int.Parse(Console.ReadLine());

                    if (x2 != 0)
                        if (x1 == 0)
                            cont++;
                    n--;
                }
                Console.WriteLine($"contorul = {cont}");
            }

            static void pb11()
            {
                int n, sum = 0, x;

                n = int.Parse(Console.ReadLine());

                while (n != 0)
                {
                    x = int.Parse(Console.ReadLine());
                    sum = sum + (1 / x);
                    n--;
                }

                Console.WriteLine($"Suma inverselor = {sum}");
            }

            static void pb10()
            {
                int n;
                int prim, sec, consec = 0;
                bool ident = false;

                n = int.Parse(Console.ReadLine());

                prim = int.Parse(Console.ReadLine());
                n--;

                while (n != 0)
                {
                    sec = prim;
                    prim = int.Parse(Console.ReadLine());

                    if (prim == sec)
                    {
                        if (consec == 0)
                            consec++;
                        consec++;
                    }
                    if (consec == 1)
                        ident = true;
                    if (prim != sec && ident == true)
                        break;
                    n--;
                }

                if (consec != 0)
                    Console.WriteLine($"{consec} Numere consecutive");
                else
                    Console.WriteLine($"{consec} Numere consecutive");
            }

            static void pb9()
            {
                int n, nr1, nr2, schimbari = -1;
                bool cresc = false;
                bool descresc = false;

                n = int.Parse(Console.ReadLine());//6

                nr1 = int.Parse(Console.ReadLine());
                nr2 = int.Parse(Console.ReadLine());

                if (nr1 < nr2)
                    cresc = true;
                if (nr1 > nr2)
                    descresc = true;


                for (int i = 0; i < n - 2; i++)
                {
                    if (nr1 < nr2)
                    {
                        cresc = true;
                        descresc = false;
                        if (cresc == true)
                            schimbari++;
                    }
                    if (nr1 > nr2)
                    {
                        cresc = false;
                        descresc = true;
                        if (descresc == true)
                            schimbari++;
                    }

                    nr1 = nr2;
                    nr2 = int.Parse(Console.ReadLine());

                }

                if (schimbari > 1)
                    Console.WriteLine("Secventa nu este monotona.");
                else
                {
                    if (cresc)
                        Console.WriteLine("Secventa este monotona CRESCATOARE.");
                    if (descresc)
                        Console.WriteLine("Secventa este monotona DESCRESCATOARE.");
                }
                Console.WriteLine(schimbari);
            }

            static void pb8()
            {
                int n;

                n = int.Parse(Console.ReadLine());

                Console.WriteLine(afisareFibonacci(n));
            }

            static void pb7()
            {
                int n, x, min = 0, max = 99999;
                int i;
                bool ok = false;

                n = int.Parse(Console.ReadLine());

                for (i = 1; i <= n; i++)
                {
                    x = int.Parse(Console.ReadLine());

                    if (ok == false)
                    {
                        min = x;
                        max = x;
                        ok = true;
                    }

                    if (x < min)
                        min = x;
                    if (x > max)
                        max = x;
                }

                Console.WriteLine($"Minim:{min}    Maxim:{max}");
            }

            static void pb6()
            {
                int n, x, min = 0;
                bool ok = true;

                n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    if (x < min)
                    {
                        ok = false;
                        break;
                    }
                    min = x;
                }

                if (ok == false)
                    Console.WriteLine($"Numerele NU sunt crescatoare.");
                else
                    Console.WriteLine($"Numerele sunt crescatoare.");
            }

            static void pb5()
            {
                int n, i;
                int x, cont = 0;

                n = int.Parse(Console.ReadLine());

                for (i = 0; i < n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    if (x == i)
                        cont++;
                }

                Console.WriteLine("Elemente:" + cont);
            }

            static void pb4()
            {
                int a, n;
                int x;
                bool ok = false;

                n = int.Parse(Console.ReadLine());
                a = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    if (x == a)
                    {
                        Console.WriteLine(i);
                        ok = true;
                    }
                }

                if (ok == false)
                    Console.WriteLine(-1);
            }

            static void pb3()
            {
                int n;
                int sum = 0, prod = 1;

                n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    sum = sum + i;
                    prod = prod * i;
                }

                Console.WriteLine($"Suma:{sum} Produs:{prod}");
            }

            static void pb2()
            {
                int n, i, x;
                int poz = 0, neg = 0;

                n = int.Parse(Console.ReadLine());

                for (i = 1; i <= n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    if (x < 0)
                        neg++;
                    else if (x > 0)
                        poz++;

                }

                Console.WriteLine($"Neagtiv:{neg} Pozitiv:{poz}");
            }

            static void pb1()
            {
                int n, i;
                int x, cont = 0;

                n = int.Parse(Console.ReadLine());

                for (i = 1; i <= n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    if (x % 2 == 0)
                        cont++;
                }

                Console.WriteLine(cont);
            }

            static void pb16()
            {
                Console.WriteLine("Incomplete.");
            }

            static void pb15()
            {
                Console.WriteLine("Incomplete.");
            }

            static void pb14()
            {
                Console.WriteLine("Incomplete.");
            }

            static void pb17()
            {
                Console.WriteLine("Incomplete.");
            }


            //Ajutoare
            static int afisareFibonacci(int n)
            {
                if (n == 0)
                    return 0;
                if (n == 1)
                    return 1;
                return afisareFibonacci(n - 1) + afisareFibonacci(n - 2);
            }
        }
    }
}
