using System;

namespace Pb5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool consec = true;

            //citire
            Console.Write("a= ");
            a=int.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            Console.Write("c= ");
            c = int.Parse(Console.ReadLine());


            //verif consecutive
            if (!(a == b - 1 && b==c-1))
            {
                consec = false;
            }
            if (consec)
                Console.WriteLine($"Numerele {a} {b} {c} sunt consecutive!");
            else
                Console.WriteLine($"Numerele {a} {b} {c} nu sunt consecutive!");

            //exemplu: 1 2 3 - consecutive
            //         3 5 4 - neconsecutive
        }
    }
}
