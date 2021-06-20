using System;
using System.Collections.Generic;
using System.IO;

namespace PARTIAL
{
    class Program
    {
        // A utility function that returns
        // true if x is perfect square
        static bool isPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }

        static bool isFibonacci(int n)
        {
            return isPerfectSquare(5 * n * n + 4) || isPerfectSquare(5 * n * n - 4);
        }


        public static int FibonacciSeq(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciSeq(n - 1) + FibonacciSeq(n - 2);
            }
        }

        public static int MyClosestFibonacci(int num)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;

            return (int)Math.Floor((Math.Pow(phi,num)-Math.Pow((1-phi),num)/Math.Sqrt(5)));
        }


        static int ClosestFibonacci(int num)
        {
            if (num < 1)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                List<int> Fibonachi = new List<int>();
                Fibonachi.Add(1);
                Fibonachi.Add(1);
                while (true)
                {
                    int index = Fibonachi.Count;
                    Fibonachi.Add(Fibonachi[index - 1] + Fibonachi[index - 2]);
                    if (Fibonachi[Fibonachi.Count - 1] > num)
                    {
                        break;
                    }
                }
                return Fibonachi[Fibonachi.Count - 2];
            }
        }


        static void Main(string[] args)
        {
            int[] v;

            #region TextReader
            List<string> data = new List<string>();
            TextReader data_load = new StreamReader(@"..\..\..\ex01.in");
            string buffer;

            while ((buffer = data_load.ReadLine()) != null)
            {
                data.Add(buffer);
            }

            string[] numbers = data[0].Split(' ');//sterge whitespace-urile
            int n = numbers.Length;
            v = new int[n];


            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(numbers[i]);//convert from string to int
            }

            #endregion

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Se adauga {ClosestFibonacci(v[i])} pentru a obtine cel mai apropriat FibNmb de {v[i]}"); 
            }*/

            Console.WriteLine(MyClosestFibonacci(v[0]));
        }
    }
}
