using System;
using System.IO;
using System.Linq;

namespace Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = new string[int.Parse(File.ReadLines(@"..\..\data02.in").First())];

            foreach (string line in File.ReadLines(@"..\..\..\data02.in").Skip(1))
            {
                if (IsPrime(int.Parse(line)))
                {
                    Console.Write(int.Parse(line) + " " + SumOfNumbers(int.Parse(line)) + " ");
                }
                else
                {
                    Console.Write(int.Parse(line) + " ");
                }
            }
        }

        public static int SumOfNumbers(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
