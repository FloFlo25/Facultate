using System;

namespace Pool1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("----------------[Problem pool 1]----------------\n");
            Console.WriteLine(
                "1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.\n" +
                 "2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.\n" +
                 "3. Determinati daca n se divide cu k, unde n si k sunt date de intrare.\n" +
                 "4. Detreminati daca un an y este an bisect.\n" +
                 "5. Extrageti si afisati a k - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.\n" +
                 "6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.\n" +
                 "7. (Swap)Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.\n" +
                 "8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.\n" +
                 "9. Afisati toti divizorii numarului n.\n" +
                 "10. Test de primalitate: determinati daca un numar n este prim.\n" +
                 "11. Afisati in ordine inversa cifrele unui numar n.\n" +
                 "12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].\n" +
                 "13. Determianti cati ani bisecti sunt intre anii y1 si y2.\n" +
                 "14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.\n" +
                 "15. Se dau 3 numere.Sa se afiseze in ordine crescatoare.\n" +
                 "16. Se dau 5 numere.Sa se afiseze in ordine crescatoare. (nu folositi tablouri)\n" +
                 "17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.Folositi algoritmul lui Euclid.\n" +
                 "18. Afisati descompunerea in factori primi ai unui numar n.De ex.pentru n = 1776 afisati 2^4 x 3^1 x 37^1.\n" +
                 "19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta.De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.\n" +
                 "20. Afisati fractia m / n in format zecimal, cu perioada intre paranteze(daca e cazul).Exemplu: 13 / 30 = 0.4(3).\n" +
                 "21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x? Raspundeti cu \"da\" sau \"nu\"."
                );
            Console.Write("\n");
            

            while (true)
            {
                Console.Write("Alegeti problema dorita:");
                n = int.Parse(Console.ReadLine());
                Console.Write("\n");
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


                    case 18:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb18();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 19:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb19();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 20:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb20();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;

                    case 21:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb21();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;
                }
            }
        }

        #region PROBLEME
        private static void pb3()
        {
            int n, k;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} NU se divide cu {k}");
        }

        private static void pb2()
        {
            int a, b, c;
            int x1, x2, delta;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            // ax^2 + bx + c = 0
            // delta = b^2 - 4ac

            delta = (int)Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Ecuatia nu are soltuii in R.");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Radacina ecuatiei este {-b / (2 * a)}");
            }
            else
            {
                x1 = (-b - (int)Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + (int)Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"Radacinilie ecuatiei sunt {x1} si {x2}");
            }
        }

        private static void pb1()
        {
            int a, b, x;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = -b / a;

            Console.WriteLine(x);
        }

        private static void pb21()
        {
            int x,ghici=0,cont=0;

            Random rand = new Random();
            x = rand.Next(1, 1024);

            

            while (ghici != x)
            {
                ghici = int.Parse(Console.ReadLine());
                if (ghici < x)
                    Console.WriteLine("Numarul e prea mic. Incearca unul mai mare.");
                else
                    if (ghici > x)
                    Console.WriteLine("Numarul e prea mare. Incearca unul mai mic.");
                cont++;
            }
            Console.Clear();

            Console.WriteLine($"Felicitari! Ai ghicit numarul {x} in {cont} incercari!");
        }

        private static void pb20()
        {
            //Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).
            /**/
            int m, n;
            int mInit, nInit;
            int[] resturi = new int[1000];
            int rest, i = 0, j = 0;
            string rez = "";
            bool ok = false;

            m = int.Parse(Console.ReadLine());//13
            n = int.Parse(Console.ReadLine());//30

            mInit = m;
            nInit = n;


            
            if (n == 0)
                Console.WriteLine($"Numarul {m} nu se poate impartii la {n}.");
            else
            {
                rest = m % n;//13
                while(rest !=0 && ok == false)
                {
                    resturi[i++] = rest;

                    m = rest * 10;//130
                    rest = m % n;//10
                    rez = rez + (m / n).ToString();

                    for (j = 0; j < resturi.Length; j++)
                        if (rest == resturi[j])
                        {
                            ok = true;
                            rez = rez.Insert(j, "(");
                            rez += ")";
                            break;
                        }
                }
                Console.WriteLine($"Fractia {mInit}/{nInit} este egala cu {mInit / nInit}{(rez != "" ? "." : "")}{rez} .");
            }


            /*float m = 13, n = 30;
            float x = m / n;
            string s = x.ToString();
            string[] subs = s.Split('.');
            string[] nr_separate = new string[subs.Length];

            Console.WriteLine($"Numarul original ---> {x}");

            for (int i = 0; i <= subs.Length; i++)
            {
                Console.WriteLine($"{nr_separate[i]}");
                //nr_separate[subs] = u;
            }
            */

        }

        private static void pb19()
        {
            int a, b, n, nInit;
            bool ok1 = true;
            bool ok2 = true;

            n = int.Parse(Console.ReadLine());

            nInit = n;

            a = n % 10;
            b = n / 10 % 10;
            n /= 10;

            while (n != 0)
            {
                if (n % 10 != a && ok1 == true)
                {
                    b = a;
                    a = n % 10;
                    n /= 10;
                }

                if (n % 10 != a && n % 10 != b)
                {
                    ok2 = false;
                    break;
                }
                n /= 10;
            }

            if (ok2 == true)
                Console.WriteLine($"Numarul {nInit} este format doar din 2 cifre");
            else
                Console.WriteLine($"Numarul {nInit} este format din mai mult de 2 cifre");
        }

        private static void pb18()
        {
            int n, d = 2, p;

            n = int.Parse(Console.ReadLine());

            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n /= d;
                }

                if (n / d <= 1 && p != 0)
                {
                    Console.Write($"{d}^{p}");
                    break;
                }

                if (p != 0)
                    Console.Write($"{d}^{p} + ");
                d++;

                if (n > 1 && d * d > n)
                    d = n;
            }
        }

        private static void pb17()//Euclid impartire(CMMDC si CMMMC)
        {
            int n, m, r;
            int nInit, mInit;

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            nInit = n;
            mInit = m;

            while (m != 0)
            {
                r = n % m;
                n = m;
                m = r;
            }

            Console.WriteLine($"CMMDC de [{nInit},{mInit}]={n}");
            Console.WriteLine($"CMMMC de [{nInit},{mInit}]={nInit * mInit / n}");
        }

        private static void pb16()
        {
            int a, b, c, d, e;
            bool ok = false;

            a = int.Parse(Console.ReadLine()); //5
            b = int.Parse(Console.ReadLine()); //8
            c = int.Parse(Console.ReadLine()); //12
            d = int.Parse(Console.ReadLine()); //3
            e = int.Parse(Console.ReadLine()); //1

            if (a > b)
                swap(ref a,ref b);
            if (a > c)
                swap(ref a, ref c);
            if (a > d)
                swap(ref a,ref d);
            if (a > e)
                swap(ref a, ref e);

            if (b > c)
                swap(ref b, ref c);
            if (b > d)
                swap(ref b, ref d);
            if (b > e)
                swap(ref b, ref e);

            if (c > d)
                swap(ref c, ref d);
            if (c > e)
                (c, e) = (e, c);

            if (d > e)
                swap(ref d, ref e);


            Console.WriteLine($"{a} {b} {c} {d} {e}");
        }

        private static void pb15()
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (c < a)
                swap(ref a, ref c);

            if (c < b)
                swap(ref b, ref c);

            if (b < a)
                swap(ref a, ref b);

            Console.WriteLine($"{a} {b} {c}");




        }

        private static void pb14()
        {
            int nr;

            nr = int.Parse(Console.ReadLine());

            if (oglindit(nr) == nr)
                Console.WriteLine($"Numarul {nr} este palindrom.");
            else
                Console.WriteLine($"Numarul {nr} NU este palindrom.");

        }

        private static void pb13()
        {
            int an, y1, y2, bis = 0;

            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            for (an = y1; an <= y2; an++)
                if (Bisect(an) == true)
                    bis++;

            Console.WriteLine($"Sunt {bis} ani bisecti intre {y1} si {y2}.");
        }

        private static void pb12()
        {
            int nr, a, b, i, div = 0;

            nr = int.Parse(Console.ReadLine());

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            for (i = a; i <= b; i++)
                if (nr % i == 0)
                    div++;

            Console.WriteLine($"Sunt {div} divizori a lui {nr} in intervalul [{a},{b}].");

        }

        private static void pb11()
        {
            int nr;
            int invers = 0;

            nr = int.Parse(Console.ReadLine());

            while (nr != 0)
            {
                invers = invers * 10 + nr % 10;
                nr /= 10;
            }
            Console.WriteLine($"Numarul inversat este {invers}.");
        }

        private static void pb10()
        {
            int nr;
            int d;
            bool prim = true;

            nr = int.Parse(Console.ReadLine());

            if (nr == 0 || nr == 1)
                prim = false;

            for (d = 2; d * d <= nr; d++)
                if (nr % d == 0)
                    prim = false;

            if (prim)
                Console.WriteLine($"Numarul {nr} este prim.");
            else
                Console.WriteLine($"Numarul {nr} NU este prim.");
        }

        private static void pb9()
        {
            int nr, div, i;

            nr = int.Parse(Console.ReadLine());

            if (nr == 0)
                Console.WriteLine("Numarul nu are divizori.");
            for (div = 1; div * div <= nr; div++)
            {
                Console.Write($"{div} ");
                if (div * div < nr)
                    Console.Write($"{nr / div} ");
            }
        }

        private static void pb8()
        {
            int a, b;

            a = int.Parse(Console.ReadLine());//4
            b = int.Parse(Console.ReadLine());//6

            a = a + b;//10
            b = a - b;//10-6=4
            a = a - b;//10-4=6

            Console.WriteLine($"Valoarea noua a lui a={a}");
            Console.WriteLine($"Valoarea noua a lui b={b}");
        }

        private static void pb7()
        {
            int a, b, aux;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"Valoarea noua a lui a={a}");
            Console.WriteLine($"Valoarea noua a lui b={b}");
        }

        private static void pb6()
        {
            int a, b, c;
            bool triunghi = true;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b + c || b > a + c || c > a + b)
                triunghi = false;
            if (triunghi == true)
            {
                Console.WriteLine($"{a} {b} {c} formeaza un triunghi.");
            }
            else
                Console.WriteLine($"{a} {b} {c} nu formeaza un triunghi.");
        }

        private static void pb5()
        {
            /// <summary>
            /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
            /// </summary>

            //12345678

            //1 2 3 4 5 6 7 8


            //nr.lenght = 8


            int nr, aux, i, k, cont = 0, poz;

            Console.Write("Numarul: ");
            nr = int.Parse(Console.ReadLine());
            Console.Write("Pozitia numarului dorit: ");
            k = int.Parse(Console.ReadLine());

            aux = nr;

            while (aux != 0)
            {
                cont++;
                aux /= 10;
            }
            poz = cont - k;

            for (i = 0; i < poz; i++)
            {
                nr /= 10;
            }
            Console.WriteLine($"Cifra de pe pozitia {k} este {nr % 10}");
        }

        private static void pb4()
        {
            /// <summary>
            /// Detreminati daca un an y este an bisect. 
            /// </summary>

            /*366 an bisect
             * daca an%4==0 >> an bisect
             * daca an%100==0 >> nu e an bisect
             * daca an%400==0 >> an bisect
            */

            int an;
            bool bisect = false;

            Console.Write("Scrieti anul: ");
            an = int.Parse(Console.ReadLine());

            if (an % 4 == 0)
            {
                //Console.WriteLine($"Anul {an} este an bisect.");
                bisect = true;
            }
            if (an % 100 == 0)
                Console.WriteLine($"Anul {an} nu este an bisect.");
            if (an % 400 == 0)
            {
                //Console.WriteLine($"Anul {an} este an bisect.");
                bisect = true;
            }

            if (bisect)
            {
                Console.WriteLine($"Anul {an} este an bisect.");
            }
            else
                Console.WriteLine($"Anul {an} nu este an bisect.");

        }
        #endregion


        #region FUNCTII AJUTATOARE
        private static bool Bisect(int an)
        {
            if ((an % 4 == 0) && (an % 100 != 0))
            {
                return true;
            }

            if (an % 400 == 0)
            {
                return true;
            }

            return false;
        }

        private static int oglindit(int nr)
        {
            int og = 0;
            while (nr != 0)
            {
                og = og * 10 + nr % 10;
                nr /= 10;
            }
            return og;
        }

        private static void swap(ref int a, ref int b)
        {
            int aux;
            aux = a;
            a = b;
            b = aux;
        }

        /*private static int citireInt(string s)
        {
            Console.WriteLine($"Introduceti un numar intreg {s}:");
            Console.Write($"{s} = ");
            return int.Parse(Console.ReadLine());
        }*/
        #endregion
    }
}
