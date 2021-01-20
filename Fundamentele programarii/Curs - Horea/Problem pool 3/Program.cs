using System;

namespace Problem_pool_3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Text_indicatii
            int n;
            Console.WriteLine("----------------[Problem pool 1]----------------\n");
            Console.WriteLine(
                "1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran. \n" +
                 "2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. \n" +
                 "3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). \n" +
                 "4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. \n" +
                 "5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. \n" +
                 "6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.  \n" +
                 "7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.\n" +
                 "8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. \n" +
                 "9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. \n" +
                 "10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. \n" +
                 "11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). \n" +
                 "12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. \n" +
                 "13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. \n" +
                 "14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). \n" +
                 "15. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. \n" +
                 "16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.\n" +
                 "17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b. \n" +
                 "18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr - un vector.Cel mai putin semnificativ coeficient este pe pozitia zero in vector.Se cere valoarea polinomului intr - un punct x. \n" +
                 "19. Se da un vector s(vectorul in care se cauta) si un vector p(vectorul care se cauta).Determinati de cate ori apare p in s.De ex.Daca s = [1, 2, 1, 2, 1, 3, 1, 2, 1] si p = [1, 2, 1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). \n" +
                 "20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2.Determinati numarul de suprapuneri(margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.Siragurile de margele se pot roti atunci cand le suprapunem.\n" +
                 "21. Se dau doi vectori.Se cere sa se determine ordinea lor lexicografica(care ar trebui sa apara primul in dictionar).\n" +
                 "22. Se dau doi vectori v1 si v2.Se cere sa determine intersectia, reuniunea, si diferentele v1 - v2 si v2 - v1(implementarea operatiilor cu multimi).Elementele care se repeta vor fi scrise o singura data in rezultat.\n" +
                 "23. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.\n" +
                 "24. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare(v[i] este 1 daca i face parte din multime si este 0 in caz contrar).\n" +
                 "25. (Interclasare) Se dau doi vector sortati crescator v1 si v2.Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.Sunt permise elemente duplicate.\n" +
                 "26. Se dau doua numere naturale foarte mari(cifrele unui numar foarte mare sunt stocate intr - un vector - fiecare cifra pe cate o pozitie).Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.\n" +
                 "27.  Se da un vector si un index in vectorul respectiv.Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.\n" +
                 "28. Quicksort.Sortati un vector folosind metoda QuickSort.\n" +
                 "29. MergeSort.Sortati un vector folosind metoda MergeSort.\n" +
                 "30. Sortare bicriteriala.Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i].Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.\n" +
                 "31. (Element majoritate).Intr - un vector cu n elemente, un element m este element majoritate daca mai mult de n / 2 din valorile vectorului sunt egale cu m(prin urmare, daca un vector are element majoritate acesta este unui singur).Sa se determine elementul majoritate al unui vector(daca nu exista atunci se va afisa < nu exista >). (incercati sa gasiti o solutie liniara)."
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


                    case 22:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb22();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 23:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb23();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 24:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb24();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 25:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb25();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 26:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb26();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;


                    case 27:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb27();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");

                        break;
                    case 28:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb28();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;

                    case 29:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb29();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;

                    case 30:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb30();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");

                        break;
                    case 31:
                        Console.WriteLine($"Ati ales problema {n}\n");
                        pb31();
                        Console.WriteLine("");
                        Console.WriteLine($"Incercati alta problema.");
                        break;
                        #endregion
                }

            }

        }

        private static void pb31()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb30()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb29()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb28()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb27()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb26()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb25()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb24()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb23()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb22()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb21()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb20()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb19()
        {
            Console.WriteLine("Incomplete.");
        }

        private static void pb18()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti vectorul: ");
            int[] v = citireVector();
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum = sum + v[i] * (int)Math.Pow(x, i);
            }

            Console.WriteLine($"Polinomul din {x} este {sum}");

        }

        private static void pb17()
        {
            Console.WriteLine("De finalizat!");
        }

        private static void pb16()
        {
            int[] v = citireVector();
            int cmmdc = v[0];
            int aux;

            for (int i = 1; i < v.Length; i++)
            {
                aux = v[i];
                while (aux!=cmmdc)
                {
                    if (aux > cmmdc)
                        aux = aux - cmmdc;
                    else if (aux < cmmdc)
                        cmmdc = cmmdc - aux;
                }
            }

            Console.WriteLine($"Cel mai mare divizor comun al vectorului este {cmmdc}");
        }

        private static void pb15()
        {
            int[] v = citireVector();
            int lung = v.Length;

            for (int i = 0; i < lung - 1; i++)
            {
                for (int j = i+1; j < lung; j++)
                {
                    if (v[i] == v[j])
                    {
                        for (int u = j + 1; u < lung; u++)
                        {
                            v[u - 1] = v[u];
                        }
                        lung--;
                        j--;
                    }
                }
            }

            for (int i = 0; i < lung; i++)
            {
                Console.Write(v[i] + " ");
            }

        }

        private static void pb14()
        {
            int[] v = citireVector();

            int zero = 0;
            for (int i = 0; i < v.Length - zero; i++)
                if (v[i] == 0)
                {
                    v[i] = v[v.Length - 1 - zero];
                    v[v.Length - 1 - zero] = 0;
                    zero++;
                }

            afisareVector(v);

        }

        private static void pb13()//INSERTION SORT
        {
            int[] v = citireVector();
            int n = v.Length;
            int key, j;

            for (int i = 1; i < n; i++)
            {
                key = v[i];
                j = i - 1;
                while(j>=0 && v[j]>key)
                {
                    v[j + 1] = v[j];
                    j = j - 1;
                }
                v[j + 1] = key;
            }
            afisareVector(v);
        }

        private static void pb12()//SELECTION SORT
        {
            int[] v = citireVector();
            int n = v.Length;
            int min_index;

            for (int i = 0; i < n-1; i++)
            {
                min_index = i;
                for (int j = i+1; j < n; j++)
                {
                    if (v[j]<v[min_index])
                    {
                        min_index = j;
                    }
                }
                swap(ref v[min_index],ref v[i]);
            }

            afisareVector(v);
        }

        private static void pb11()
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n + 1];

            for (int i = 2; i <= n; i++)
            {
                if(x[i]==0)
                {
                    Console.Write(i + " ");
                    for (int j = 2 * i; j <= n; j = j + i)
                    {
                        x[j] = 1;
                    }
                    
                }
            }
        }

        private static void pb10()
        {
            int[] v = citireVector();
            int k = int.Parse(Console.ReadLine());
            int flag = -1;

            for(int i = 0; i<v.Length;i++)
            {
                if (v[i] == k)
                {
                    flag = i;
                    break;
                }
            }

            Console.WriteLine(flag);

        }
        #region Problems
        private static void pb9()
        {
            int[] v = citireVector();
            int k = int.Parse(Console.ReadLine());
            int aux;

            while (k > 0)
            {
                aux = v[0];

                for (int i = 0; i < v.Length - 1; i++)
                {
                    v[i] = v[i + 1];
                }
                v[v.Length - 1] = aux;
                k--;
            }

            afisareVector(v);
        }

        private static void pb8()
        {
            int[] v = citireVector();


            Array.Resize(ref v, v.Length + 1);
            v[v.Length - 1] = v[0];

            for (int i = 0; i < v.Length - 1; i++)
            {
                v[i] = v[i + 1];
            }
            Array.Resize(ref v, v.Length - 1);

            afisareVector(v);
        }

        private static void pb7()
        {
            int[] v = citireVector();
            int aux;

            for (int i = 0; i < v.Length/2; i++)
            {
                aux = v[i];
                v[i] = v[v.Length - 1 - i];
                v[v.Length - 1 - i] = aux;
            }

            afisareVector(v);
        }

        private static void pb6()
        {
            int[] n = citireVector();
            int k;

            k = int.Parse(Console.ReadLine());

            for (int i = k - 1; i < n.Length - 1; i++)
            {
                n[i] = n[i + 1];
            }
            Array.Resize<int>(ref n, n.Length - 1);//array resizer


            afisareVector(n);
        }

        private static void pb5()
        {
            int[] v = citireVector();
            int e;
            int k;

            Console.Write("e= ");
            e = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());

            
            Array.Resize<int>(ref v, v.Length + 1);//array resizer
            
            for (int i = v.Length-1; i > k; i--)
            {
                v[i] = v[i - 1];
            }
            v[k] = e;

            foreach (int item in v)
            {
                Console.Write($"{item} ");
            }
        }

        private static void pb4()
        {
            int[] v = citireVector();
            int min = v[v.Length - 1], max = v[0];
            int aparMax = 1, aparMin = 1;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] <= min)
                {
                    if (v[i] == min)
                        aparMin++;
                    else
                    {
                        min = v[i];
                        aparMin = 1;
                    }
                }
                if (v[i] >= max)
                {
                    if (v[i] == max)
                        aparMax++;
                    else
                    {
                        max = v[i];
                        aparMax = 1;
                    }
                }
            }

            Console.WriteLine($"Maximul sirului ---> {max} ; Apartiile lui {max} ---> {aparMax}");
            Console.WriteLine($"Maximul sirului ---> {min} ; Apartiile lui {min} ---> {aparMin}");
        }

        private static void pb3()
        {
            int[] v = citireVector();
            int min = v[v.Length - 1], max = v[0];
            int min_index = v.Length, max_index = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < min)
                {
                    min_index = i;
                    min = v[i];
                }
                if (v[i] > max)
                {
                    max_index = i;
                    max = v[i];
                }
            }

            Console.WriteLine($"Pozitia minimului {min} ---> {min_index}\nPozitia maximului {max} ---> {max_index}");
        }
        
        private static void pb1()
        {
            int[] n = citireVector();
            int s = 0;

            foreach (int nr in n)
            {
                s = s + nr;
            }

            Console.WriteLine($"Suma numerelor din vector ---> {s}");
        }

        private static void pb2()
        {
            int[] v = citireVector();
            int k;


            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine($"Pozitia pe care se gaseste {k} pentru prima oara ---> {i}");
                    break;
                }
            }
        }
        #endregion

        #region Helping functions

        /// <summary>
        /// Citirea vectorului si convertirea sa
        /// </summary>
        /// <returns>Returneaza vectorul convertit</returns>
        private static int[] citireVector()
        {
            int[] x = Array.ConvertAll(Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            return x;
        }

        /// <summary>
        /// Citeste vectorul si il afiseaza cu cate un spatiu pe acelasi rand
        /// </summary>
        /// <param name="v"></param>
        private static void afisareVector(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }

        /// <summary>
        /// Swaps 'a' with 'b' int value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        #endregion
    }
}
